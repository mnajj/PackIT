using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using PackIT.Domain.Events;
using PackIT.Domain.Exceptions;
using PackIT.Domain.ValueObjects;
using PackIT.Shared.Abstractions.Domain;

namespace PackIT.Domain.Entities;

public sealed class PackingList : AggregateRoot<Guid>
{
	public PackingListId Id { get; private set; }
	private PackingListName _name;
	private Localization _localization;
	private readonly LinkedList<PackingItem> _items = new();


	internal PackingList(Guid id, PackingListName name, Localization localization)
	{
		_name = name;
		_localization = localization;
		Id = id;
	}


	private PackingList(Guid id, PackingListName name, Localization localization, LinkedList<PackingItem> items)
		: this(id, name, localization)
	{
		_items = items;
	}

	public void AddItem(PackingItem item)
	{
		if (_items.Contains(item))
		{
			throw new PackingItemAlreadyExistsException(_name, item.Name);
		}

		_items.AddLast(item);
		AddEvent(new PackingItemAdded(this, item));
	}

	public void AddItems(IEnumerable<PackingItem> items)
	{
		foreach (var item in items)
		{
			AddItem(item);
		}
	}

	public PackingItem GetItem(string itemName)
	{
		var item = _items.SingleOrDefault(i => i.Name == itemName);
		if (item is null)
		{
			throw new PackingItemNotFoundException(itemName);
		}

		return item;
	}

	public void PackItem(string itemName)
	{
		var item = GetItem(itemName);
		var packedItem = item with { IsPacked = true };
		_items.Find(item)!.Value = packedItem;
		AddEvent(new PackingItemPacked(this, item));
	}

	public void RemoveItem(string itemName)
	{
		var item = GetItem(itemName);
		_items.Remove(item);
		AddEvent(new PackingItemRemoved(this, item));
	}
}