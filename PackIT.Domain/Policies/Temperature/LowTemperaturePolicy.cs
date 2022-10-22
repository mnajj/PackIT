using System.Collections.Generic;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Temperature;

internal sealed class LowTemperaturePolicy : IPackingItemPolicy
{
	public bool IsApplicable(PolicyData policyData)
		=> policyData.Temperature < 100;

	public IEnumerable<PackingItem> GenerateItems(PolicyData policyData)
		=> new List<PackingItem>()
		{
			new("Scarf", 1),
			new("Gloves", 1),
			new("Warm jacket", 1),
		};
}