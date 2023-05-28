using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_19._05._2023
{
    class CaesarCipher
    {
        static string alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
       

        public static string Encryption(string text)
        {
            var res = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (text[i] == alph[j])
                        res.Append(alph[(j + 3) % alph.Length]);

            return res.ToString();
        }
        public static string Decryption(string crypt)
        {
            var res = new StringBuilder();
            for (int i = 0; i < crypt.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (crypt[i] == alph[j])
                        res.Append(alph[(j - 3 + alph.Length) % alph.Length]);

            return res.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "SAMURai";
            string crypt = CaesarCipher.Encryption(text);
            Console.WriteLine($"Зашифрованное сообщение: {crypt}\n");
            string decrypt = CaesarCipher.Decryption(crypt);
            Console.WriteLine($"Расшифрованное сообщение: {decrypt}\n");
        }
    }
}