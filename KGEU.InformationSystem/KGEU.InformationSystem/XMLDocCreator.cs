using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KGEU.InformationSystem
{
    public class XMLDocCreator
    {
        XmlSerializer formatter = new XmlSerializer(typeof(List<Question>));
        public void AddRecordInFile(List<Question> questions)
        {
            using (FileStream fs = new FileStream("Вопросы.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, questions);
                Console.WriteLine("Объект сериализован");
            }
        }

        public List<Question> GetQuestions()
        {
            try
            {
                using (FileStream fs = new FileStream("Вопросы.xml", FileMode.OpenOrCreate))
                {
                    var list = (List<Question>)formatter.Deserialize(fs);
                    Console.WriteLine("Объект десериализован");
                    return list;
                }
            } catch (FileNotFoundException e)
            {
                MessageBox.Show("Выберете вариант ответа.");
                List<Question> questions = new List<Question>();
                return questions;
            }
        }
    }
}
