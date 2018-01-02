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

    public partial class Form1 : Form
    {
        private static int WM_KEYUP = 0x0101;
        bool goup, godown, goleft, goright;
        bool start = false;
        int glob_sp = 15;
        int speed = 10;
        int enemy_sp = 10;
        int enemy_sp2 = 15;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("up-W, down-S, left-A, right-D");
            timer1.Interval = glob_sp;
            timer1.Start();
            button1.Visible = false;
            this.Width = 930; this.Height = 580;// размер окна ПОМЕНЯТЬ v
            hero.Visible = true; start = true;
            label1.Visible=true; label2.Visible = true;
            label3.Visible = true; label4.Visible = true;
            label5.Visible = true; label6.Visible = true;
            label7.Visible = true; label8.Visible = true;
            label9.Visible = true; label10.Visible = true;
            label14.Visible = true; label16.Visible = true;
            door1.Visible = true; door2.Visible = true;
            door3.Visible = true; door4.Visible = true;
            U.Visible = true; T.Visible = true;
            U_.Visible = true; T_.Visible = true;
            R.Visible = true; E.Visible = true;
            R_.Visible = true; E_.Visible = true;
            label13.Visible = true; label14.Visible = true;
            label15.Visible = true; label17.Visible = true;
            G.Visible = true; O.Visible = true;
            G_.Visible = true; O_.Visible = true;
            label11.Visible = true; label12.Visible = true;
            enemy.Visible = true; enemy2.Visible = true;
            Exit.Visible = true;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (U_.Bounds.IntersectsWith(hero.Bounds))
            { if (button2.Text == "U") U_.Text = "U"; button2.Visible = false; }
            if (U_.Text=="U" && T_.Text == "T")
            { this.Controls.Remove(door1 as Control ); this.Controls.Remove(door2 as Control); }
            if (R_.Bounds.IntersectsWith(hero.Bounds))
            { if (button2.Text == "R") R_.Text = "R"; button2.Visible = false; }
            if (R_.Text == "R" && E_.Text == "E")
            { this.Controls.Remove(door3 as Control);  }
            if (G_.Bounds.IntersectsWith(hero.Bounds))
            { if (button2.Text == "G") G_.Text = "G"; button2.Visible = false; }
            if (G_.Text == "G" && O_.Text == "O")
            { this.Controls.Remove(door4 as Control); }

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            if (T_.Bounds.IntersectsWith(hero.Bounds))
            { if (button3.Text == "T") T_.Text = "T"; button3.Visible = false; }
            if (U_.Text == "U" && T_.Text == "T")
            { this.Controls.Remove(door1 as Control); this.Controls.Remove(door2 as Control); }
            if (E_.Bounds.IntersectsWith(hero.Bounds))
            { if (button3.Text == "E") E_.Text = "E"; button3.Visible = false; }
            if (R_.Text == "R" && E_.Text == "E")
            { this.Controls.Remove(door3 as Control); }
            if (O_.Bounds.IntersectsWith(hero.Bounds))
            { if (button3.Text == "O") O_.Text = "O"; button3.Visible = false; }
            if (G_.Text == "G" && O_.Text == "O")
            { this.Controls.Remove(door4 as Control); }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goleft)
            {
                //
                hero.Left -= speed;
                foreach (Control II in this.Controls)
                {
                    if(II is Label && II.Tag=="wall")
                    { if ( II.Bounds.IntersectsWith(hero.Bounds) ) hero.Left += speed; }
                    if (II is Label && II.Tag == "Door")
                    { if (II.Bounds.IntersectsWith(hero.Bounds)) hero.Left += speed; }
                    Prover(II);

                }

            }
            if (goright)
            {
                //
                hero.Left += speed;
                foreach (Control II in this.Controls)
                {
                    if (II is Label && II.Tag == "wall")
                    { if (II.Bounds.IntersectsWith(hero.Bounds)) hero.Left -= speed; }
                    if (II is Label && II.Tag == "Door")
                    { if (II.Bounds.IntersectsWith(hero.Bounds)) hero.Left -= speed; }
                    Prover(II);
                }
            }
            if (goup)
            {
                //
                hero.Top -= speed;
                foreach (Control II in this.Controls)
                {
                    if (II is Label && II.Tag == "wall")
                    { if (II.Bounds.IntersectsWith(hero.Bounds)) hero.Top += speed; }
                    if (II is Label && II.Tag == "Door")
                    { if (II.Bounds.IntersectsWith(hero.Bounds)) hero.Top += speed; }
                    Prover(II);
                }
            }
            if (godown)
            {
                //
                hero.Top += speed;
                foreach (Control II in this.Controls)
                {
                    if (II is Label && II.Tag == "wall")
                    { if (II.Bounds.IntersectsWith(hero.Bounds)) hero.Top -= speed; }
                    if (II is Label && II.Tag == "Door")
                    { if (II.Bounds.IntersectsWith(hero.Bounds)) hero.Top -= speed; }
                    Prover(II);
                }
            }

            enemy.Left += enemy_sp;
            if (enemy.Bounds.IntersectsWith(hero.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Game Over");
                this.Close();
            }
                foreach (Control II in this.Controls)
            {
                if (II is Label && II.Tag == "wall")
                { if (II.Bounds.IntersectsWith(enemy.Bounds)) enemy_sp=-enemy_sp; }
                if (II is Label && II.Tag == "Door")
                { if (II.Bounds.IntersectsWith(enemy.Bounds)) enemy_sp = -enemy_sp; }
            }


                 if (hero.Bounds.IntersectsWith(Exit.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("You Win");
                this.Close();
            }


            enemy2.Left += enemy_sp2;
            if (enemy2.Bounds.IntersectsWith(hero.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Game Over");
                this.Close();
            }
            foreach (Control II in this.Controls)
            {
                if (II is Label && II.Tag == "wall")
                { if (II.Bounds.IntersectsWith(enemy2.Bounds)) enemy_sp2 = -enemy_sp2; }
                if (II is Label && II.Tag == "Door")
                { if (II.Bounds.IntersectsWith(enemy2.Bounds)) enemy_sp = -enemy_sp; }
            }


            if (hero.Bounds.IntersectsWith(Exit.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("You Win");
                this.Close();
            }




        }
         
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
           if (start) {
                switch (keyData)
                {
                    case Keys.A:
                        {
                            goleft =true;
                            //
                            break; }
                    case Keys.D:
                        {
                            goright = true;
                            //
                            break; }
                    case Keys.W:
                        {
                            goup=true;
                            //
                            break; }
                    case Keys.S:
                        {
                           godown= true;
                            //
                            break; }
                    default: return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            return true;
        }
         
        protected override bool ProcessKeyEventArgs(ref Message m)
        {
            //MessageBox.Show(m.Msg.ToString());
            if (m.Msg == WM_KEYUP)
            {
                switch (m.WParam.ToInt32())
                {
                    case (int)Keys.W:
                        goup = false;
                        break;
                    case (int)Keys.S:
                        godown = false;
                        break;
                    case (int)Keys.A:
                        goleft = false; 
                        break;
                    case (int)Keys.D:
                       goright=false;
                        break;
                }
            }

            return base.ProcessKeyEventArgs(ref m);
        }
        
        public  void Prover(Control II)
        {
            if (II is Label && II.Tag == "U")
            {
                if (II.Bounds.IntersectsWith(hero.Bounds))
                {
                    this.Controls.Remove(U as Control); button2.Visible = true;
                    button2.Text = "U";
                }
            }
            if (II is Label && II.Tag == "T")
            {
                if (II.Bounds.IntersectsWith(hero.Bounds))
                {
                    this.Controls.Remove(T as Control); button3.Visible = true;
                    button3.Text = "T";
                }
            }
            if (II is Label && II.Tag == "R")
            {
                if (II.Bounds.IntersectsWith(hero.Bounds))
                {
                    this.Controls.Remove(R as Control); button2.Visible = true;
                    button2.Text = "R";
                }
            }
            if (II is Label && II.Tag == "E")
            {
                if (II.Bounds.IntersectsWith(hero.Bounds))
                {
                    this.Controls.Remove(E as Control); button3.Visible = true;
                    button3.Text = "E";
                }
            }
            if (II is Label && II.Tag == "G")
            {
                if (II.Bounds.IntersectsWith(hero.Bounds))
                {
                    this.Controls.Remove(G as Control); button2.Visible = true;
                    button2.Text = "G";
                }
            }
            if (II is Label && II.Tag == "O")
            {
                if (II.Bounds.IntersectsWith(hero.Bounds))
                {
                    this.Controls.Remove(O as Control); button3.Visible = true;
                    button3.Text = "O";
                }
            }

        }

    }


    /*
    class Hero
    {
        public static int Napravlen;
        public static Point Position_hero;
        //(int x, int y)
        public static void Moving()
        {
            switch (Napravlen)
            {
                case 8:
                    {
                        Position_hero.Y -= 20;
                        Napravlen = 0;
                        break;
                    }
                case 5:
                    {
                        Position_hero.Y += 20;
                        Napravlen = 0;
                        break;
                    }
                case 4:
                    {
                        Position_hero.X -= 20;
                        Napravlen = 0;
                        break;
                    }
                case 6:
                    {
                        Position_hero.X += 20;
                        Napravlen = 0;
                        break;
                    }
                default: break;
            }
        }
        public Hero(Point A)
        {
            Napravlen = 0;
            Position_hero.X = A.X;
            Position_hero.Y = A.Y;
        }
    }


    

    */
}
