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
    public partial class test_2 : Form
    {
        public test_2()
        {
            InitializeComponent();
            textBox1.Validating += TextBox1_Validating;
            textBox2.Validating += TextBox2_Validating;
            textBox3.Validating += TextBox3_Validating;
            textBox4.Validating += TextBox4_Validating;
        }

        private void test_1_Load(object sender, EventArgs e)
        {
            // Здесь могла быть ваша реклама
        }

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Нужно ответить!");
            }
            else if (textBox1.Text!="Yes" || textBox1.Text.Equals("yes"))
            {
                errorProvider1.SetError(textBox1, "Да (english)!");
            }
            else
            {
                errorProvider1.Clear();
               
            }
        }

        private void TextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider2.SetError(textBox2, "Нужно ответить!");
            }
            else if (textBox2.Text != "window")
            {
                errorProvider2.SetError(textBox2, "окно (english)!");
            }
            else
            {
                errorProvider2.Clear();

            }
        }

        private void TextBox3_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider3.SetError(textBox3, "Нужно ответить!");
            }
            else if (textBox3.Text != "yard")
            {
                errorProvider3.SetError(textBox3, "двор (english)!");
            }
            else
            {
                errorProvider3.Clear();

            }
        }

        private void TextBox4_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider4.SetError(textBox4, "Нужно ответить!");
            }
            else if (textBox4.Text != "forest")
            {
                errorProvider4.SetError(textBox4, "лес (english)!");
            }
            else
            {
                errorProvider4.Clear();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals("window"))
            {
                MessageBox.Show(" не верно! ");
                return;
            }
            if (!textBox3.Text.Equals("yard"))
            {
                MessageBox.Show(" не верно! ");
                return;
            }
            if (!textBox4.Text.Equals("forest"))
            {
                MessageBox.Show(" не верно! ");
                return;
            }

            if  (textBox1.Text.Equals("Yes") || textBox1.Text.Equals("yes"))            
            {
                End_Win.Flag = true;
                MessageBox.Show("Отлично");
                this.Close();
            }
            else { /*MessageBox.Show("да (english)");*/ return; }
        }
    }
}
