using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] text_ = text.Split(' ');
            string first1 = new string (" абвгдеёжзийклмнопрстуфхцчшщъыьэюяабвгдеАБВГДЕЁЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯАБВГДЕ");
            
            string text1 = string.Empty;
            string text2 = string.Empty;
                       
           

            foreach (char ch in text)
            {
                if(ch == ' ') { text1 += ' '; }
                else { text1 += first1[first1.IndexOf(ch) + 5];}
            }

            Console.WriteLine(text1);
             

            foreach (char ch in text1)
            {
                if (ch == ' ') { text2 +=' '; }
                else { text2 += first1[first1.LastIndexOf(ch) - 5]; }
            }

            Console.WriteLine(text2);
           

        }
    }
}
