using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class InvalidTemperatureException : PackItException
{
	public InvalidTemperatureException(double value) : base($"Value: {value} is invalid temperature")
	{
	}
}