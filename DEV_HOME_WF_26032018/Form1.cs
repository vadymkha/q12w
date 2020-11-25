using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV_HOME_WF_26032018
{
    public partial class Form1 : Form
    {
        public int number;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int max = 3400;
            int min = 1;
            number = rand.Next(min, max);
            DialogResult result = DialogResult.No;
            while (result == DialogResult.No )
            {
                result = MessageBox.Show($"Это число что вы загадали? ЧИСЛО:{number}", "Число", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( result == DialogResult.No )
                {
                    if (MessageBox.Show($"Больше или меньше?", "Число", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        min = number;
                        number = rand.Next(min, max);
                    }
                    else
                    {
                        max = number;
                        number = rand.Next(min, max);
                    }
                }
            }
            MessageBox.Show($"Отгаданое число:{number}", "Число", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(0);
        }
    }
}
