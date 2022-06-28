using System;

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
}
