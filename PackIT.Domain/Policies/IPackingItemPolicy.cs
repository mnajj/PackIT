using System.Collections.Generic;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies;

public interface IPackingItemPolicy
{
	bool IsApplicable(PolicyData policyData);
	IEnumerable<PackingItem> GenerateItems(PolicyData policyData);
}