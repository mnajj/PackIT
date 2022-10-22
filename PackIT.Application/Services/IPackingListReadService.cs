using PackIT.Domain.ValueObjects;

namespace PackIT.Application.Services;

public interface IPackingListReadService
{
	Task<bool> IsExistByNameAsync(PackingListName name);
}