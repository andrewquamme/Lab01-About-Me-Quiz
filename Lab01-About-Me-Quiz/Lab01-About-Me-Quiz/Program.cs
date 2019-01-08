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
            Console.Write($"You answered {count} out of 5 questions correctly. ");
            Console.WriteLine(GetResults(count));
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

        static string GetResults(int count)
        {
            
            switch (count)
            {
                case 5:
                    return "Awesome job!";
                case 4:
                    return "You know me pretty well!";
                case 3:
                    return "Almost!";
                case 2:
                    return "Better luck next time!";
                case 1:
                    return "Ouch...";
                default:
                    return "It's like you don't even know me.";
            }
        }
    }
}
