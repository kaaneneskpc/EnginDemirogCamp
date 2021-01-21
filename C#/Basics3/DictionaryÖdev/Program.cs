using System;
using System.Collections.Generic;

namespace DictionaryÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> student = new Dictionary<int, string>();
            student.Add(134, "Kaan Enes KAPICI");
            student.Add(158, "Batuhan TIKTAS");
            student.Add(115, "Sena YUSRA");

            foreach (var key in student.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in student.Values)
            {
                Console.WriteLine(value);
            }




        }
    }
}
