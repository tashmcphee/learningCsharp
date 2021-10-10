using System;

namespace Lesson_2_Activity_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        var questionone = ("Favourite Colour");
            
    Console.WriteLine(questionone);
    var question1 = Console.ReadLine();

            var questiontwo = ("mermaid or unicorn?");

            Console.WriteLine(questiontwo);
            var question2 = Console.ReadLine();

            var questionthree = ("Favourite song");
            Console.WriteLine(questionthree);
            var question3 = Console.ReadLine();

            Console.WriteLine($"I like {question1} {question2} that sing {question3} !");
        }
    }
}
