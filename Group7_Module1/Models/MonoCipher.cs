using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_Module1.Models
{
    public class MonoCipher
    {
        public static string GenerateRandomKey()
        {
            char[] alphabet = new char[26];

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)('a' + i);
            }

            Random rng = new Random();
            int n = alphabet.Length;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);

                var temp = alphabet[k];
                alphabet[k] = alphabet[n];
                alphabet[n] = temp;
                
            }

            return new string(alphabet);
        }

        public static string Encrypt(string plainText, string key)
        {
            char[] chars = new char[plainText.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                if (plainText[i] == ' ')
                {
                    chars[i] = ' ';
                }
                else
                {
                    int j = plainText[i] - 97;
                    chars[i] = key[j];
                }
            }

            return new string(chars);
        }

        public static string Decrypt(string cipherText, string key)
        {
            char[] chars = new char[cipherText.Length];

            for (int i = 0; i < cipherText.Length; i++)
            {
                if (cipherText[i] == ' ')
                {
                    chars[i] = ' ';
                }
                else
                {
                    int j = key.IndexOf(cipherText[i]) + 97;
                    chars[i] = (char)j;
                }
            }

            return new string(chars);
        }
    }
}
