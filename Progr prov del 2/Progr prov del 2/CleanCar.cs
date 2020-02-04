using System;
using System.Collections.Generic;
using System.Text;

namespace Progr_prov_del_2
{
    class CleanCar : Car
    {
        public CleanCar()
        {
            passengers = rand.Next(1, 3 + 1);
            conteabandAmount = 0;
        }
    }
}
