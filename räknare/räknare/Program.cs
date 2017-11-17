using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace räknare
{
    class Program
    {
        static void Main(string[] args)
        {

            start:
            try
            {
                Console.WriteLine("Ange ampere");
                float amp = float.Parse(Console.ReadLine());
                Console.WriteLine("Ange volt");
                float volt = float.Parse(Console.ReadLine());
                Console.WriteLine("Tiden behöver vara i sekunder, behöver tiden omvandlas från timmar eller minuter? ja/nej");
                string svar = Console.ReadLine();
                float tim2sek = 0;
                float min2sek = 0;
                float sek = 0;

                if (svar == "ja" || svar=="JA" || svar=="Ja")
                {
                    del1:
                    Console.WriteLine("timmar eller minuter");
                    string svar2 = Console.ReadLine();
                    if (svar2.Contains("tim") || svar2.Contains("Tim") || svar2.Contains("TIM"))
                    {
                        Console.WriteLine("Ange tid i timmar");
                        tim2sek = float.Parse(Console.ReadLine());
                        sek = tim2sek * 3600;
                    }

                    else if (svar2.Contains("min") || svar2.Contains("MIN") || svar2.Contains("Min"))
                    {
                        Console.WriteLine("Ange tid i minuter");
                        min2sek = float.Parse(Console.ReadLine());
                        sek = min2sek * 60;
                    }

                    else
                    {
                        Console.WriteLine("du är helt cp");
                        Console.ReadLine();
                        goto del1;
                    }


                } else
                {
                    Console.WriteLine("ange sekunder");
                    sek = float.Parse(Console.ReadLine());
                }




                Console.WriteLine("Dina coulumbs är");
                Console.WriteLine(amp * volt * sek);



                Console.ReadLine();
            } catch {
                Console.WriteLine("Hallå det där var cp skriv rätt");
                goto start;
                    
                    }
            } 
        
    }
}
