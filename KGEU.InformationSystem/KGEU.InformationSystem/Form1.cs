using KGEU.InformationSystem.XMLDocCreat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGEU.InformationSystem
{
    public partial class TestSystem : Form
    {
        List<Question> questionsList = new List<Question>();
        XMLDocCreator docCreator = new XMLDocCreator();
        string coorrectAnswer;
        public TestSystem()
        {
            InitializeComponent();
        }

        private void TestSystem_Load(object sender, EventArgs e)
        {
            questionsList.AddRange(docCreator.GetQuestions());
            fillUpOrUpdateLayout();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked & !radioButton2.Checked & !radioButton3.Checked & !radioButton4.Checked)
            {
                MessageBox.Show("Выберете вариант ответа.");
            }
            else
            {
                
                Debug.WriteLine(coorrectAnswer);
                if (radioButton1.Checked) {
                    if (String.Equals(radioButton1.Text, coorrectAnswer))
                        points.Text = (Int32.Parse(points.Text) + 1).ToString();
                    Debug.WriteLine(String.Equals(radioButton1.Text, coorrectAnswer) + " " + radioButton1.Text + " " + coorrectAnswer);
                }

                else if (radioButton2.Checked) {
                    if (String.Equals(radioButton2.Text, coorrectAnswer))
                        points.Text = (Int32.Parse(points.Text) + 1).ToString();
                }

                else if (radioButton3.Checked) {
                    if (String.Equals(radioButton3.Text, coorrectAnswer))
                        points.Text = (Int32.Parse(points.Text) + 1).ToString();
                }

                else if (radioButton4.Checked) {
                    if(String.Equals(radioButton4.Text, coorrectAnswer))
                        points.Text = (Int32.Parse(points.Text) + 1).ToString();
                }
                fillUpOrUpdateLayout();

                radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
            }
        }

        private void fillUpOrUpdateLayout()
        {

            int num = Int32.Parse(questionNumber.Text);
            Debug.WriteLine(questionsList.Count() + " " + num);
            if (num < questionsList.Count())
            {
                num++;
                questionNumber.Text = num.ToString();
                var firstQuestion = questionsList.First(I => I.number == num);
                richTextBox.Text = firstQuestion.QuestionText;

                string[] arrayAnswers = new string[4] { firstQuestion.CorrectAnswer, firstQuestion.FirstIncorrectAnswer,
                firstQuestion.SecondIncorrectAnswer, firstQuestion.ThirdIncorrectAnswer };
                arrayAnswers = changePlacesArray(arrayAnswers);

                radioButton1.Text = arrayAnswers[0];
                radioButton2.Text = arrayAnswers[1];
                radioButton3.Text = arrayAnswers[2];
                radioButton4.Text = arrayAnswers[3];
                coorrectAnswer = firstQuestion.CorrectAnswer;
            }
            else
            {
                Enter.Enabled = false;
            }
        }

        private string[] changePlacesArray(string[] arr)
        {
            Random random = new Random();
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
    }
}
