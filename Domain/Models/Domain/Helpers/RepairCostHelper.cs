using System.Collections.Generic;
using HomeApplianceRepairCenter.Domain.Interfaces;

namespace HomeApplianceRepairCenter.Domain.Helpers
{
    public static class RepairCostHelper
    {
        public static decimal CalculateTotalCost(IEnumerable<IMaintainable> appliances)
        {
            decimal total = 0;

            foreach (var appliance in appliances)
            {
                total += appliance.CalculateRepairCost();
            }

            return total;
        }
    }
}
