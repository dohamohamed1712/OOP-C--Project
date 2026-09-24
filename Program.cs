using System;

namespace oopProjectC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----- 1) Prepare answers & questions for the exam -----

            // MCQ Question
            Answer a1 = new Answer(1, "Alexandria");
            Answer a2 = new Answer(2, "Cairo");
            Answer a3 = new Answer(3, "Luxor");

            MCQQuestion mcq = new MCQQuestion(
                "General Knowledge",
                "What is the capital of Egypt?",
                10,
                new Answer[] { a1, a2, a3 },
                a2   // Cairo is the right answer
            );

            // True/False Question
            Answer tfRight = new Answer(1, "True");

            TrueFalseQuestion tf = new TrueFalseQuestion(
                "Geography",
                "The Nile is the longest river in Africa.",
                5,
                tfRight
            );

            Question[] questions = new Question[] { mcq, tf };

            // Another MCQ question, used for the Practical Exam
            Answer p1 = new Answer(1, "SELECT");
            Answer p2 = new Answer(2, "GET");
            Answer p3 = new Answer(3, "FETCH");

            MCQQuestion mcq2 = new MCQQuestion(
                "SQL",
                "Which keyword is used to retrieve data from a database?",
                10,
                new Answer[] { p1, p2, p3 },
                p1
            );

            Question[] practicalQuestions = new Question[] { mcq2 };

            // ----- 2) Create a Subject and its Final Exam -----

            Subject math = new Subject(1, "Mathematics");
            Console.WriteLine(math.ToString());
            Console.WriteLine();

            math.CreateExam(ExamType.Final, 60, questions.Length, questions);
            math.SubjectExam.ShowExam();   // Polymorphism: runs FinalExam's ShowExam

            // ----- 3) Create a second Subject with a Practical Exam -----

            Subject programming = new Subject(2, "Programming 101");
            Console.WriteLine();
            Console.WriteLine(programming.ToString());
            Console.WriteLine();

            programming.CreateExam(ExamType.Practical, 30, practicalQuestions.Length, practicalQuestions);
            programming.SubjectExam.ShowExam();   // Polymorphism: runs PracticalExam's ShowExam

            // ----- 4) Test IComparable on Question -----

            Console.WriteLine("===== Testing IComparable (Question) =====");
            int qCompare = mcq.CompareTo(tf);
            Console.WriteLine($"mcq.Mark ({mcq.Mark}) compared to tf.Mark ({tf.Mark}) => {qCompare}");
            Console.WriteLine();

            // ----- 5) Test IComparable on Exam -----

            Console.WriteLine("===== Testing IComparable (Exam) =====");
            int eCompare = math.SubjectExam.CompareTo(programming.SubjectExam);
            Console.WriteLine($"math exam questions ({math.SubjectExam.NumberOfQuestions}) compared to programming exam questions ({programming.SubjectExam.NumberOfQuestions}) => {eCompare}");
            Console.WriteLine();

            // ----- 6) Test ICloneable on Exam -----

            Console.WriteLine("===== Testing ICloneable (Exam) =====");
            Exam clonedExam = (Exam)math.SubjectExam.Clone();
            clonedExam.ExamTime = 999;   // change only the clone
            Console.WriteLine($"Original exam time: {math.SubjectExam.ExamTime}");
            Console.WriteLine($"Cloned exam time:   {clonedExam.ExamTime}");
            Console.WriteLine("(Questions array is shared - shallow copy - same reference in both)");
            Console.WriteLine($"Same Questions reference? {ReferenceEquals(math.SubjectExam.Questions, clonedExam.Questions)}");
        }
    }
}