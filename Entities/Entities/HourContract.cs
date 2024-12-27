namespace Entities.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }


        /// <summary>
        /// Initializes a new instance of the HourContract class.
        /// </summary>
        /// <remarks>
        /// This is a parameterless constructor that creates an empty HourContract object.
        /// Properties of the HourContract can be set individually after instantiation.
        /// This constructor is useful for scenarios where you need to create a contract
        /// and set its properties later, or when working with certain frameworks that
        /// require a parameterless constructor.
        /// </remarks>
        public HourContract()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HourContract class with specified details.
        /// </summary>
        /// <param name="date">The date when the contract is effective.</param>
        /// <param name="valuePerHour">The pay rate per hour for this contract.</param>
        /// <param name="hours">The number of hours to be worked under this contract.</param>
        /// <remarks>
        /// This constructor creates a fully initialized HourContract object.
        /// It sets all the necessary properties for the contract in one go,
        /// making it convenient to create a complete contract instance.
        /// </remarks>
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        /// <summary>
        /// Calculates the total value of the contract.
        /// </summary>
        /// <returns>The total monetary value of the contract.</returns>
        /// <remarks>
        /// This method computes the total value by multiplying the hourly rate (ValuePerHour)
        /// by the number of hours worked (Hours). It represents the gross amount earned for this contract.
        /// </remarks>
        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
