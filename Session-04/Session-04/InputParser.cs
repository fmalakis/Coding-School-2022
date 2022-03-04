using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class InputParser
    {

        private const ushort SUM_CHOICE = 1;
        private const ushort PROD_CHOICE = 2;

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
            string input = Console.ReadLine();

            while (input == null || input == string.Empty)
            {
                Console.Write("Please enter a valid number: ");
                input = Console.ReadLine();
            }

            return Convert.ToInt32(input);
        }

        public ushort ParseUserChoice()
        {
            string choice = Console.ReadLine();

            while (choice == null || choice == string.Empty || (Convert.ToInt32(choice) != SUM_CHOICE && Convert.ToInt32(choice) != PROD_CHOICE))
            {
                Console.Write("Please enter a valid choice: ");
                choice = Console.ReadLine();
            }

            return Convert.ToUInt16(choice);
        }
    }
}
