using System;

namespace Zaytsevaa.Lab7.Exercise1
{
     // Дана строка символов, состоящая из произвольного текста на английском языке,
     // слова разделены пробелами. В каждом слове заменить первую букву на прописную.

      class Program
        {
            static void Main(string[] args)
            {
                string str = Console.ReadLine();
                str = str.ToLower();

                char[] arr = str.ToCharArray();
                arr[0] = char.ToUpper(arr[0]);
                for (int i = 1; i < str.Length; i++)
                {
                    if (arr[i - 1] == ' ') arr[i] = char.ToUpper(arr[i]);
                }
                str = new string(arr);
                Console.WriteLine(str);
            }
        }
    }
  
