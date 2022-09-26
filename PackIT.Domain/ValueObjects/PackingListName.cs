using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects;

public sealed record PackingListName
{
	public string Value { get; }

	public PackingListName(string value)
	{
		if (string.IsNullOrEmpty(value)) throw new EmptyPackingListNameException();
		Value = value;
	}

	public static implicit operator string(PackingListName packingListName)
	{
		return packingListName.Value;
	}

	public static implicit operator PackingListName(string name)
	{
		return new(name);
	}
}