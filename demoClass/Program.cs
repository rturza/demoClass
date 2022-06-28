using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoClass
{
    public class person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My Name is " + FirstName + " " + LastName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person john = new person();
            john.FirstName = "John";
            john.LastName = "Doe";
            john.Introduce();

        }
    }
}
