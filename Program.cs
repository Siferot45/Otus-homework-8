using System;

namespace OtusHomework_8
{
    class Program
    {
        static void Main()
        {
            var tree = new Tree();
            do
            {
                var employsee = new Employee();

                if (employsee.Name == "")
                    break;
                tree.Add(employsee);
            }
            while (true);

            tree.PrintInorder();

            tree.EmployeeSearch();
        }
    }
}
