using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComp.Data
{
    internal class TariffModel
    {
        public string Name { get; set; }

        public ITariffCostsCalculation CostsCalculation { get; set; }
    }
}
