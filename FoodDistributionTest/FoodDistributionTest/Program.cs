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
            var sandwiches = arr[0];
            var peopleArray = new int[arr.Length - 1];
            for(int k = 0; k <= peopleArray.Length -1; k++)
            {
                var l = k + 1;
                peopleArray[k] = arr[l];
            }

            //Array.Sort(peopleArray);

            var secondPeopleArray = new int[peopleArray.Length -1];
            var pairOfPeople = new int[peopleArray.Length];

            Array.Copy(peopleArray, 1, secondPeopleArray, 0, peopleArray.Length -1);
                                   

            for (int i = 0; i <= peopleArray.Length -1; i++)
            {

                for (int j = 0; j <= secondPeopleArray.Length -1; j++)
                {
                    if (peopleArray[i] != 6 && secondPeopleArray[j] != 6)
                    {

                        if (peopleArray[i] <= 1 || peopleArray[i] == 1)
                        {
                            pairOfPeople[i] = peopleArray[i];
                            peopleArray[i] = 6;
                            secondPeopleArray[j] = 6;
                        }
                        else if (peopleArray[i] != secondPeopleArray[j] && sandwiches > 0)
                        {
                            var tempItem1Value = peopleArray[j];

                            while (sandwiches != 0 && (tempItem1Value != secondPeopleArray[j] ))
                            {
                                tempItem1Value--;
                                sandwiches--;
                            }

                            pairOfPeople[i] = tempItem1Value;
                            peopleArray[i] = 6;
                            secondPeopleArray[j] = 6;
                        }
                    }
                    else if (peopleArray[peopleArray.Length -1] != 6 && secondPeopleArray[secondPeopleArray.Length -1] == 6)
                    {


                        if (peopleArray[i] <= 1 || peopleArray[i] == 1)
                        {
                            pairOfPeople[i] = peopleArray[i];
                            peopleArray[i] = 6;
                            secondPeopleArray[j] = 6;
                            break;
                        }

                        var tempItem1Value = peopleArray[j];

                        while (sandwiches != 0 && (tempItem1Value != pairOfPeople[i]))
                        {

                            tempItem1Value--;
                            sandwiches--;
                        }

                        pairOfPeople[i] = tempItem1Value;
                        peopleArray[i] = 6;
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
