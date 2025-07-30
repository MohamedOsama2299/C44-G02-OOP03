using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class EmployeeCompareSalary : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X=(Employee)x;
            Employee Y=(Employee)y;
            if (X.Salary>Y.Salary)return 1;
            else if (X.Salary<Y.Salary) return -1;
            else return 0;
        }

    }
    internal class Employee : ICloneable, IComparable
    {
        public int ID{ get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public object Clone()
        {
            return new Employee
            {
                ID = this.ID,
                Name = this.Name,
                Age = this.Age,
                Salary = this.Salary
            };
        }
            public int CompareTo(object? obj)
            {
                Employee e= (Employee)obj ;
                //if (this.Age>e.Age) return 321;
                //else if (this.Age<e.Age) return -3312;
                //else return 0;
                return this.Age.CompareTo(e.Age);
        }

        //}
        //public Employee(Employee employee)
        //{
        //    ID = employee.ID;
        //    Name = employee.Name;
        //    Age = employee.Age;
        //    Salary = employee.Salary;
        //}

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }  
        
    }
}
