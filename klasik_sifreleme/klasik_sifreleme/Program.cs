using klasik_sifreleme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasik_sifreleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sifreleme sifreleme = new Sifreleme();
            Console.WriteLine("---------------------Klasik Sifreleme-----------------\n");
            Console.WriteLine("1-Sezar Algoritması");
            Console.WriteLine("Sifrelenmis: " + sifreleme.sezarSifreleme("ankaragücü")); //çpnçtçızez
            Console.WriteLine("Sifresi Cozulmus: " + sifreleme.sezarSifreCozme("çpnçtçızez")); //ankaragücü
            Console.WriteLine("-------------------------------------------------------\n");
            Console.WriteLine("2-Kaydirmali Sezar Algoritmasi");
            Console.WriteLine("Sifrelenmis: " + sifreleme.kaydirmaliSifreleme("ankaragücü", 18)); //öecöhöülrl - anahtar:18
            Console.WriteLine("Sifresi Cozulmus: " + sifreleme.kaydirmaliSifreCozme("öecöhöülrl", 18)); //ankaragücü - anahtar:18
            Console.WriteLine("-------------------------------------------------------\n");
            Console.WriteLine("3-Lineer Sifreleme Algoritmasi");
            Console.WriteLine("Sifrelenmis: " + sifreleme.lineerSifreleme("ankaragücü", 5, 7)); //galgrgknon
            Console.WriteLine("Sifresi Cozulmus: " + sifreleme.lineerSifreCozme("galgrgknon", 5, 7)); //ankaragücü
            Console.WriteLine("-------------------------------------------------------\n");
            Console.WriteLine("4-Yerine Koyma Algoritmasi");
            Console.WriteLine("Sifrelenmis: " + sifreleme.yerineKoyma("ankaragücü")); // oijotodhrh
            Console.WriteLine("Sifresi Cozulmus: " + sifreleme.yerineKoymaCozme("oijotodhrh")); // ankaragücü
            Console.WriteLine("-------------------------------------------------------\n");
            Console.WriteLine("5-Vigenere Algoritmasi");
            Console.WriteLine("Sifrelenmis: " + sifreleme.vigenere("kriptolojidersindeyiz", "sevmek")); // eüğezbfşhvhöjvğchöpnü
            Console.WriteLine("Sifresi Cozulmus: " + sifreleme.vigenereCozme("eüğezbfşhvhöjvğchöpnü", "sevmek")); // kriptolojidersindeyiz
            Console.WriteLine("-------------------------------------------------------\n");
            Console.WriteLine("6-Polybius Algoritmasi");
            Console.WriteLine("Sifrelenmis: " + sifreleme.polybiusSifreleme("sifreleme")); // 44 25 21 43 15 33 15 34 15
            Console.WriteLine("Sifresi Cozulmus: " + sifreleme.polybiusCozme("44 25 21 43 15 33 15 34 15")); // sifreleme
            Console.ReadKey();
        }
    }
}
