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
            count += QuestionTwo();
            ShowResults(count);
            Console.WriteLine("Press any key to exit the quiz");
            Console.ReadLine();
        }

        static int QuestionOne()
        {
            Console.WriteLine("In what state did I grow up?");
            string answer = Console.ReadLine();
            if(CheckAnswer(1, answer))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static int QuestionTwo()
        {
            Console.WriteLine("Was I in the military? Yes/No");
            string answer = Console.ReadLine();
            if (CheckAnswer(2, answer))
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
                case 2:
                    if (answer.ToUpper() == "Y" || answer.ToUpper() == "Yes")
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
                    Console.WriteLine("Awesome job!");
                    break;
                case 4:
                    Console.WriteLine("You know me pretty well!");
                    break;
                case 3:
                    Console.WriteLine("Almost!");
                    break;
                case 2:
                    Console.WriteLine("Better luck next time!");
                    break;
                case 1:
                    Console.WriteLine("Ouch...");
                    break;
                case 0:
                    Console.WriteLine("It's like you don't even know me.");
                    break;
            }
        }
    }
}
