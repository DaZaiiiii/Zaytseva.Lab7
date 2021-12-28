using System;

namespace Zaytsevaa.Lab7.Exercise2
{
    //Сформировать новую строку, где поменять местами первое и последнее слово из исходной строки

    class Program
    {
        static void Main(string[] args)
        {
            string str = "Рассуждение, не связанное с общей целью всех рассуждений, безумно, как бы оно ни было логично";
            Console.WriteLine(str);
            string s1 = str.Substring(0, str.IndexOf(' '));
            string s2 = str.Substring(str.LastIndexOf(' ') + 1, str.Length - str.LastIndexOf(' ') - 1);
            str = str.Remove(0, str.IndexOf(' '));
            str = str.Remove(str.LastIndexOf(' ') + 1, str.Length - str.LastIndexOf(' ') - 1);
            str = s2.ToUpper() + str + s1.ToLower();
            Console.WriteLine(str);
        }
    }
}
