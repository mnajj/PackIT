using System.Linq;

namespace PackIT.Domain.ValueObjects;

public record Localization(string City, string Country)
{
	public static Localization Create(string value)
	{
		var splitLoc = value.Split(',');
		return new Localization(splitLoc.First(), splitLoc.Last());
	}

	public override string ToString()
	{
		return $"{City}, {Country}";
	}
}