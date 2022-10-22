using System.Collections.Generic;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Temperature;

internal sealed class HighTemperaturePolicy : IPackingItemPolicy
{
	public bool IsApplicable(PolicyData policyData)
		=> policyData.Temperature >= 250;

	public IEnumerable<PackingItem> GenerateItems(PolicyData policyData)
		=> new List<PackingItem>()
		{
			new("Hat", 1),
			new("Sunglasses", 1),
		};
}