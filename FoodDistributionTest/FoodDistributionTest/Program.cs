using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDistributionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodDistribution(new int[] { 5, 2, 3, 4, 5 });
        }

        public static int FoodDistribution(int[] arr)
        {

            // code goes here  
            /* Note: In C# the return type of a function and the 
               parameter types being passed are defined, so this return 
               call must match the return type of the function.
               You are free to modify the return type. */

            var sandwiches = arr[0];

            var peopleList = new List<int>();
            for (int i = 1; i <= arr.Length -1; i++)
            {

                peopleList.Add(arr[i]);
            }

            peopleList.Sort();


            var pairOfPeople = new List<int>();
            var secondPeopleList = new List<int>();
            secondPeopleList.AddRange(peopleList);
            secondPeopleList.RemoveAt(0);

            foreach (var item1 in peopleList)
            {
                foreach (var item2 in secondPeopleList)
                {
                    if(item1 == item2)
                    {
                        pairOfPeople.Add(item1);
                        pairOfPeople.Add(item2);
                    }
                    else if (item1 != item2 && sandwiches > 0)
                    {
                        var tempItem2Value = item2;

                        while(sandwiches != 0 && (item1 != tempItem2Value))
                        {
                            tempItem2Value--;
                            sandwiches--;
                        }

                        pairOfPeople.Add(item1);
                        pairOfPeople.Add(tempItem2Value);
                    }
                }
            }


            //*****
            foreach (var item in pairOfPeople)
            {
                Console.WriteLine(item);
            }

            return arr[0];

        }

    }
}
