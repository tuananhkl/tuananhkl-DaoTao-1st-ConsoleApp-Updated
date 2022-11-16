using System;

namespace AddValidationForNameNAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var check = false;

            do
            {
                Console.Write("Enter your name: ");
                var name = Console.ReadLine();

                if (name is null || name.Equals(""))
                {
                    Console.WriteLine("You haven't enter anything");
                }
                else
                {
                    Console.Write("Enter your age: ");
                    var textAge = Console.ReadLine();

                    if (int.TryParse(textAge, out var age))
                    {
                        Console.WriteLine($"Your name is: {name}");
                        Console.WriteLine($"Your age is {age}");
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("You entered an invalid age.");
                    }
                }
            } while (check == false);
        }
    }
}