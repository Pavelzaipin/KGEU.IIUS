using System;
using System.Windows.Forms;

namespace KGEU.InformationSystem
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Supervisor" && textBox2.Text == "Supervisor")
            {

                Program.Context.MainForm = new TestSystem();

                this.Close();

                // покажет вторую форму и оставит приложение живым до ее закрытия
                Program.Context.MainForm.Show();

            }
        }
    }
}
