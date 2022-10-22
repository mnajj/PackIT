using PackIT.Domain.ValueObjects;
using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Application.Exceptions;

public class MissingLocalizationWeatherException : PackItException
{
	public MissingLocalizationWeatherException(Localization localization) :
		base($"Couldn't fetch weather data for localization {localization.Country}, {localization.City}")
	{
	}
}