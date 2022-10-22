using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyPackingListItemNameException : PackItException
{
	public EmptyPackingListItemNameException() : base("Name can't be empty")
	{
	}
}