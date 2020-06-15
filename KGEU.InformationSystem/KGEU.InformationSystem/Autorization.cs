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
                TestSystem testSystem = new TestSystem();

                testSystem.Show();
                Hide();
            }
        }
    }
}
