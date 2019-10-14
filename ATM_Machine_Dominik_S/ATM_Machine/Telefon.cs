using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    class Telefon
    {
        int numerTelefonu;
        float stanKonta;

        public Telefon(int a, float b)
        {
            numerTelefonu = a;
            stanKonta = b;
        }

        public int GetNumerTelefonu()
        {
            return numerTelefonu;
        }

        public float GetStanKonta()
        {
            return stanKonta;
        }

        public void SetStanKonta(float a)
        {
            stanKonta += a;
        }

    }
}
