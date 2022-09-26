using System;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Entities;

public sealed class PackingList
{
	public Guid Id { get; private set; }
	private PackingListName _name;
	private string _localization;

	internal PackingList(PackingListName name, string localization, Guid id)
	{
		_name = name;
		_localization = localization;
		Id = id;
	}
}