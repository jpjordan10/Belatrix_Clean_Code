using CleanCode.Comments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode.OutputParameters
{
    public class OutputParameters
    {
        int totalCount;
        public void DisplayCustomers()
        {
           var customers = GetCustomers(1);
            

            Console.WriteLine("Total customers: " + totalCount);
            foreach (var c in customers)
                Console.WriteLine(c);
        }

        public IEnumerable<Customer> GetCustomers(int pageIndex)
        {             
            totalCount = 100;
            return new List<Customer>();
        }
    }
}
