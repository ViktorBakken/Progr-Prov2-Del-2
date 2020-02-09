using System;
using System.Collections.Generic;
using System.Text;

namespace Progr_prov_del_2
{
    class Car
    {
        protected Random rand = new Random();
        protected int passengers;
        protected int conteabandAmount;
        private bool alreadyChecked = false;

        public bool AlreadyChecked
        {
            get
            {
                return alreadyChecked;
            }
            set
            {
                alreadyChecked = value;
            }
        }
        public bool Examine()
        {
            alreadyChecked = true;
            int probaility = (conteabandAmount * 20) / 10;

            if (rand.Next(1, 10 + 1) < probaility) 
            {
                return true;
            }

            return false;

        }
    }
}
