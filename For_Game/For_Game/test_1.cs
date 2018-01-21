using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Game
{
    public partial class test_1 : Form
    {
        public test_1()
        {
            InitializeComponent();
            textBox1.Validating += TextBox1_Validating;
        }

        private void test_1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Нужно ответить!");
            }
            else if (textBox1.Text!="Yes")
            {
                errorProvider1.SetError(textBox1, "Да (english)!");
            }
            else
            {
                errorProvider1.Clear();
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if  (textBox1.Text.Equals("Yes") || textBox1.Text.Equals("yes"))            
            {
                End_Win.Flag = true;
                this.Close();
            }
            else { /*MessageBox.Show("да (english)");*/ return; }
        }
    }
}
