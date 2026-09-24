using System;
using System.Collections.Generic;
using System.Text;

namespace oopProjectC_
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam(ExamType examType, int examTime, int numberOfQuestions, Question[] questions)
        {
            if (examType == ExamType.Final)
            {
                SubjectExam = new FinalExam(examTime, numberOfQuestions, questions);
            }
            else if (examType == ExamType.Practical)
            {
                SubjectExam = new PracticalExam(examTime, numberOfQuestions, questions);
            }
        }

        public override string ToString()
        {
            return $"Subject: {SubjectName} (Id: {SubjectId})";
        }
    }
}
