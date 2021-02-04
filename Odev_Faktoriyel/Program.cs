using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Faktoriyel
{
    /*
     * Bir sayının sürekli 1 azaltılarak arka arkaya yapılan çarpım faktoriyeldir.
        Örneğin 5 faktoriyel 5! şeklinde gösterilir ve 5! = 5 * 4 * 3 * 2 * 1 olarak hesaplanır.
        Basit bir faktoriyel hesaplama konsol uygulaması yazınız:
        1) Kullanıcıdan tek seferlik pozitif bir tam sayı alınır.
        2) Kullanıcının girdiği sayının faktoriyeli hesaplanarak ekrana yazdırılır.
    */

    class Program
    {
        static void Main(string[] args)
        {
            int a, sonuc;
            Console.Write("Lütfen bir pozitif sayı giriniz: ");
            string veriGiris = Console.ReadLine();

            while (veriGiris != "q")
            {
                sonuc = 1;
                a = Convert.ToInt32(veriGiris);
                

                if (a == 0 || a > 0)
                {
                    for (int i = 1; i <= a; i++)
                    {
                        sonuc = i * sonuc;

                    }

                    Console.WriteLine("Sonuç: " + sonuc);
                }

                else
                {
                    Console.WriteLine("Lütfen pozitif bir tamsayı girin!");
                    
                }

                Console.Write("Lütfen bir pozitif sayı giriniz: ");
                veriGiris = Console.ReadLine();
            }




            
        }
    }
}
