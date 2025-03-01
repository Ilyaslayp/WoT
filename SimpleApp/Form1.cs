using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userInput = textBox3.Text;
            MessageBox.Show("Вы загадали: " + userInput, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            clickLabel.Visible = true;
            var newvar = new NewClass();
            newvar.Name = "";
        }

    }
}
