using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class InputParser
    {
        public InputParser()
        {
          
        }

        public string ParseUserInputString()
        {
            string input = Console.ReadLine();
            
            while (input == null || input == string.Empty)
            {
                Console.Write("Please enter non-empty string: ");
                input = Console.ReadLine();
            }

            return input;
        }

        public int ParseUserInputInt()
        {
            int input = Convert.ToInt32(Console.ReadLine());

            while (input == null)
            {
                Console.Write("Please enter a number: ");
                input = Convert.ToInt32(Console.ReadLine());
            }

            return input;
        }

        public ushort ParseUserChoice()
        {
            string choice = Console.ReadLine();

            while (choice == null || choice == string.Empty || (Convert.ToInt32(choice) != 1 && Convert.ToInt32(choice) != 2))
            {
                Console.Write("Please enter a valid choice: ");
                choice = Console.ReadLine();
            }

            return Convert.ToUInt16(choice);
        }
    }
}
