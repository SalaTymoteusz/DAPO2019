using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 


namespace ATM_Machine
{
    public class Bankomat
    {
        Konto konto1 = new Konto(1234,1,1000);
        Telefon telefon1 = new Telefon(123456789, 21.37f);
        private bool poprawnyPin;
        bool running;
        int proby = 0;

        public void Uruchom()
        {
            running = true;
            while(running == true)
            {
                if(proby < 3)
                {
                    Console.WriteLine("Witamy w sieci bankomatów w Orgrimarze. Podaj pin swojej karty aby kontynuować.");
                    int pin = int.Parse(Console.ReadLine());

                    poprawnyPin = SprawdzPin(pin);

                    if (poprawnyPin == true)
                    {
                        while (running == true)
                        {
                            Console.WriteLine("\n\nCo chciałbyś zrobić?");
                            Console.WriteLine("1. Sprawdź stan konta");
                            Console.WriteLine("2. Wypłać pieniądze");
                            Console.WriteLine("3. Doładuj Telefon");
                            Console.WriteLine("4. Wyjście");
                            int ch = int.Parse(Console.ReadLine());
                            switch (ch)
                            {
                                //podzielić to na funkcje w domu
                                case 1:
                                    Funkcja1();
                                    break;
                                case 2:
                                    Funkcja2();
                                    break;
                                case 3:
                                    Funkcja3();
                                    break;
                                case 4:
                                    Funkcja4();
                                    break;
                                default:
                                    FunkcjaDefault();                                  
                                    break;
                           }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Błędny pin. Masz jeszcze: " + (2-proby) +" prób");
                        proby++; 
                    }
                }
                else
                {
                    Console.WriteLine("Podałeś zły pin zbyt dużą ilość razy. Blokada Karty.");
                    running = false;
                }
                
            }
            Console.WriteLine("Koniec działania. Zapraszamy ponownie");
            Console.ReadLine();
        }

        public float SprawdzIloscPieniedzyNaKoncie()
        {
            return konto1.PodajIloscPieniedzy();
        }

        public int WyplacHajs(int hajs)
        {
            return hajs;
        }

        public bool SprawdzPin(int pin)
        {

            if(pin == konto1.PodajPin())
            {
                Console.WriteLine("Poprawny Pin");
                return true;
            }
            else
            {
                Console.WriteLine("Niepoprawny Pin. Proszę spróbować ponownie.");
                return false;
            }
        }

        private void Funkcja1()
        {
            Console.WriteLine("Na twoim koncie znajduje się: " + SprawdzIloscPieniedzyNaKoncie() + "zł");
        }

        private void Funkcja2()
        {
            Console.WriteLine("Ile pieniędzy chciałbyś wypłacić? Bankomat wypłaca tylko banknoty o nominałach 10,20,50 i 100 złotych");
            float kwotaZKonta = float.Parse(Console.ReadLine());
            if (kwotaZKonta % 10 == 0)
            {
                if (konto1.PodajIloscPieniedzy() >= kwotaZKonta)
                {
                    Console.WriteLine("Wypłacasz: " + kwotaZKonta + " zł");
                    konto1.SetIloscPieniedzy(kwotaZKonta);
                    Console.WriteLine("Na koncie zostaje Ci: " + konto1.PodajIloscPieniedzy() + " zł");

                }
            }
            else
            {
                Console.WriteLine("Błęda kwota. Musisz podać kwotę podzielną przez 10!");
            }

        }

        private void Funkcja3()
        {
            Console.WriteLine("Na twoim telefonie o numerze: " + telefon1.GetNumerTelefonu() + " znajduje się obecnie " + telefon1.GetStanKonta() + " zł");
            Console.WriteLine("Podaj Kwotę którą chciałbyś zasilić konto: ");
            float kwotaNaKonto = float.Parse(Console.ReadLine());
            if (kwotaNaKonto < konto1.PodajIloscPieniedzy())
            {
                konto1.SetIloscPieniedzy(kwotaNaKonto);
                telefon1.SetStanKonta(kwotaNaKonto);
                Console.WriteLine("Nowy stan konta to obecnie: " + telefon1.GetStanKonta() + " zł");

            }
            else
            {
                Console.WriteLine("Brak odpowiedniej ilości środków. Brakuje Ci: " + (kwotaNaKonto - konto1.PodajIloscPieniedzy()) + " zł");
            }
        }

        private void Funkcja4()
        {
            Console.WriteLine("Wyjście z konta.");
            running = false;
        }

        private void FunkcjaDefault()
        {
            Console.WriteLine("Proszę wybrać poprawną opcję o 1 do 4");
        }


    }
}
