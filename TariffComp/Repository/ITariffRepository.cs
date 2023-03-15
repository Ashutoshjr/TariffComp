using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TariffComp.Data;

namespace TariffComp.Repository
{
    internal interface ITariffRepository
    {
        List<TariffModel> GetAll();
    }
}
