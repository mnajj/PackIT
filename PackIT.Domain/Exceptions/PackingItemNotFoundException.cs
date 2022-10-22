using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class PackingItemNotFoundException : PackItException
{
	public string ItemName { get; set; }

	public PackingItemNotFoundException(string itemName) : base($"Packing item: {itemName} not found")
	{
		ItemName = itemName;
	}
}