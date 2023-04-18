using System.Security.Cryptography;

namespace FluentInterfaceDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("000000000000000000000000000000");

            int[] someNumbers = { 4, 3, 2, 1 };

            //chaining that comes together with LINQ framework

            //variable where this chain method will create an output:

            var processedValues = someNumbers
                .Select(n => n * 10) //left side each represented element. On right - representing statement --what we want to do with this element
                .Where(n => n > 10); //allowing to do check of our elements, output as a condition if - then true



            //this is the same as:
            foreach (int n in someNumbers)
            {
                Console.WriteLine(n * 10);
            }
            //HOWEVER, we also need an IF statement and that would be hard to implement here!
            Console.WriteLine("000000000000000000000000000000");


            ShowElements(processedValues);

            Console.WriteLine("000000000000000000000000000000");


            FluentEmployee employeeObject = new FluentEmployee();

            employeeObject
                .NameOfEmployee("Anthony Finn")
                .EmployeeDateOfBirth("12/09/1992")
                .EmployeeDepartment("IT")
                .EmployeeAddress("5th Avenue");

            employeeObject.ShowDetailsOfEmployee();

        }

        static void ShowElements(IEnumerable<int> values)
        {
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }



    }
}