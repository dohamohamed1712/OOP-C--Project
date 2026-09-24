using System;
using System.Collections.Generic;
using System.Text;

namespace oopProjectC_
{
    public  abstract class Exam:IComparable<Exam>,ICloneable
    {
        public int ExamTime { get; set; }              
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        protected Exam(int examTime, int numberOfQuestions, Question[] questions)
        {
            ExamTime = examTime;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }

        public abstract void ShowExam();

        public int CompareTo(Exam other)
        {
            if (other == null) return 1;
            return this.NumberOfQuestions.CompareTo(other.NumberOfQuestions);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

       
        public override string ToString()
        {
            return $"Exam - Time: {ExamTime} min, Number of Questions: {NumberOfQuestions}";
        }
    }
}
