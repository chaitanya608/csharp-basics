using NonPrimitives.Classes;
using NonPrimitives.Math;

namespace NonPrimitives
{
    class Program
    {
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
        
        static void Main(string[] args)
        {
            /*var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            
            john.Introduce();
            
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            
            Console.WriteLine(result);*/

            /*var numbers = new int[3];
            numbers[0] = 1;
            
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            
            var flags = new bool[3];
            flags[0] = true;
            
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
            
            var names = new string[3] {"Jack", "John", "Mary"};*/

            /*var firstName = "Mosh";
            var lastName = "Hemedani";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] {"John", "Jack", "Mary"};
            var formattedNames = string.Join(", ", names);

            var text = "Hi John\nLook into the following paths:\nc:\\folder1\\folder2\\folder3";
            var verbatimText = @"
                Hi John,
                Look into the following paths:
                c:\folder1\folder2\folder3
            ";
            
            Console.WriteLine(verbatimText);*/

            /*var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            Console.WriteLine(method.ToString().GetType());

            var methodName = "Express";
            var parsedEnum = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            
            Console.WriteLine(parsedEnum);*/

            var a = 10;
            var b = a;
            b++;

            Console.WriteLine($"a: {a}, b: {b}");

            var arr1 = new int[3] {1, 2, 3};
            var arr2 = arr1;

            arr2[0] = 0;
            Console.WriteLine(arr1[0]);

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person()
            {
                Age = 20
            };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }
    }
}