using System;
using System.Diagnostics;

namespace Fractions
{
    public class Department
    {

      public string[] Employee { get; set; }
      public  int ID { get; set; }

        public Department( int id )
        {
            Employee = new string[3]
            {
                "ahmed" ,
                "Ali",
                "mohammed"
            };

            ID = id;
        }

        public Department()
        {

        }

        // constructor for Copy

        public Department( Department Dep1)
        {
            this.ID = Dep1.ID;
            this.Employee = new string[3];
                for (int i = 0; i < Dep1.Employee.Length; i++)
            {
                this.Employee[i] = Dep1.Employee[i];
            }

        }

         //copy

        public Department Copy()
        {
            Department Dep = new Department();
            Dep.ID = this.ID;
            Dep.Employee = this.Employee;
            return Dep;

        }

        public void Display ()
        {
            Console.Write($" id = {ID} \n");
            for (int i = 0; i < Employee.Length; i++)
            {
                Console.Write($" Employee = {Employee[i]} \t");
            }
        }
    }
}

