using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComp.Data
{
    internal class PackagedTariffCostsCalculation : ITariffCostsCalculation
    {
        public int periodInMonths { get; set; } = 12;

        public double AnnualBaseCostsLimitInKWh { get; set; }

        public double AnnualBaseCosts { get; set; }

        public double ConsumptionCostsPerKWh { get; set; }

        public double CalculateCosts(double consumptionInKWh)
        {
            double baseCosts = AnnualBaseCosts / 12 * periodInMonths;

            if (consumptionInKWh / periodInMonths <= AnnualBaseCostsLimitInKWh / 12)
                return baseCosts;

            double baseCostsLimit = AnnualBaseCostsLimitInKWh / 12 * periodInMonths;
            return baseCosts + ((consumptionInKWh - baseCostsLimit) * ConsumptionCostsPerKWh);
        }
    }
}
