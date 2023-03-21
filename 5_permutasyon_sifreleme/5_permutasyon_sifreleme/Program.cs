using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_permutasyon_sifreleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sifreleme sifreleme = new Sifreleme();
            Console.WriteLine("Klasik Sifreleme / Yerine Koyma Algoritmasi");
            //Console.WriteLine("Sifrelenmis: " + sifreleme.yerineKoyma("ankaragücü")); // oijotodhrh
            //Console.WriteLine("Sifresi Cozulmus: " + sifreleme.yerineKoymaCozme("oijotodhrh")); // ankaragücü
            Console.ReadKey();
        }
    }
}

            
class Sifreleme
{
    public List<string> turkceAlfabe = new List<string> {
        "a",
        "b",
        "c",
        "ç",
        "d",
        "e",
        "f",
        "g",
        "ğ",
        "h",
        "ı",
        "i",
        "j",
        "k",
        "l",
        "m",
        "n",
        "o",
        "ö",
        "p",
        "r",
        "s",
        "ş",
        "t",
        "u",
        "ü",
        "v",
        "y",
        "z"
      };

    public string yerineKoyma(string veri, int anahtar)
    {
        string sifrelenmisVeri = "";
        List<int> ints= new List<int>();
        if (anahtar > 0 && anahtar <= veri.Length)
        {
            for (int i = 1; i <= anahtar; i++)
            {
                ints.Add(i);
            }


            char[] veriList = veri.ToCharArray();
            for (int i = 0; i < veriList.Length; i++)
            {
                if (turkceAlfabe.Contains(veriList[i].ToString()))
                {
                    int index = turkceAlfabe.IndexOf(veriList[i].ToString());
                    string indexA = randomAlfabe[index].ToString();
                    sifrelenmisVeri += indexA;

                }
                else
                {
                    sifrelenmisVeri += "*";
                }

            }
        }
        else
        {
            sifrelenmisVeri = 'Anahtar Degeri Hatalı!';
        }
        
        return sifrelenmisVeri;
    }

    public string yerineKoymaCozme(string veri)
    {
        string cozulmusVeri = "";
        char[] veriList = veri.ToCharArray();
        for (int i = 0; i < veriList.Length; i++)
        {
            if (randomAlfabe.Contains(veriList[i].ToString()))
            {
                int index = randomAlfabe.IndexOf(veriList[i].ToString());
                string indexA = turkceAlfabe[index].ToString();
                cozulmusVeri += indexA;
            }
            else
            {
                cozulmusVeri += "?";
            }
        }
        return cozulmusVeri;
    }

}
