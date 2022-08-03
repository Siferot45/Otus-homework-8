using System;
using System.Collections.Generic;

namespace OtusHomework_8
{
    public class Tree
    {
        public Node Root { get; private set; }
        public int Count { get; private set; }
        public void Add(Employee employee)
        {
            if (Root == null)
            {
                Root = new Node(employee);
                Count = 1;
                return;
            }
            Root.Add(employee);
            Count++;
        }
        /// <summary>
        /// Checking the  tree for null.
        /// </summary>
        /// <returns></returns>
        public List<Employee> Inorder()
        {
            if (Root == null)
            {
                return new List<Employee>();
            }
            return Root.Inorder(Root);
        }
        /// <summary>
        /// Output of sorted values.
        /// </summary>
        public void PrintInorder()
        {
            foreach (var item in Inorder())
            {
                Console.WriteLine($"Employee's name - {item.Name}  Salary employee - {item.Salary}.");
            }
        }
        /// <summary>
        /// Checking the desired item and sending it on.
        /// </summary>
        public void EmployeeSearch()
        {
            Console.WriteLine("\nEnter the salary of employee you are looking for.");

            do
            {
                var number = Console.ReadLine();
                if (uint.TryParse(number, out var needle))
                {
                    Root.Find(Root, needle);
                }
                else
                {
                    Console.WriteLine("Enter the employee's salary(in numbers)");
                }
            }
            while (true);
        }
    }
}
