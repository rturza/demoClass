using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoClass
{
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
