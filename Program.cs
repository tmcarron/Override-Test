using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Tyler = new Person("Tyler", "Carron");
            Console.WriteLine(Tyler.GetFullName());
            Worker John = new Worker("John", "Smith");
            Console.WriteLine(John.GetFullName());
        }
    }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string fn, string ln)
        {
            this.FirstName = fn;
            this.LastName = ln;
        }
        public virtual string GetFullName()
        {
            return "Person's Name: "+FirstName + " " + LastName;
        }
    }
    class Worker : Person
    {
        public Worker(string fn, string ln) : base(fn, ln)
        {
            this.FirstName = fn;
            this.LastName = ln;
        }
        public override string GetFullName()
        {
            return "Worker's Name: " + FirstName + " " + LastName;
        }
    }
   
}
