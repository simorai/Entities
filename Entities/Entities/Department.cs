namespace Entities.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the Department class.
        /// </summary>
        /// <remarks>
        /// This is a parameterless constructor that creates an empty Department object.
        /// It allows for the creation of a Department instance without setting any initial values.
        /// Properties of the Department can be set individually after instantiation.
        /// 
        /// This constructor is useful in scenarios such as:
        /// - When you need to create a Department object and set its properties later.
        /// - When working with frameworks or libraries that require a parameterless constructor.
        /// - For serialization and deserialization processes.
        /// </remarks>
        public Department()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Department class with a specified name.
        /// </summary>
        /// <param name="name">The name of the department.</param>
        /// <remarks>
        /// This constructor creates a Department object with its name set.
        /// It provides a convenient way to create and initialize a Department
        /// in a single step, ensuring that every Department instance has a name.
        /// 
        /// Usage example:
        /// Department hr = new Department("Human Resources");
        /// </remarks>
        public Department(string name)
        {
            Name = name;
        }
    }
}
