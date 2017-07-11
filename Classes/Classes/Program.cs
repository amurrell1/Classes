using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Employee
    {
       
        /*
         public int Age
         
             get { return age; } //tells me what i can actually get
             set { age = value; } //tells me where to get it from
             */
        public int Age { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }
        
        public void Bonus(double bonusPercent)
        {
            Salary += Salary * bonusPercent;
        }
        public Employee(int age, string name, double salary, DateTime startingDate, string phoneNumber)
        {
            Age = age;
            Name = name;
            Salary = salary;
            startingDate = startingDate;
            phoneNumber = phoneNumber;
        }
        public Employee()
        {

        }
        
        /*
        
            get { return name; } //tells me what i can actually get
            set { name = value; } //tells me where to get it from
            */
    }
        class Program
        {
            static void Main(string[] args)
            {
            Employee Andre = new Employee()
            {
                Age = 37,
                Name = "Andre Murrell",
                Salary = 120000.00,
                StartingDate = new DateTime(2017, 10, 08),
                PhoneNumber = "910-263-9385",
            };
                
                Console.WriteLine("Andre's age is {0} he started on {1} and makes {2}", Andre.Age, Andre.StartingDate, Andre.Salary);
            Andre.Bonus(0.05);
            Console.WriteLine("Andre's age is {0} he started on {1} and makes {2}", Andre.Age, Andre.StartingDate, Andre.Salary);
            Employee Avie = new Employee()
            {
                Age = 34,
                Name = "Avie Murrell",
                Salary = 80000.00,
                StartingDate = new DateTime(2017, 10, 08),
                PhoneNumber = "678-357-5093",
            };
            Avie.Bonus(0.05);
            Console.WriteLine("Avie's age is {0} she started on {1} and makes {2}", Avie.Age, Avie.StartingDate, Avie.Salary);
            
        }
        }
    }

