using System;
using System.Collections.Generic;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Gender;

internal class FemaleGenderPolicy : IPackingItemPolicy
{
	public bool IsApplicable(PolicyData policyData) => policyData.Gender is Constants.Gender.Female;

	public IEnumerable<PackingItem> GenerateItems(PolicyData policyData)
		=> new List<PackingItem>()
		{
			new("Lipstick", 1),
			new("Eyeliner", 1)
		};
}