using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    class Konto
    {

        int pin, numerKonta;
           float iloscPieniedzy;

        public Konto(int a, int b, int c)
        {
            pin = a;
            numerKonta = b;
            iloscPieniedzy = c;
        }

        public float PodajIloscPieniedzy()
        {
            return iloscPieniedzy;
        }

        public int PodajPin()
        {
            return pin;
        }

        public void SetIloscPieniedzy(float a)
        {
            iloscPieniedzy -= a;
        }


    }
}
