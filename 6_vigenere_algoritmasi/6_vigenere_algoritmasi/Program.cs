using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_vigenere_algoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sifreleme sifreleme = new Sifreleme();
            Console.WriteLine("Klasik Sifreleme / Vigenere Algoritmasi");
            Console.WriteLine("Sifrelenmis: " + sifreleme.vigenere("kriptolojidersindeyiz", "sevmek")); // eüğezbfşhvhöjvğchöpnü
            Console.WriteLine("Sifresi Cozulmus: " + sifreleme.vigenereCozme("eüğezbfşhvhöjvğchöpnü", "sevmek")); // kriptolojidersindeyiz
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

    public string vigenere(string veri, string anahtar)
    {
        string sifrelenmisVeri = "";
        char[] veriList = veri.ToCharArray();
        int j = 0;
        for (int i = 0; i < veriList.Length; i++)
        {
            if (turkceAlfabe.Contains(veriList[i].ToString()))
            {
                int indexVeri = turkceAlfabe.IndexOf(veriList[i].ToString());
                int indexSifre = turkceAlfabe.IndexOf(anahtar[j].ToString());
                int sonIndex = (indexVeri + indexSifre) % 29;
                sifrelenmisVeri += turkceAlfabe[sonIndex].ToString();
            }
            else
            {
                sifrelenmisVeri += "*";
            }
            j = (j + 1) % anahtar.Length;
        }
        return sifrelenmisVeri;
    }

    public string vigenereCozme(string veri, string anahtar)
    {
        string cozulmusVeri = "";
        char[] veriList = veri.ToCharArray();
        int j = 0;
        for (int i = 0; i < veriList.Length; i++)
        {
            if (turkceAlfabe.Contains(veriList[i].ToString()))
            {
                int indexVeri = turkceAlfabe.IndexOf(veriList[i].ToString());
                int indexSifre = turkceAlfabe.IndexOf(anahtar[j].ToString());
                int sonIndex = indexVeri - indexSifre;
                sonIndex = sonIndex < 0 ? sonIndex + 29 : sonIndex % 29;
                cozulmusVeri += turkceAlfabe[sonIndex].ToString();
            }
            else
            {
                cozulmusVeri += "*";
            }
            j = (j + 1) % anahtar.Length;
        }
        return cozulmusVeri;
    }
}
