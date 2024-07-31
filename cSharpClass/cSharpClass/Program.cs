using System;

namespace cSharpClass
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John","Doe");
            {
                employee.PrintName();
            }
        }

    }
    class Employee
    {
        public string _firstName;
        public string _lastName;
        public Employee(string FirstName,string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;

            
        }
        public void PrintName()
        {
            Console.WriteLine("First Name: {0}, Last Name: {1}",this._firstName,this._lastName);
        }
    }
}