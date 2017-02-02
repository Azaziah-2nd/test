using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3_Tekninen_Prototyyppi
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer Customer_class = new Customer();
            Customer_class.Customer_ask_details(Customer_class);
            Customer_class.Customer_print_details(Customer_class);
            Console.ReadLine();

        }
    }
}
