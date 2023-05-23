using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main()
        {


            //Display Multiplication Table
            Console.WriteLine("Display the multiplication table:");
            Console.WriteLine("-------------------------------------");


            //Error handling for user input
            try
            {
                
                //Allow the user to enter a whole number to specify which multiplication table should be generated
                Console.Write("\nInput the number(Table to be calculated) : ");
                int iWholeNumber = int.Parse(Console.ReadLine());


                bool isAnotherOne = true;
                while (isAnotherOne)
                {
                    for (int i = 1; i <= 12; i++)
                    {

                        int iProduct = iWholeNumber * i;
                        Console.WriteLine("{0} X {1} = {2} ", i, iWholeNumber, iProduct);
                    }

                    //Ask the user if they would like to generate another Multiplication table
                    Console.WriteLine("\nWould you like to generate another multiplication table? (Y/N) :");
                    char YesNo = char.Parse(Console.ReadLine().ToUpper());


                    //Check user response
                    if (YesNo == 'Y')
                    {
                        Console.Write("\nInput the number(Table to be calculated) : ");
                        iWholeNumber = int.Parse(Console.ReadLine());


                    }

                    else 
                    {

                        isAnotherOne = false;
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.Write("\nPress any key to exit....");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
            
            

            
            //Allow the user to read the output
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
