using System;

namespace Zaytsevaa.Lab7.Exercise1.Var2
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            FirstName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(FirstName.ToLower());
            Console.WriteLine(FirstName);
        }
    }
}
