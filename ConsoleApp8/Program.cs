using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            FinalExam test = new Test { Score = 80};
            FinalExam exam = new Exam { SumEst = 9, Quantity = 3};

            PrintFinalExam(test); 
            PrintFinalExam(exam);

            void PrintFinalExam(FinalExam FinalExam)
            {
                Console.WriteLine($"Оценка:  {FinalExam.GetEstimation()}");
            }
        }
    }
}

