using System;
using System.Collections.Generic;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Universal;

internal sealed class BasicPolicy : IPackingItemPolicy
{
	private const uint MaximumQuantityOfClothes = 7;

	public bool IsApplicable(PolicyData _) => true;

	public IEnumerable<PackingItem> GenerateItems(PolicyData policyData)
		=> new List<PackingItem>()
		{
			new("Pants", Math.Min(policyData.TravelDays, MaximumQuantityOfClothes)),
			new("Socks", Math.Min(policyData.TravelDays, MaximumQuantityOfClothes)),
			new("T-Shirt", Math.Min(policyData.TravelDays, MaximumQuantityOfClothes)),
			new("Trousers", policyData.TravelDays < 7 ? 1U : 2U),
			new("Shampoo", 1),
			new("Toothbrush", 1),
			new("Toothpaste", 1),
			new("Towel", 1),
			new("Bag pack", 1),
			new("Passport", 1),
			new("Phone Charger", 1)
		};
}