using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TariffComp.Data;

namespace TariffComp.Repository
{
    internal class TariffRepository : ITariffRepository
    {
        
        public List<TariffModel> GetAll()
        {
            List<TariffModel> tariffList= new List<TariffModel>();

            tariffList.Add(new TariffModel
            {
                Name = "basic electricity tariff",
                CostsCalculation = new BasicTariffCostsCalculation { BaseCostsPerMonth = 5, ConsumptionCostsPerKWh = 0.22 }
            });

            tariffList.Add(new TariffModel
            {
                Name = "Packaged tariff",
                CostsCalculation = new PackagedTariffCostsCalculation { AnnualBaseCosts = 800, AnnualBaseCostsLimitInKWh = 4000, ConsumptionCostsPerKWh = 0.30 }
            });

            return tariffList;
        }

    }
}
