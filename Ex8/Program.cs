using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 0, 1, 0 };
            foreach (int i in numbers)
            {
                Console.WriteLine(numbers[i]);
            }

            // Tehtävä 2
            int[] numbers2 = new int[5];


            foreach (int i in numbers2)
            {
                numbers2[i]++;
                Console.WriteLine(numbers2[i]);
            }

            for (int i = 1; i <= numbers2.Length; i++)
            {
                Console.WriteLine(i * 2);
            }

            // Tehtävä 3


            int counter = Convert.ToInt32(Console.ReadLine());
            int[] lukujono = new int[counter];

            for (int i = 0; i < lukujono.Length; i++)
            {
                int num;
                num = Convert.ToInt32(Console.ReadLine());
                lukujono[i] = num;
                num++;

            }

            Console.WriteLine(string.Join("\n", lukujono));


            // Tehtävä 4
            string[] names = new string[10];

            for (int i = 0; i < names.Length; i++)
            {
                string name;
                name = Console.ReadLine();
                names[i] = name;


            }

            Console.WriteLine(string.Join(", ", names));

            // Tehtävä 5
            string[] names2 = new string[10];

            for (int i = 0; i < names2.Length; i++)
            {
                string name;
                name = Console.ReadLine();
                names2[i] = name;

            }
            Array.Reverse(names2);
            Console.WriteLine(string.Join(", ", names2));


            // Tehtävä 6
            string[] names3 = new string[10];
            Console.WriteLine("Insert 10 names");

            for (int i = 0; i < names3.Length; i++)
            {
                string name;
                name = Console.ReadLine();
                names3[i] = name;

            }
            Console.WriteLine("Insert the number of the name");
            int userNum = Convert.ToInt32(Console.ReadLine());

            if (userNum >= 0 && userNum <= names3.Length)
            {
                Console.WriteLine(names3[userNum - 1]);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

        }

    }
}



















