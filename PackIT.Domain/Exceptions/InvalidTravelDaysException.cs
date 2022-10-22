using System.Text.Json.Serialization;
using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class InvalidTravelDaysException : PackItException
{
	public InvalidTravelDaysException(ushort days) : base($"Value: {days} is invalid travel days")
	{
	}
}