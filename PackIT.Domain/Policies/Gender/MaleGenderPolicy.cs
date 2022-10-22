using System;
using System.Collections.Generic;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Gender;

internal class MaleGenderPolicy : IPackingItemPolicy
{
	public bool IsApplicable(PolicyData policyData) => policyData.Gender is Constants.Gender.Male;

	public IEnumerable<PackingItem> GenerateItems(PolicyData policyData)
		=> new List<PackingItem>()
		{
			new("Laptop", 1),
			new("Book", (uint)Math.Ceiling(policyData.TravelDays / 7M))
		};
}