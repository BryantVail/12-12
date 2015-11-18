using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




    class TestSolution1
    {
        public static void Main( string [] args)
        {
            bool loop = true;
            while(loop == true)
            {
                Console.WriteLine("Welcome to Employee Builder: ");
                Console.Read();

                //instantiate Employee Array
                Employee[] Employees = new Employee[5];

                //fill array with different 'Employee' Derived Types all functioning under their own version of the 'Employee' Methods.
                Employees[0] = new BasePlusCommissionEmployee("Jerry", "Redmond", "000-00-0000", 500.00M, .8M, 700M);
                Employees[1] = new CommissionEmployee("Carlos", "Reese", "111-11-1111", 999.00M, .45M);
                Employees[2] = new HourlyEmployee("Mike", "Luongo", "222-22-2222", 15.00M, 45M);
                Employees[3] = new PieceWorker("Marcus", "Shepherd", "333-33-3333", 3.50M, 100M);
                Employees[4] = new SalariedEmployee("Larry", "Peters", "444-44-4444", 75000M);
                //Employees[5] = new PieceWorker("Hakeem", "Rogers", "555-55-5555", 5.0M,1);



                Console.WriteLine("Employees Earnings & System Signature through ToString: \n\n{0}\t\t{1}", "Earnings:", "String:");
               
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("\n" + Employees[i].ToString() + "\t\t" + Employees[i].Earnings());
                }

                Console.ReadLine();

            }//End while
            
            
        }//end main
    }

