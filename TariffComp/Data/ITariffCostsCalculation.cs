using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComp.Data
{
    internal interface ITariffCostsCalculation
    {
        double CalculateCosts(double consumptionInKWh);
    }
}
