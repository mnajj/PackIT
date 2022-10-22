using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class PackingItemAlreadyExistsException : PackItException
{
	public PackingItemAlreadyExistsException(string listName, string itemName) :
		base($"Packing list: {listName} already defined item {itemName}")
	{
	}
}