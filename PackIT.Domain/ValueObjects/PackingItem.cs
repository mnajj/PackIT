using System.Reflection.PortableExecutable;
using System.Text;
using PackIT.Domain.Exceptions;
using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Domain.ValueObjects;

public record PackingItem : ICommand
{
	public string Name { get; }
	public uint Quantity { get; }
	public bool IsPacked { get; init; }

	public PackingItem(string name, uint quantity, bool isPacked = false)
	{
		if (string.IsNullOrWhiteSpace(Name)) throw new EmptyPackingListItemNameException();
		Name = name;
		Quantity = quantity;
		IsPacked = isPacked;
	}
}