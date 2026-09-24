using System;
using System.Collections.Generic;
using System.Text;

namespace oopProjectC_
{
   public class PracticalExam :Exam
    {
        public PracticalExam(int examTime, int numberOfQuestions, Question[] questions)
            : base(examTime, numberOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("===== Practical Exam (Finished) =====");
            Console.WriteLine(this.ToString());
            Console.WriteLine();

            foreach (Question q in Questions)
            {
                Console.WriteLine(q.ToString());
                Console.WriteLine($"Right Answer: {q.RightAnswer}");
                Console.WriteLine();
            }
        }
    }
}
