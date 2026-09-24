using System;
using System.Collections.Generic;
using System.Text;

namespace oopProjectC_
{
     public class TrueFalseQuestion :Question
    {
        public TrueFalseQuestion(string header, string body, double mark, Answer rightAnswer)
           : base(header, body, mark,
                  new Answer[] { new Answer(1, "True"), new Answer(2, "False") },
                  rightAnswer)
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
