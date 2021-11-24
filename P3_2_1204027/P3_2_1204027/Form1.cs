using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_2_1204027
{
    public partial class ChilForm : Form
    {
        private string outputText = DateTime.Now.ToString("d");

        public ChilForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = outputText;
        }

        private void DateOption_Click(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("d");
        }

        private void TimeOption_Click(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("t");
        }
    }
}
