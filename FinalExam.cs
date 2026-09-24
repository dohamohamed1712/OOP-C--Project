using System;
using System.Collections.Generic;
using System.Text;

namespace oopProjectC_
{
    public class FinalExam :Exam
    {
        public FinalExam(int examTime, int numberOfQuestions, Question[] questions)
            : base(examTime, numberOfQuestions, questions)
        {
        }
        public override void ShowExam()
        {
            Console.WriteLine("===== Final Exam =====");
            Console.WriteLine(this.ToString());
            Console.WriteLine();

            double totalGrade = 0;

            foreach (Question q in Questions)
            {
                q.DisplayQuestion();   
                Console.WriteLine();
                totalGrade += q.Mark;
            }

            Console.WriteLine($"Total Grade: {totalGrade}");
        }
    }
}
