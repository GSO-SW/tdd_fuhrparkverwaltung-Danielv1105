using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace Fuhrparkverwaltung
{
    public class Auto
    {

        private int kilometerstand;
        public Auto(int kilometerstand)
        {
            kilometerstand = this.kilometerstand;
        }

        public void Fahren(int streckeInKilometern)
        {
            int gefahreneStrecke += streckeInKilometern; 

            return gefahreneStrecke;
        }

        public int Kilometerstand
        {
           get { return this.kilometerstand; }
           set { kilometerstand = value; }
        }

    }
}
