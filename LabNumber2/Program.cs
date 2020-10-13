using System;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Would you like to measure some classrooms? (y/n)");
            var answer = Console.ReadLine();

            while (answer.Equals("y"))
            {

                Console.WriteLine("Please enter the length, width and height of the classroom.");

                Console.WriteLine("Length:");
                var length = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Width:");
                var width = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Height:");
                var height = Convert.ToDecimal(Console.ReadLine());

                var area = (length * width);
                var perimeter = ((length * 2) + (width * 2));
                var volume = (length * width * height);

                Console.WriteLine("The area of the classroom is " + area);
                Console.WriteLine("The perimeter of the classroom is " + perimeter);
                Console.WriteLine("The volume of the classroom is " + volume);

                Console.WriteLine("Would you like to do another measurement?");
                answer = Console.ReadLine();
            }
        }
    }
}
