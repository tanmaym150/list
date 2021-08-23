using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)


        {

            List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };
            Console.WriteLine("Numbers before sorting:");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Sort();

            Console.WriteLine("Numbers after sorting:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Reverse();
            Console.WriteLine("Numbers after reversing:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            List<string> alphabets = new List<string>() { "c","d","tanmay","nik","damu"};
            Console.WriteLine("printing letters:");
            foreach (var a in alphabets)
            {
                Console.WriteLine(a);
            }
            alphabets.Sort();
            Console.WriteLine("alphabets after sortng:");
            foreach (var a in alphabets)
            {
                Console.WriteLine(a);
            }
            Customer c1 = new Customer()
            {
                ID = 101,
                Name = "tanmay",
                Salary = 8000,
                //type="retail customer"


            };
            Customer c2 = new Customer()
            {
                ID = 102,
                Name = "yash",
                Salary = 6000,
               // Type="RetailCustomer"

            };
            Customer c3 = new Customer()
            {
                ID = 103,
                Name = "aniket",
                Salary = 5000,
              //  Type="RetailCustomer"

            };
            Customer c4 = new Customer()
            {
                ID = 104,
                Name = "VEDANT",
                Salary = 4000,
               // Type="Corporate Customer"


            };
            Customer c5 = new Customer()
            {
                ID = 105,
                Name = "AMIR",
                Salary = 6000,
              //  Type="Corporate Customer"


            };

            //Arrays dont grow in size so we can use list
            List<Customer> cstmrs = new List<Customer>(2);
            cstmrs.Add(c1);
            cstmrs.Add(c2);
            cstmrs.Add(c3);

            List<Customer> lcc = new List<Customer>();
            lcc.Add(c4);
            lcc.Add(c5);

            cstmrs.AddRange(lcc);
           
            
           

            foreach(Customer ccc in cstmrs)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2}",ccc.ID,ccc.Name,ccc.Salary);
            }
            
            

            foreach(Customer i in cstmrs)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2}",i.ID,i.Name,i.Salary);
            }
            Console.WriteLine(cstmrs.IndexOf(c3,1));//0

            if (cstmrs.Exists(cs =>cs.Name.StartsWith("z")))
            {
                Console.WriteLine("customer2 object exists in the list");
            }
            else
            {
                Console.WriteLine("The object doesnt exist");
            }

           List<Customer> customers = cstmrs.FindAll(ss => ss.Salary > 5000);
            foreach (Customer o in customers)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2}", o.ID, o.Name, o.Salary);
            }

           int index= cstmrs.FindIndex(cc => cc.Salary == 8000);
            Console.WriteLine("Index={0}",index);

            Customer[] cArray = new Customer[3];
            cArray[0] = c1;
            cArray[1] = c2;
            cArray[2] = c3;
            


          






        }
        public class Customer
        {
         public int ID { get; set; }
         public string Name { get; set; }

         public int Salary { get; set; }

        }
    }
}
