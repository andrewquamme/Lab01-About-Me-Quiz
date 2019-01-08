using System;

namespace Lab01_About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Take my quiz and learn a little about me!");
            count += QuestionOne();
            ShowResults(count);
        }

        static int QuestionOne()
        {
            Console.WriteLine("In what state did I grow up?");
            string answerOne = Console.ReadLine();
            if(CheckAnswer(1, answerOne))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static bool CheckAnswer(int question, string answer)
        {
            switch (question)
            {
                case 1:
                    if(answer.ToUpper() == "WI" || answer.ToUpper() == "WISCONSIN")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }

        static void ShowResults(int count)
        {
            Console.Write($"You answered {count} out of 5 questions correctly. ");
            switch (count)
            {
                case 5:
                    Console.Write("Awesome job!");
                    break;
                case 4:
                    Console.Write("You know me pretty well!");
                    break;
                case 3:
                    Console.Write("Almost!");
                    break;
                case 2:
                    Console.Write("Better luck next time!");
                    break;
                case 1:
                    Console.Write("Ouch...");
                    break;
                case 0:
                    Console.Write("It's like you don't even know me.");
                    break;
            }
        }
    }
}
