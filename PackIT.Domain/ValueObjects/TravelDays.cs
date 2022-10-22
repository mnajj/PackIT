using System;
using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects;

public record TravelDays
{
	public ushort Value { get; }

	public TravelDays(ushort value)
	{
		if (value is 0 or > 100)
		{
			throw new InvalidTravelDaysException(value);
		}

		Value = value;
	}

	public static implicit operator ushort(TravelDays travelDays) => travelDays.Value;
	public static implicit operator TravelDays(ushort travelDays) => new(travelDays);
}