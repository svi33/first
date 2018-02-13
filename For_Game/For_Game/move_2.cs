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
    public partial class move_2 : Form
    {
        private static int WM_KEYUP = 0x0101;
        bool jumping, fire, goleft, goright=false;
        bool start = false;
        bool fly = true;
        int glob_sp = 33;
        int jumpspeed = 0;
        int m_speed = 8;
        int enemy_sp = 9;
        int enemy_sp2 = 12;
        int force = 9;

        public move_2()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = glob_sp;
            
            foreach (Control II in this.Controls)
            {
                II.Visible = true;
            }
            timer1.Start();
            button1.Visible = false;
            shadow.Visible = false;
            start = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (fly)
            {
                hero.Top += force;
                hero.Top += jumpspeed;
                if (System.Math.Abs(jumpspeed) < force)
                {
                    foreach (Control II in this.Controls)
                    {
                        if (II is PictureBox && II.Tag == "ground")
                        {
                            if (II.Bounds.IntersectsWith(hero.Bounds))
                            { hero.Top = hero.Top - force; fly = false; }
                        }
                    }
                }
                else
                {
                    foreach (Control II in this.Controls)
                    {
                        if (II is PictureBox && II.Tag == "ground")
                        {
                            if (II.Bounds.IntersectsWith(hero.Bounds))
                            { hero.Top = hero.Top + hero.Height; jumpspeed = 0; }
                        }
                    }
                }
            }
            else
            {
                hero.Top += jumpspeed;
                shadow.Top = hero.Top;
                shadow.Left = hero.Left;
                shadow.Top += force;
                fly = true;
                foreach (Control II in this.Controls)
                {
                    if (II is PictureBox && II.Tag == "ground")
                    {
                        if (II.Bounds.IntersectsWith(shadow.Bounds))
                        { fly=false; }
                    }
                }
                
            }
            if (jumpspeed < 0) jumpspeed++;
            
            if (goleft)
            {
                hero.Left -= m_speed;
                foreach (Control II in this.Controls)
                {
                    if (II is PictureBox && II.Tag == "wall")
                    { if (II.Bounds.IntersectsWith(hero.Bounds)) hero.Left += m_speed; }
                }

            }
            if (goright)
            {
                hero.Left += m_speed;
                foreach (Control II in this.Controls)
                {
                    if (II is PictureBox && II.Tag == "wall")
                    { if (II.Bounds.IntersectsWith(hero.Bounds)) hero.Left -= m_speed; }
                }
            }
            if (jumping)
            {
                if (!fly) { jumpspeed = -27; }
                
                if (jumpspeed < 0) jumpspeed++;
               
            }

           


            if (hero.Bounds.IntersectsWith(door.Bounds))
            {
                timer1.Stop();
                // End_Win.Flag = true;
                End_Win.Flag = true;
                MessageBox.Show("You Win !!!");
                this.Close();
            }
            foreach (Control II in this.Controls)
            {
                if (II is PictureBox && II.Tag == "ground")
                {
                    if (II.Bounds.IntersectsWith(hero.Bounds))
                    { hero.Top = hero.Top - force;  }
                }
            }
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
                    case Keys.W:
                        {
                            jumping = true;
                            //
                            break;
                        }
                    case Keys.Space:
                        {
                            fire = true;
                            //
                            break;
                        }
                    default: return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            return true;
        }

        protected override bool ProcessKeyEventArgs(ref Message m)
        {
            if (m.Msg == WM_KEYUP)
            {
                switch (m.WParam.ToInt32())
                {
                    case (int)Keys.W:
                        jumping = false;
                        break;
                    case (int)Keys.Space:
                        fire = false;
                        break;
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
