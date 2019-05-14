using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDistributionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //FoodDistribution(new int[] { 5, 2, 3, 4, 5 });


            FoodDistribution(new int[] { 5, 3, 1, 2, 1});


        }

        public static int FoodDistribution(int[] arr)
        {

            // code goes here  
            /* Note: In C# the return type of a function and the 
               parameter types being passed are defined, so this return 
               call must match the return type of the function.
               You are free to modify the return type. */

            var sandwiches = arr[0];
            var peopleArray = new int[arr.Length - 1];
            for(int k = 0; k <= peopleArray.Length -1; k++)
            {
                var l = k + 1;
                peopleArray[k] = arr[l];
            }

            Array.Sort(peopleArray);

            var secondPeopleArray = new int[peopleArray.Length -1];
            var pairOfPeople = new int[peopleArray.Length];

            Array.Copy(peopleArray, 1, secondPeopleArray, 0, peopleArray.Length -1);

            
            int i = 0;


            for (; i <= peopleArray.Length -1; i++)
            {

                for (int j = 0; j <= secondPeopleArray.Length -1; j++)
                {

                    //if (j == secondPeopleArray.Length -1)
                    //    break;

                    if (peopleArray[i] != 6 && secondPeopleArray[j] != 6)
                    {

                        if (peopleArray[i] == secondPeopleArray[j])
                        {
                            pairOfPeople[i] = peopleArray[i];
                            pairOfPeople[i + 1] = secondPeopleArray[j];
                            peopleArray[i] = 6;
                            secondPeopleArray[j] = 6;
                        }
                        else if (peopleArray[i] != secondPeopleArray[j] && sandwiches > 0)
                        {
                            var tempItem2Value = secondPeopleArray[j];

                            while (sandwiches != 0 && (peopleArray[i] != tempItem2Value))
                            {
                                tempItem2Value--;
                                sandwiches--;
                            }

                            pairOfPeople[i] = peopleArray[i];
                            pairOfPeople[i + 1] = tempItem2Value;
                            peopleArray[i] = 6;
                            secondPeopleArray[j] = 6;
                        }
                    }
                }

            }
                       
            foreach (var item in peopleArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in pairOfPeople)
            {
                Console.WriteLine(item);
            }

            return arr[0];

        }

    }
}
