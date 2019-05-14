//Name: Blake Jensen
//Student ID: 30006830
//Program Purpose: Class, designated to calculate net salary.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Please enter the first name of the employee: ");
            string fname = Console.ReadLine();
            Console.Write("Please enter the last name of the employee: ");
            string lname = Console.ReadLine();
            Console.Write($"Now enter {fname}'s tax rate (in percentage): ");
            double taxrate = double.Parse(Console.ReadLine());
            Console.Write($"Now enter {fname}'s Gross annual income: ");
            double gross_salary = double.Parse(Console.ReadLine());

            Employee p1 = new Employee(fname, lname, taxrate, gross_salary);

            Console.WriteLine($"Net Salary: ${Math.Round(p1.Net(), 2)}");
            Console.ReadLine();
        }
    }

    //the class
    class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public double Gross_Salary { get; set; }
        public double Taxrate { get; set; } = 0.15;

        public Employee(string _fname, string _lname, double _taxrate, double _gross_salary)
        {
            Fname = _fname;
            Lname = _lname;         //all these variables have to be reassigned because of the need for more variables.
            Taxrate = _taxrate;
            Gross_Salary = _gross_salary;
        }

        public Employee() //empty constructor for overlading
        {
       
        }

        public double Net()
        {
            return Gross_Salary * (1 - Taxrate / 100);
        }
    }
}
