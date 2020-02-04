using System;
using System.Collections.Generic;
using System.Text;

namespace Progr_prov_del_2
{
    class ContraCar : Car
    {
        public ContraCar()
        {
            passengers = rand.Next(1, 4 + 1);
            conteabandAmount = rand.Next(1, 4 + 1);
        }
    }
}
