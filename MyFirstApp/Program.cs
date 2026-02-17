namespace MyFirstApp
{
    internal class Program
    {
        //Entry point of the program. All Code execution starts from here
        static void Main(string[] args)
        {
            ////
            Console.WriteLine("This is your first app!");
            Console.WriteLine("My name is yusra!");

            Console.Write("Welcome to coding in c#!");
            Console.Write("Hello");

            //String Manipulation

            //String Concatenation

            string name = "Yusra";
            int age = 28;

            Console.WriteLine();

            //using the + operator is called string concatenation. Use to join different data types together
            Console.WriteLine("My name is " + name + " and I am " + age + " years old.");

            //String interpolation
            Console.WriteLine($"My name is {name} and I am {age} years old!");

            //Prompt the user to input by using ReadLine method
            Console.WriteLine("Enter the user name");
            string Name = Console.ReadLine();
        }
        /* How do you take in user input and print the user input out */
    }        
}
