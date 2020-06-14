using KGEU.InformationSystem.XMLDocCreat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string val1 = "abra";
            string val2 = "abra";
            Console.WriteLine(String.Equals(val1, val1));
            XMLDocCreator docCreator = new XMLDocCreator();
            Question question = new Question();
            List<Question> questionsList = new List<Question>();
            questionsList.AddRange(docCreator.GetQuestions());
            do
            {
                Console.WriteLine("Добавление новой записи" + questionsList.Count());
                Console.Write("Номер: ");
                string value = Console.ReadLine();
                if (value == "exit")
                    break;
                question.number = Int32.Parse(value);
                Console.Write("Баллы: ");
                question.points = Int32.Parse(Console.ReadLine());
                Console.Write("Вопрос: ");
                question.QuestionText = Console.ReadLine();
                Console.Write("Правильный ответ: ");
                question.CorrectAnswer = Console.ReadLine();
                Console.Write("Неправильный ответ 1: ");
                question.FirstIncorrectAnswer = Console.ReadLine();
                Console.Write("Неправильный ответ 2: ");
                question.SecondIncorrectAnswer = Console.ReadLine();
                Console.Write("Неправильный ответ 3: ");
                question.ThirdIncorrectAnswer = Console.ReadLine();

                questionsList.Add(question);
                
            } while (true);
            docCreator.AddRecordInFile(questionsList);
        }
    }
}
