using System;
using System.Collections.Generic;
using System.Text;

namespace oopProjectC_
{
   public class MCQQuestion:Question
    {
        public MCQQuestion(string header, string body, double mark, Answer[] answerList, Answer rightAnswer)
            : base(header, body, mark, answerList, rightAnswer)
        {
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine(this.ToString());
            foreach (Answer a in AnswerList)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}
