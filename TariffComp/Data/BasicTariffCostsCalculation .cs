using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComp.Data
{
    public class BasicTariffCostsCalculation : ITariffCostsCalculation
    {
        public int periodInMonths { get; set; } = 12;

        public double BaseCostsPerMonth { get; set; }

        public double ConsumptionCostsPerKWh { get; set; }

        public double CalculateCosts(double consumptionInKWh)
        {
            return BaseCostsPerMonth * periodInMonths + ConsumptionCostsPerKWh * consumptionInKWh;
        }
    }
}
