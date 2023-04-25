using System;
using System.Linq;

namespace Part1
{
    //DUE 28TH APRIL 2023!!!!!!!!!!
    internal class Program
    {
        static void Main(string[] args)
        {
            string entry = "";
            do
            {
                Console.WriteLine("Welcome to the MyRecipe Console App! ");
                Console.WriteLine("What do you want to make today?");

                string recipeCh = Console.ReadLine();
                Console.WriteLine("Great!!");
                Console.WriteLine("Enter the number of ingredients " + recipeCh + " recipe will require:");
                int numIngred = int.Parse(Console.ReadLine());
                int[] arr = new int[numIngred];
                Console.WriteLine("Now enter the details of the different ingredients below..");
                //code will loop until all ingredients and details thereof are included.

                Scale[] spArr = new Scale[numIngred];


                for (int i = 0; i < arr.Length; i++)
                {
                    //creating object 'sp' of Scale class
                    Scale sp = new Scale();

                    //string name;
                    Console.Write("Name : ");
                    sp.gs.Name = Console.ReadLine();

                    Console.WriteLine("Quantity:");
                    sp.gs.Quant = int.Parse(Console.ReadLine());

                    Console.Write("Unit of measurement: ");
                    sp.gs.Measurement = Console.ReadLine();

                    spArr[i] = sp;
                }
                Console.WriteLine("--------------------------------------------------");



                Console.WriteLine("How many steps are required?");

                int steps = int.Parse(Console.ReadLine());
                string[] arr2 = new string[steps];
                // code will loop for the number of steps required to make recipe chosen
                for (int i = 1; i <= arr2.Length; i++)
                {
                    Console.WriteLine("Step " + i + ":");
                    string step = Console.ReadLine();
                    // arr2[i] = step;
                }
                Console.WriteLine("--------------------------------------------------");

                arr2.ToList().ForEach(steps => Console.WriteLine($" ==>{steps}"));
                //full recipe is shown
                Console.WriteLine("Full Recipe is as follows: \n Recipe: " + recipeCh + "\n| "
                    + "Ingredients:" + (String.Join(", \n", spArr.Select(c => c.gs.Name)) +
                    "| Steps:" + arr2.ToList().ForEach(steps => Console.WriteLine($" ==>{steps}");
                /*(String.Join(", \n", arr2.Select(c => c.)) + " ."));*/


                Console.WriteLine("Pick the number which you would like your recipe to be scaled by:" +
                    "/n 1)0.5(half) /n 2)2 (double) /n 3)3 (triple)");
                int factor = int.Parse(Console.ReadLine());

                for (int m = 0; m < spArr.Length; m++)
                {

                    if (factor == 1)
                    {
                        Console.WriteLine("The recipe has now been scaled by half");

                        Console.WriteLine("Use " + spArr[m].byH() + "" + spArr[m].gs.Measurement);
                    }

                    if (factor == 2)
                    {
                        Console.WriteLine("The recipe has now been scaled by two");
                        Console.WriteLine("Use " + spArr[m].byTwo() + spArr[m].gs.Measurement);
                    }

                    if (factor == 3)
                    {
                        Console.WriteLine("The recipe has now been scaled by three");
                        Console.WriteLine("Use " + spArr[m].byThree() + spArr[m].gs.Measurement);
                    }
                }


                //  REMINDER :include exceptions bape1
                Console.WriteLine("Would you like to reset quantities to their original values? /n 1)yes /n 2)no");
                int reset = int.Parse(Console.ReadLine());
                if (reset == 1)
                {
                    Console.WriteLine("RESET THE VALUES..!!!");

                }

                if (reset == 2)
                {
                    Console.WriteLine("Awesome stuff!");
                }


                Console.WriteLine("Would you like to restart the program?");
                entry = Console.ReadLine();
            }
            //while loop that controls the restart of application.
            while (entry == "yes");
        }
      
    }
}
