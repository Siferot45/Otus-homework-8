
using System;
using System.Collections.Generic;

namespace OtusHomework_8
{
    public class Node
    {
        public Employee Data { get; private set; }
        public Node Left { get; private set; }
        public Node Right { get; private set; }
        public Node(Employee employsee)
        {
            Data = employsee;
        }
        public void Add(Employee employee)
        {
            var node = new Node(employee);

            if (employee.Salary < Data.Salary)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(employee);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(employee);
                }
            }
        }
        /// <summary>
        /// Symmetric tree traversal.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<Employee> Inorder(Node node)
        {
            List<Employee> list = new();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }
                list.Add(node.Data);
                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
            }
            return list;
        }
        /// <summary>
        /// Recursive employee search.
        /// </summary>
        /// <param name="node"> The node in which we are looking for </param>
        /// <param name="needle"> The key we are looking for </param>
        public void Find(Node node, uint needle)
        {
            if (needle < node.Data?.Salary)
            {
                if (node.Left == null)
                {
                    Console.WriteLine("No such employee was found");
                    return;
                }
                Find(node.Left, needle);
            }
            else if (needle > node.Data.Salary)
            {
                if (node.Right == null)
                {
                    Console.WriteLine("No such employee was found");
                    return;
                }
                Find(node.Left, needle);
            }
            else
            {
                Console.WriteLine($"Employee's name - {node.Data.Name} ");
            }
        }
    }
}




