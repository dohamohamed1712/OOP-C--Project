using System;
using System.Collections.Generic;
using System.Text;

namespace oopProjectC_
{
  public abstract class Question:IComparable<Question>

    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }


        protected Question(string header, string body, double mark, Answer[] answerList, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }
        public abstract void DisplayQuestion();

        public int CompareTo(Question other)
        {
            if (other == null) return 1;
            return this.Mark.CompareTo(other.Mark);
        }

        public override string ToString()
        {
            return $"[{Header}] {Body} (Mark: {Mark})";
        }

    }
}
