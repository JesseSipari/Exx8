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
            int[] numbers = {0, 1, 0, 1, 0};
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
            int[] userInput = new int[3];
            int counter = 0;

            for (counter = 0; counter < userInput.Length; counter++)
            {
                string input = Console.ReadLine();

                if (input == "")
                    break;
                else
                    int.TryParse(input, out userInput[counter]);
            }

            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(userInput[i]);
            }

            Console.ReadLine();

            //int counter = Convert.ToInt32(Console.ReadLine());
            //int[] numbers3 = new int[counter];
            //int count = 0;


            //while (count < numbers3.Length)
            //{
            //    if (int.TryParse(Console.ReadLine(), out numbers3[count]))
            //        count++;

            //}



            //    foreach (int i in numbers3)
            //    {
            //        int num;

            //        num = Convert.ToInt32(Console.ReadLine());
            //    }

            //    for (int i = 0; i < numbers3.Length; i++)
            //    {
            //        Console.WriteLine(numbers3);
            //    }

            //    Console.ReadLine();
            //}


        }
    }
}



















