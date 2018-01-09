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
        int enemy_sp1 = 3;
        int enemy_sp2 = 7;
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

            /*
            enemy_1.Top += enemy_sp;
            if (enemy_1.Bounds.IntersectsWith(hero.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Game Over");
                this.Close();
            }
            foreach (Control II in this.Controls)
            {
                if (II is Label && II.Tag == "wall")
                { if (II.Bounds.IntersectsWith(enemy_1.Bounds)) enemy_sp = -enemy_sp; }

            }
            */
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
                            enemy_4.Location = new System.Drawing.Point(rnd.Next(45, 300), 30);
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
                            enemy_1.Location = new System.Drawing.Point(rnd.Next(45, 300), 35);
                            enemy_1.Visible = true;
                        }
                }
            }


            Score.Top += (speed-5);
            if (Score.Bounds.IntersectsWith(hero.Bounds))
            {
                Score.Visible = false;
                Random rnd = new Random();
                Score.Location = new System.Drawing.Point(rnd.Next(0, 650), 10);
                Score.Visible = true;
                string N = Score.Text;
                if (N.Equals("Z"))
                {
                    timer1.Stop();
                    MessageBox.Show("You Win ");
                    End_Win.Flag = true;
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
                        Score.Location= new System.Drawing.Point(rnd.Next(50,645), 30);
                        Score.Visible = true;
                    }
                }
                if (II is PictureBox && II.Tag == "enemy")
                {
                    if (II.Bounds.IntersectsWith(Score.Bounds))
                    {
                        Score.Visible = false;
                        Random rnd = new Random();
                        Score.Location = new System.Drawing.Point(rnd.Next(50, 645), 30);
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
                            enemy_2.Location = new System.Drawing.Point(rnd.Next(350, 600), 30);
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
                            enemy_3.Location = new System.Drawing.Point(rnd.Next(350, 600), 35);
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
/*
namespace flappyBirdTutorial
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int pipeSpeed = 5;
        int gravity = 5;
        int Inscore = 0;

        public Form1()
        {
            InitializeComponent();
            endText1.Text = "Game Over!";
            endText2.Text = "Your final score is: " + Inscore;
            gameDesigner.Text = "Game Designed By your name here";

            endText1.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            flappyBird.Top += gravity;
            scoreText.Text = "" + Inscore;


            if (pipeBottom.Left < -80)
            {
                pipeBottom.Left = 1000;
                Inscore += 1;
            }
            else if (pipeTop.Left < -95)
            {
                pipeTop.Left = 1100;
                Inscore += 1;
            }


            if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }

        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity = -5;

            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 5;

            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            endText1.Visible = true;
            endText2.Visible = true;
            gameDesigner.Visible = true;
        }
    }
}*/