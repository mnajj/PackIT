using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Application.Commands;

public record DeletePackingList(Guid Id) : ICommand;