using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KGEU.InformationSystem.XMLDocCreat
{
    public class XMLDocCreator
    {
        XmlSerializer formatter = new XmlSerializer(typeof(List<Question>));
        public void AddRecordInFile(List<Question> questions)
        {

            using (FileStream fs = new FileStream("Question.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, questions);
                Console.WriteLine("Объект сериализован");
            }
        }

        public List<Question> GetQuestions()
        {
            using (FileStream fs = new FileStream("Question.xml", FileMode.OpenOrCreate))
            {
                var list = (List<Question>)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                return list;
            }
        }
    }
}
