using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainClass
{
    public static void Main(string[] args)
    {
        Sifreleme sifreleme = new Sifreleme();
        Console.WriteLine("Klasik Sifreleme / Sezar Algoritması");
        Console.WriteLine("Sifrelenmis: " + sifreleme.sezarSifreleme("ankaragücü")); //çpnçtçızez
        Console.WriteLine("Sifresi Cozulmus: " + sifreleme.sezarSifreCozme("çpnçtçızez")); //ankaragücü
        Console.ReadKey();
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

    public string sezarSifreleme(string veri)
    {
        string sifrelenmisVeri = "";
        char[] veriList = veri.ToCharArray();
        for (int i = 0; i < veriList.Length; i++)
        {
            if (turkceAlfabe.Contains(veriList[i].ToString()))
            {
                int index = turkceAlfabe.IndexOf(veriList[i].ToString());
                if (index + 3 >= 0 && index + 3 <= turkceAlfabe.Count)
                {
                    int sonIndex = index + 3;
                    sifrelenmisVeri += turkceAlfabe[sonIndex].ToString();
                }
                else
                {
                    int sonIndex = (index + 3) % 29;
                    sifrelenmisVeri += turkceAlfabe[sonIndex].ToString();
                }
            }
            else
            {
                sifrelenmisVeri += "*";
            }
        }
        return sifrelenmisVeri;
    }

    public string sezarSifreCozme(string veri)
    {
        string cozulmusVeri = "";
        char[] veriList = veri.ToCharArray();
        for (int i = 0; i < veriList.Length; i++)
        {
            if (turkceAlfabe.Contains(veriList[i].ToString()))
            {
                int index = turkceAlfabe.IndexOf(veriList[i].ToString());
                if (index - 3 >= 0 && index - 3 <= turkceAlfabe.Count)
                {
                    int sonIndex = index - 3;
                    cozulmusVeri += turkceAlfabe[sonIndex].ToString();
                }
                else
                {
                    int sonIndex = (index - 3) + 29;
                    cozulmusVeri += turkceAlfabe[sonIndex].ToString();
                }
            }
            else
            {
                cozulmusVeri += "?";
            }
        }
        return cozulmusVeri;
    }
}