using System;

namespace A2_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elemnets do you want in the array?");
            int Number = Convert.ToInt32(Console.ReadLine());
            int[] numarray = new int[Number];

            Console.WriteLine("\nEnter the elements of the array");

            for (int i = 0; i < Number; i++)
            {
                Console.Write("element " + i + " : ");
                numarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe elements in the array are");
            for (int j = 0; j < numarray.Length; j++)
            {
                Console.Write("  " + numarray[j]);
            }
        
            for (int i = 0; i < numarray.Length; i++)
            {
            
                if (numarray[i] == 0 || numarray[i] == 1)
                {
                    Console.WriteLine("\n" +numarray[i] + " is not prime number");
                    
                }
                else
                {
                    for (int a = 2; a <= numarray[i] / 2; a++)
                    {
                        if (numarray[i] % a == 0)
                        {
                            Console.WriteLine("\n" + numarray[i] + " is not prime number");
                            continue;
                        }

                    }
               
                    Console.WriteLine("\n" + numarray[i] + " is a prime number");
                    
                }

            }


        }
    }
}
