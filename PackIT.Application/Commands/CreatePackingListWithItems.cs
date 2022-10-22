using PackIT.Domain.Constants;
using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Application.Commands;

public sealed record CreatePackingListWithItems(
	Guid Id, string Name, ushort Days, Gender Gender, LocalizationWriteModel Localization) : ICommand;

public sealed record LocalizationWriteModel(string City, string Country);