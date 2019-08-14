using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptionexercise.Entities.Exceptions;
using Exceptionexercise.Entities;
using System.Globalization;

namespace Exceptionexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Inicial Balance: ");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: ");
                double limit = double.Parse(Console.ReadLine());

                Account ac = new Account(number, name, value, limit);

                Console.WriteLine("");
                Console.Write("Enter amount for withdraw: ");
                double value2 = double.Parse(Console.ReadLine());
                ac.withDraw(value2);
                Console.WriteLine("New balance: " + ac.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainExceptions e)
            {
                Console.WriteLine("Withdraw erro: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
          }
    }
}
