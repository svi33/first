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
    public partial class move_1 : Form
    {
        int Inscore = 65;
        private static int WM_KEYUP = 0x0101;
        bool goleft, goright;
        bool start = false;
        int glob_sp = 15;
        int speed = 10;
        int enemy_sp1 = 5;
        int enemy_sp2 = 5;
        int enemy_sp3 = 5;
        int enemy_sp4 = 5;
        public move_1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Управление: left-A, right-D \n " +
                /*End_Win.H_Name + */" Подберите  все буквы алфавита \n" + "Pick up all the letters of the alphabet");
            timer1.Interval = glob_sp;
            timer1.Start();
            Start.Visible = false;
            hero.Visible = true; start = true;
            label1.Visible = true; label2.Visible = true;
            Score.Visible = true;
            enemy_1.Visible = true; //enemy_3.Visible = true;
            enemy_2.Visible = true; //enemy_4.Visible = true;
            Pause.Visible = true;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (start)
            {
                switch (keyData)
                {
                    case Keys.A:
                        {
                            goleft = true;
                            //
                            break;
                        }
                    case Keys.D:
                        {
                            goright = true;
                            //
                            break;
                        }

                    default: return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            return true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (goleft)
            {
                //
                hero.Left -= speed;
                foreach (Control II in this.Controls)
                {
                    if (II is Label && II.Tag == "wall")
                    { if (II.Bounds.IntersectsWith(hero.Bounds)) hero.Left += speed; }

                }

            }
            if (goright)
            {
                hero.Left += speed;
                foreach (Control II in this.Controls)
                {
                    if (II is Label && II.Tag == "wall")
                    { if (II.Bounds.IntersectsWith(hero.Bounds)) hero.Left -= speed; }

                }
            }

            pictureBox1.Top += (speed - 5);
            foreach (Control II in this.Controls)
            {
                if (II is Label && II.Tag == "wall")
                    if (II.Bounds.IntersectsWith(pictureBox1.Bounds)) { pictureBox1.Top = -15;}
            }
            pictureBox2.Top += (speed - 5);
            foreach (Control II in this.Controls)
            {
                if (II is Label && II.Tag == "wall")
                    if (II.Bounds.IntersectsWith(pictureBox2.Bounds)) { pictureBox2.Top = -15; }
            }



            if (enemy_1.Visible == true)
            {
                enemy_1.Top += enemy_sp1;
                if (enemy_1.Bounds.IntersectsWith(hero.Bounds))
                {
                    timer1.Stop();
                    MessageBox.Show("Game Over");
                    this.Close();
                }
                foreach (Control II in this.Controls)
                {
                    if (II is Label && II.Tag == "wall")
                        if (II.Bounds.IntersectsWith(enemy_1.Bounds))
                        {
                            enemy_1.Visible = false;
                            Random rnd = new Random();
                            enemy_4.Location = new System.Drawing.Point(rnd.Next(55, 350), 10);
                            enemy_4.Visible = true;
                        }
                }
            }

            if (enemy_4.Visible == true)
            {
                enemy_4.Top += enemy_sp4;
                if (enemy_4.Bounds.IntersectsWith(hero.Bounds))
                {
                    timer1.Stop();
                    MessageBox.Show("Game Over");
                    this.Close();
                }
                foreach (Control II in this.Controls)
                {
                    if (II is Label && II.Tag == "wall")
                        if (II.Bounds.IntersectsWith(enemy_4.Bounds))
                        {
                            enemy_4.Visible = false;
                            Random rnd = new Random();
                            enemy_1.Location = new System.Drawing.Point(rnd.Next(55, 350), 10);
                            enemy_1.Visible = true;
                        }
                }
            }


            Score.Top += (speed-5);
            if (Score.Bounds.IntersectsWith(hero.Bounds))
            {
                Score.Visible = false;
                Random rnd = new Random();
                Score.Location = new System.Drawing.Point(rnd.Next(55, 700), 10);
                Score.Visible = true;
                string N = Score.Text;
                if (N.Equals("Z"))
                {
                    timer1.Stop();
                    End_Win.Flag = true;
                    MessageBox.Show("You Win !!!");
                    this.Close();
                }
                Inscore++;
                char n;
                n = (char)Inscore;
                Score.Text = n.ToString();
                
            }
            foreach (Control II in this.Controls)
            {
                if (II is Label && II.Tag == "wall")
                {
                    if (II.Bounds.IntersectsWith(Score.Bounds))
                    {
                        Score.Visible = false;
                        Random rnd = new Random();
                        Score.Location= new System.Drawing.Point(rnd.Next(55,700), 10);
                        Score.Visible = true;
                    }
                }
                if (II is PictureBox && II.Tag == "enemy")
                {
                    if (II.Bounds.IntersectsWith(Score.Bounds))
                    {
                        Score.Visible = false;
                        Random rnd = new Random();
                        Score.Location = new System.Drawing.Point(rnd.Next(55, 700), 10);
                        Score.Visible = true;
                    }
                }


            }

            if (enemy_3.Visible==true)
            {
                enemy_3.Top += enemy_sp3;
                if (enemy_3.Bounds.IntersectsWith(hero.Bounds))
                {
                    timer1.Stop();
                    MessageBox.Show("Game Over");
                    this.Close();
                }
                foreach (Control II in this.Controls)
                {
                    if (II is Label && II.Tag == "wall")
                        if (II.Bounds.IntersectsWith(enemy_3.Bounds))
                        {
                            enemy_3.Visible = false;
                            Random rnd = new Random();
                            enemy_2.Location = new System.Drawing.Point(rnd.Next(350, 700), 10);
                            enemy_2.Visible = true;
                        }
                }
            }

            if (enemy_2.Visible==true)
            {
                enemy_2.Top += enemy_sp2;
                if (enemy_2.Bounds.IntersectsWith(hero.Bounds))
                {
                    timer1.Stop();
                    MessageBox.Show("Game Over");
                    this.Close();
                }
                foreach (Control II in this.Controls)
                {
                    if (II is Label && II.Tag == "wall")
                        if (II.Bounds.IntersectsWith(enemy_2.Bounds))
                        {
                            enemy_2.Visible = false;
                            Random rnd = new Random();
                            enemy_3.Location = new System.Drawing.Point(rnd.Next(350, 700), 10);
                            enemy_3.Visible = true;
                        }
                }
            }

        }

        private void Pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Start.Visible = true;
            Pause.Visible = false;
        }

        protected override bool ProcessKeyEventArgs(ref Message m)
        {
            if (m.Msg == WM_KEYUP)
            {
                switch (m.WParam.ToInt32())
                {
                    case (int)Keys.A:
                        goleft = false;
                        break;
                    case (int)Keys.D:
                        goright = false;
                        break;
                }
            }

            return base.ProcessKeyEventArgs(ref m);
        }

    }
}
