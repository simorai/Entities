using Entities.Entities;
using Entities.Entities.Enums;
using System.Globalization;

namespace Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter department name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); //Finds in WorkerLevel the correct level for the worker that is beeing inserted
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName); //local variable that stores the department name
            Worker worker = new Worker(name, level, baseSalary, dept); //Instantiate the worker object with the data that the constructor expects

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) //Loop that stores the the worker info
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours); //instantiate the contract with the arguments date, valuePerHour, hours.
                worker.AddContract(contract); // add the contract to the worker
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2)); //Trims first to chars from (MM/YYYY)
            int year = int.Parse(monthAndYear.Substring(3)); //Trims the chars from the 3 position to the end of the string
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
