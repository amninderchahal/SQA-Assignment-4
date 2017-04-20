using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        private static int value;
        public static void Main(string[] args)
        {
            bool chk;
            string userSelection;
            do
            {
                userSelection = menu();
                chk = verifyUserSelection(userSelection);
            } while (!chk);

            if (value == 1)
            {
                Console.Clear();
                Console.WriteLine("Enter the three dimensions of triangle\nSide A:");
                int side_A = checkTriangleSide(Console.ReadLine());
                Console.WriteLine("Side B:");
                int side_B = checkTriangleSide(Console.ReadLine());
                Console.WriteLine("Side C:");
                int side_C = checkTriangleSide(Console.ReadLine());
                
                string output = "\n" + TriangleSolver.analyze(side_A, side_B, side_C);
                Console.WriteLine(output);
                step_2:
                Console.WriteLine("\nEnter 1 to restart or 2 to quit.");
                int restart = Convert.ToInt32(Console.ReadLine());
                if (restart == 1)
                    Main(null);
                else if (restart == 2)
                    Environment.Exit(0);
                else
                    goto step_2;
            }
            else
                Environment.Exit(0);
        }

        public static string menu()
        {
            Console.Clear();
            Console.WriteLine("1.Enter triangle dimensions\n2.Exit");
            return Console.ReadLine();
        }
        public static bool verifyUserSelection(string userSelection)
        {
            bool check = int.TryParse(userSelection, out value);
            if (check)
            {
                if (value == 1 || value == 2)
                {
                    Console.WriteLine(userSelection);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        protected static int checkTriangleSide(String input)
        {
            int outVal;
            String val = input;
            bool ifInt = int.TryParse(val, out outVal);

            while(!ifInt){
                Console.WriteLine("Please enter a valid value");
                val = Console.ReadLine();
                ifInt = int.TryParse(val, out outVal);
            }
            return outVal;
        }
    }
}
