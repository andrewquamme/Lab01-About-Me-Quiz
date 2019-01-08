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
    }
}
