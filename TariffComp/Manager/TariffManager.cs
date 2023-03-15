using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TariffComp.Data;
using TariffComp.Model;
using TariffComp.Repository;

namespace TariffComp.Manager
{
    internal class TariffManager
    {
        private ITariffRepository _tariffRepository;

        public TariffManager(ITariffRepository tariffRepository)
        {
            _tariffRepository = tariffRepository;
        }

        public List<Tariff> GetTariffsByAnnualConsumption(double annualConsumption)
        {
            if (annualConsumption < 0)
                Console.WriteLine("Exception : Value cannot be null");

            var allTariffs = _tariffRepository.GetAll();

            var tariff = allTariffs.Select(tariff => new Tariff
            {
                TariffName = tariff.Name,
                AnnualCosts = tariff.CostsCalculation?.CalculateCosts(annualConsumption) ?? double.NaN,
            });

            return tariff.OrderBy(tariff => tariff.AnnualCosts).ToList();
        }
    }
}
    