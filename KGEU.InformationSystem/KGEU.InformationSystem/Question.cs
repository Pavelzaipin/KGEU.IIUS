using System;

namespace KGEU.InformationSystem
{
    /// <summary>
    /// Объект вопроса с ответами 
    /// </summary>
    [Serializable]
    public class Question
    {
        public int number { get; set; }
        public int points { get; set; }
        public string QuestionText { get; set; }
        public string CorrectAnswer { get; set; }
        public string FirstIncorrectAnswer { get; set; }
        public string SecondIncorrectAnswer { get; set; }
        public string ThirdIncorrectAnswer { get; set; }



        /// <summary>
        /// Стандартный конструктор без параметров
        /// </summary>
        public Question() { }

        /// <summary>
        /// Коструктор для установления перменных класса
        /// </summary>
        /// <param name="QuestionText">Текст вопроса</param>
        /// <param name="CorrectAnswer">Правильный ответ</param>
        /// <param name="FirstIncorrectAnswer">Первый не правильный ответ</param>
        /// <param name="SecondIncorrectAnswer">Второй не правильный ответ</param>
        /// <param name="ThirdIncorrectAnswer">Третий не правильный ответ</param>
        public Question(int number, int points, string QuestionText, string CorrectAnswer, string FirstIncorrectAnswer, string SecondIncorrectAnswer, string ThirdIncorrectAnswer)
        {
            this.number = number;
            this.points = points;
            this.QuestionText = QuestionText;
            this.CorrectAnswer = CorrectAnswer;
            this.FirstIncorrectAnswer = FirstIncorrectAnswer;
            this.SecondIncorrectAnswer = SecondIncorrectAnswer;
            this.ThirdIncorrectAnswer = ThirdIncorrectAnswer;
        }
    }
}

