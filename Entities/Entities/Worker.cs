namespace Entities.Entities.Enums
{
    /// <summary>
    /// Represents a worker in the company.
    /// </summary>
    /// <remarks>
    /// This class encapsulates all relevant information about a worker,
    /// including personal details, employment level, salary, department,
    /// and associated contracts.
    /// </remarks>
    internal class Worker
    {
        public string Name { get; set; } //Worker properties
        public WorkerLevel Level { get; set; } //Worker properties
        public double BaseSalary { get; set; } //Worker properties
        public Department Department { get; set; } //Association between Worker and Department class
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //List of contracts association between Worker and Contracts class.

        /// <summary>
        /// Initializes a new instance of the Worker class.
        /// This is an empty constructor that allows for object creation without initial parameter values.
        /// Properties can be set individually after instantiation.
        /// </summary>
        public Worker()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Worker class with specified details.
        /// </summary>
        /// <param name="name">The name of the worker.</param>
        /// <param name="level">The experience level of the worker (Junior, MidLevel, or Senior).</param>
        /// <param name="baseSalary">The base salary of the worker.</param>
        /// <param name="department">The department where the worker is assigned.</param>
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        /// <summary>
        /// Adds a new contract to the worker's list of contracts.
        /// </summary>
        /// <param name="contract">The HourContract object to be added to the worker's contract list.</param>
        /// <remarks>
        /// This method updates the Contracts collection of the worker by adding a new HourContract.
        /// It's used to associate a new work contract with the worker.
        /// </remarks>
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        /// <summary>
        /// Removes a specific contract from the worker's list of contracts.
        /// </summary>
        /// <param name="contract">The HourContract object to be removed from the worker's contract list.</param>
        /// <remarks>
        /// This method updates the Contracts collection of the worker by removing the specified HourContract.
        /// If the contract is not found in the list, no action is taken.
        /// </remarks>
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        /// <summary>
        /// Calculates the total income of the worker for a specific month and year.
        /// </summary>
        /// <param name="year">The year for which to calculate the income.</param>
        /// <param name="month">The month for which to calculate the income.</param>
        /// <returns>The total income for the specified period, including base salary and applicable contract values.</returns>
        /// <remarks>
        /// This method calculates the worker's income by:
        /// 1. Starting with the base salary.
        /// 2. Adding the total value of all contracts that match the specified year and month.
        /// Contracts from other periods are not included in the calculation.
        /// </remarks>
        public double Income(int year, int month) //Method to calculate the worker pay in the selected month
        {
            double sum = BaseSalary; //Sum starts with the base salary already initialized
            foreach (HourContract contract in Contracts) // iterate through the contract list 
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue(); //TotalValue is the operation that returns the contract value
                }
            }
            return sum;
        }
    }
}
