using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainClass
{
    static void Main(string[] args)
    {
        Sifreleme sifreleme = new Sifreleme();
        Console.WriteLine("Klasik Sifreleme / Lineer Sifreleme Algoritmasi");
        Console.WriteLine("Sifrelenmis: " + sifreleme.lineerSifreleme("ankaragücü", 5, 7)); //galgrgknon
        Console.WriteLine("Sifresi Cozulmus: " + sifreleme.lineerSifreCozme("galgrgknon", 5, 7)); //ankaragücü
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

    public string lineerSifreleme(string veri, int a, int b) 
        {
            string sifrelenmisVeri = "";
            char[] veriList = veri.ToCharArray();
            for (int i = 0; i < veriList.Length; i++)
            {
                if (turkceAlfabe.Contains(veriList[i].ToString()))
                {
                    int index = turkceAlfabe.IndexOf(veriList[i].ToString());
                    int indexA = index * a;
                    int indexB = indexA + b;
                    if (indexB >= 0 && indexB <= turkceAlfabe.Count)
                    {
                        sifrelenmisVeri += turkceAlfabe[indexB].ToString();
                    }
                    else
                    {
                        int sonIndex = indexB % 29;
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

    public string lineerSifreCozme(string veri, int a, int b)
        {
            if ((a * 1) % 29 == 1)
            {
                 a = a;
            }
            else
            {
                int sayac = 1;
                while (true)
                {
                    if ((a * sayac) % 29 == 1)
                    {
                        a = sayac;
                        break;
                    }
                    sayac++;
                }
            }
            string cozulmusVeri = "";
            char[] veriList = veri.ToCharArray();
            for (int i = 0; i < veriList.Length; i++)
            {
                if (turkceAlfabe.Contains(veriList[i].ToString()))
                {
                    int index = turkceAlfabe.IndexOf(veriList[i].ToString());
                    int indexA = index - b;
                    if (indexA < 0)
                    {
                        indexA += 29;
                    }
                    int sonIndex = (indexA * a) % 29;
                    cozulmusVeri = cozulmusVeri + turkceAlfabe[sonIndex].ToString();
                }
                else
                {
                     cozulmusVeri += "?";
                }
        }
            return cozulmusVeri;
        }

}

