using System;
using System.Linq;
using System.Collections.Generic;
namespace Testirovka
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> a=new List<object> {"Andrew", 1};
            string str = "Abacalama";
            
            int number = 123456789;
            
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int target = 5;
            
            string names = "Andrew:Darialov;Vitalii:Gurianov;Maksym:Brazhniy;Anton:Brazhniy";

            Tasks test = new Tasks();
            test.Task1<int>(a).ForEach(x => Console.WriteLine(x.ToString()));
            Console.WriteLine(test.Task2(str));
            Console.WriteLine(test.Task3(number));
            Console.WriteLine(test.Task4(numbers, target));
            Console.WriteLine(test.Task5(names));

        }
       
    }

}
