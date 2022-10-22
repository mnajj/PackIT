using System;
using System.Threading.Tasks;
using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Repositories;

public interface IPackingListRepository
{
	Task<PackingList> GetByIdAsync(Guid id);
	Task AddAsync(PackingList packingList);
	Task UpdateAsync(PackingList packingList);
	Task DeleteAsync(PackingList packingList);
}