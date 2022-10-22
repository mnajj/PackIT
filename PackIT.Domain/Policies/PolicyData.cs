using PackIT.Domain.Constants;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies;

public sealed record PolicyData(
	TravelDays TravelDays,
	Constants.Gender Gender,
	ValueObjects.Temperature Temperature,
	Localization Localization);