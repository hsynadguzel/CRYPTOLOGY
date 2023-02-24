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
        Console.WriteLine("Sifrelenecek Veri: ankaragücü");
        Console.WriteLine("Sifrelenmis: " + sifreleme.kaydirmaliSifreleme("ankaragücü",18)); //öecöhöülrl - anahtar:18
        Console.WriteLine("Sifresi Cozulmus: " + sifreleme.kaydirmaliSifreCozme("öecöhöülrl", 18)); //ankaragücü - anahtar:18
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

    public string kaydirmaliSifreleme(string veri, int kSayi)
    {
        string sifrelenmisVeri = "";
        char[] veriList = veri.ToCharArray();
        for (int i = 0; i < veriList.Length; i++)
        {
            if (turkceAlfabe.Contains(veriList[i].ToString()))
            {
                int index = turkceAlfabe.IndexOf(veriList[i].ToString());
                if (index + kSayi >= 0 && index + kSayi <= turkceAlfabe.Count)
                {
                    int sonIndex = index + kSayi;
                    sifrelenmisVeri = sifrelenmisVeri + turkceAlfabe[sonIndex].ToString();
                }
                else
                {
                    int sonIndex = (index + kSayi) % 29;
                    sifrelenmisVeri = sifrelenmisVeri + turkceAlfabe[sonIndex].ToString();
                }
            }
        }
        return sifrelenmisVeri;
    }

    public string kaydirmaliSifreCozme(string veri, int kSayi)
    {
        string cozulmusVeri = "";
        char[] veriList = veri.ToCharArray();
        for (int i = 0; i < veriList.Length; i++)
        {
            if (turkceAlfabe.Contains(veriList[i].ToString()))
            {
                int index = turkceAlfabe.IndexOf(veriList[i].ToString());
                if (index - kSayi >= 0 && index - kSayi <= turkceAlfabe.Count)
                {
                    int sonIndex = index - kSayi;
                    cozulmusVeri = cozulmusVeri + turkceAlfabe[sonIndex].ToString();
                }
                else
                {
                    int sonIndex = (index - kSayi) + 29;
                    cozulmusVeri = cozulmusVeri + turkceAlfabe[sonIndex].ToString();
                }
            }
        }
        return cozulmusVeri;
    }
}