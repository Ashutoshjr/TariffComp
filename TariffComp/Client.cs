// See https://aka.ms/new-console-template for more information




using TariffComp.Manager;
using TariffComp.Repository;



var tariffManager = new TariffManager(new TariffRepository());

var result = tariffManager.GetTariffsByAnnualConsumption(4500);


foreach (var item in result)
{
    Console.WriteLine($"Tariff Name :{item.TariffName} -- Annual Cost - {item.AnnualCosts} ");
}




Console.ReadKey();