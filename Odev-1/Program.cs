using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // STARTSWITH() && ENDSWITH()

            //List<string> citiesList = new List<string>() { "ankara", "izmir", "hatay",
            //"konya", "burdur", "tokat", "bursa", "tekirdag", "istanbul", "agri", "adiyaman" };

            // "a" ile baslayan sehirleri bulma
            //startsWith("a", citiesList);

            // "a" ile biten sehirleri bulma
            //endsWith("a", citiesList);

            //------------------------------------------------------

            // SPLIT()

            //string words = "mustafa,alaaddin,samsung,macbook,vize,sadaka";

            // "," 'e gore parcalama
            //splitTo(",", words);

            //--------------------------------------------------------


            //ADAM ASMACA

            adamAsmaca();
        }



        static void adamAsmaca()
        {
            /*
             * 1. bir kelime koleksiyonundan rastgele bir kelime seçilir
             * 2. bu rastgele kelime "* * * * " biçiminde yıldızlara çevrilir.
             * 3. Kullanıcı, harf girer
             * 4. girilen harf kelime içinde aranır
             * 5. varsa o sıradaki yıldız harfe çevrilir.
             * 6. bütün yıldızlar açılana dek bu adımlar devam eder
             */

            int hak = 5;
            List<string> words = new List<string>() {"motivasyon","kalemlik","tarantula","karpuz","galatasaray",
                "telefon","saat","kumsal","otel","tamirhane","minare","antika","kelepir"};
            string chosenWord = chooseWord(words);
            // ipucu
            Console.WriteLine(chosenWord);
            string hiddenWord = hideWord(chosenWord);
            showWord(hiddenWord);
            while (hak != 0)
            {
                refreshHealth(hak);
                if (hiddenWord == "Kelime Bulundu!")
                {
                    Console.Clear();
                    chosenWord = chooseWord(words);
                    // ipucu
                    Console.WriteLine(chosenWord);
                    hiddenWord = hideWord(chosenWord);
                    showWord(hiddenWord);
                }
                Console.WriteLine("Harf Giriniz : ");
                string characterInput = Console.ReadLine();
                List<int> list = characterControl(characterInput, chosenWord, hiddenWord);
                if (list.Count < 1)
                {
                    hak--;
                }
                else
                {
                    hiddenWord = openCharacter(list, chosenWord, hiddenWord);
                    refreshWord(hiddenWord);
                }
            }
            gameover();
        }

        static string chooseWord(List<string> words)
        {
            int luckyNumber = new Random().Next(0, words.Count);
            return words[luckyNumber];
        }

        private static string hideWord(string chosenWord)
        {
            string hiddenWord = string.Empty;
            for (int i = 0; i < chosenWord.Length; i++)
            {
                hiddenWord += "*";
            }
            return hiddenWord;
        }

        private static void showWord(string hiddenWord)
        {
            Console.WriteLine(hiddenWord);
        }

        private static List<int> characterControl(string character, string word, string hiddenWord)
        {
            int baslangicNoktasi = 0;
            List<int> characters = new List<int>();
            while (word.IndexOf(character, baslangicNoktasi) != -1)
            {
                int bulunanIndex = word.IndexOf(character, baslangicNoktasi);
                characters.Add(bulunanIndex);
                bulunanIndex++;
                baslangicNoktasi = bulunanIndex;
            }
            if (characters.Count < 1)
            {
                Console.Clear();
                Console.WriteLine("Harf Bulunamadi!");
                showWord(hiddenWord);
            }
            return characters;
        }

        private static string openCharacter(List<int> list, string chosenWord, string hiddenWord)
        {
            string word = string.Empty;
            for (int i = 0; i < hiddenWord.Length; i++)
            {
                if (list.Contains(i))
                {
                    word += chosenWord[i];
                }
                else
                {
                    word += hiddenWord[i];
                }
            }
            if (hiddenWord.Contains("*") == false)
            {
                word = "Kelime Bulundu!";
            }
            return word;
        }

        private static void gameover()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Hakkiniz Kalmadi!");
        }

        private static void refreshWord(object hiddenword)
        {
            Console.Clear();
            Console.WriteLine(hiddenword);
        }

        private static void refreshHealth(int hak)
        {
            Console.WriteLine("Kalan Hak : " + hak);
        }

        private static void startsWith(string v, List<string> list)
        {
            List<string> cities = new List<string>();
            Console.WriteLine("--------------------");
            Console.WriteLine("A ile baslayan sehirler :");
            foreach (var item in list)
            {
                if (item.ToLower().StartsWith(v))
                {
                    cities.Add(item);
                    Console.WriteLine(item);
                }
            }

        }

        private static void endsWith(string v, List<string> list)
        {
            List<string> cities = new List<string>();
            Console.WriteLine("--------------------");
            Console.WriteLine("A ile biten sehirler :");
            foreach (var item in list)
            {
                if (item.ToLower().EndsWith(v))
                {
                    cities.Add(item);
                    Console.WriteLine(item);
                }
            }
        }

        private static void splitTo(string v, string word)
        {
            string[] words = word.Split(char.Parse(v));
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

        }
    }
}
