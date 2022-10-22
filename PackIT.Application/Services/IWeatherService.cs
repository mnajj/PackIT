using PackIT.Application.Dtos.External;
using PackIT.Domain.ValueObjects;

namespace PackIT.Application.Services;

public interface IWeatherService
{
	Task<WeatherDto?> GetWeatherAsync(Localization localization);
}