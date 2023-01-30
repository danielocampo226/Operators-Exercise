namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            Console.WriteLine($"Sum: {sum}");

            int diff = a - b;
            Console.WriteLine($"Difference: {diff}");

            int product = a * b;
            Console.WriteLine($"Product: {product}");

            int quotient = a / b;

            int remainder = a % b;
            Console.WriteLine($"a divided by b is {quotient} remainder {remainder}");

            //Exercise 2
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of the circle is {area}.");

           

            

            
        


        }
    }
}
