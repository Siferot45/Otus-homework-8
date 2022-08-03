
using System;

namespace OtusHomework_8
{
    public class Employee
    {
        public string Name { get; private set; }
        public uint Salary { get; private set; }
        public Employee()
        {
            string name;
            uint salary;

            Console.WriteLine("Enter the employee's name.");
            
            name = Console.ReadLine();
            Name = name;

            if (name == "")
                return;

            Console.WriteLine("Enter the employee's salary.");
            do
            {
                var number = Console.ReadLine();
                if (uint.TryParse(number, out salary))
                {
                    Salary = salary;
                    break;
                }
                Console.WriteLine("Enter the employee's salary(in numbers)");
            } 
            while (true);
        }
    }
}
