using demoClass.Math;

namespace demoClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            person john = new person();
            john.FirstName = "John";
            john.LastName = "Doe";
            john.Introduce();
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            System.Console.WriteLine(result);
        }
    }
}
