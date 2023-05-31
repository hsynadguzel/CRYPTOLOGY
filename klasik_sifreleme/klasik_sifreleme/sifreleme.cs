using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasik_sifreleme
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


        public string lineerSifreleme(string veri, int a, int b)// f= ax+b
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


        public List<string> randomAlfabe = new List<string> { "o", "ü", "r", "b", "ş", "ç", "m", "d", "k", "e", "f", "g", "ğ", "j", "ı", "n", "i", "p", "a", "ö", "t", "s", "v", "u", "c", "h", "y", "z" };

        public string yerineKoyma(string veri)
        {
            string sifrelenmisVeri = "";
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

        public string polybiusSifreleme(string veri)
        {
            string sifreliVeri = "";
            List<List<string>> alpMatris = new List<List<string>>()
            {
                new List<string>() {"a", "b", "c", "d", "e"},
                new List<string>() {"f", "g", "h", "ı", "i"},
                new List<string>() {"j", "k", "l", "m", "n"},
                new List<string>() {"o", "p", "r", "s", "ş"},
                new List<string>() {"t", "u", "v", "y", "z"}
            };

            foreach (char element in veri)
            {
                for (int i = 0; i < alpMatris.Count; i++)
                {
                    if (alpMatris[i].Contains(element.ToString()))
                    {
                        sifreliVeri += $"{i + 1}{alpMatris[i].IndexOf(element.ToString()) + 1} ";
                    }
                }
            }

            return sifreliVeri.Trim();
        }

        public string polybiusCozme(string veri)
        {
            string cozulmusVeri = "";
            List<List<string>> alpMatris = new List<List<string>>()
            {
                new List<string>() {"a", "b", "c", "d", "e"},
                new List<string>() {"f", "g", "h", "ı", "i"},
                new List<string>() {"j", "k", "l", "m", "n"},
                new List<string>() {"o", "p", "r", "s", "ş"},
                new List<string>() {"t", "u", "v", "y", "z"}
            };

            string[] sifreliVeriList = veri.Split(' ');

            foreach (string element in sifreliVeriList)// 45
            {
                int row = int.Parse(element[0].ToString()) - 1;
                int column = int.Parse(element[1].ToString()) - 1;
                cozulmusVeri += alpMatris[row][column];
            }

            return cozulmusVeri;
        }
    }
}
