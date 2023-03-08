using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta1_klasik_sifreleme
{
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
                        sifrelenmisVeri += turkceAlfabe[sonIndex].ToString();
                    }
                    else
                    {
                        int sonIndex = (index + kSayi) % 29;
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
                        cozulmusVeri += turkceAlfabe[sonIndex].ToString();
                    }
                    else
                    {
                        int sonIndex = (index - kSayi) + 29;
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
}
