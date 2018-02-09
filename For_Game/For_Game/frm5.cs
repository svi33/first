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
   
    public partial class frm5 : Form
    {
       
        public frm5()
        {
            InitializeComponent();
            
        }
        //End_Win.Flag = true;
        //            this.Close();
         public bool myGo(int a)
        {
            if (a==10)
            {
            End_Win.Flag = true;
                this.Close();
            }
            if(a<9)return false;
            else
            
                
                return true;
            
            
        }
   // bool lb_1Down = false;
    int isUp = 0;
        Point lb_1poz;
       // Point lb_2poz;
        object a;
        private void lb_1_MouseMove(object sender, MouseEventArgs e)
        {
            //Control c = sender as Control;
            //if (lb_1Down)//lb_1Down
            //{
            //    c.Location = this.PointToClient(Control.MousePosition);
            //}
        }

        private void lb_1_MouseDown(object sender, MouseEventArgs e)
       {
        //    lb_1poz = lb_1.Location;
        //    lb_2poz = lb1.Location;
        //     if (!(lb_1poz==lb_2poz))//isUp!=1
        //    lb_1Down = true;
        }

        private void lb_1_MouseUp(object sender, MouseEventArgs e)
        {   
        //    if (lb_1.Location.X == lb1.Location.X  && lb_1.Location.Y == lb1.Location.Y  && lb_1.Tag == lb1.Tag)
        //    {
        //        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //        pictureBox1.Image = Properties.Resources.lock_1_1;
        //       isUp = 1;
                
        //    }
        //    else
        //    {
        //        //lb_1.Location = new Point(lb_1.Location.X + 10, lb1.Location.Y + 10);
        //        lb_1.Location = lb_1poz;
               
        //    }
        ////}
        ////    else
        ////    {
        ////        //lb_1.Location = new Point(lb_1.Location.X + 10, lb1.Location.Y + 10);
        ////        lb_1.Location = lb_1poz;
        ////    }
        //    lb_1Down = false; 
        }

        private void lb_6_Click(object sender, EventArgs e)
        {

        }

        private void lb_2_MouseDown(object sender, MouseEventArgs e)
        {
            //lb_1poz = lb_2.Location;
            //lb_2poz = lb2.Location;
            //if (!(lb_1poz == lb_2poz))//isUp!=1
            //    lb_1Down = true;
        }

        private void lb_2_MouseMove(object sender, MouseEventArgs e)
        {
            //Control c = sender as Control;
            //if (lb_1Down)//lb_1Down
            //{
            //    c.Location = this.PointToClient(Control.MousePosition);
            //}
        }

        private void lb_2_MouseUp(object sender, MouseEventArgs e)
        {
            //int a = lb_2.Width;
            //if (lb_2.Location.X+a == lb2.Location.X && lb_2.Location.Y == lb2.Location.Y && lb_2.Tag == lb2.Tag)
            //{
            //    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            //    pictureBox2.Image = Properties.Resources.lock_1_1;
            //   // isUp = 1;

            //}
            //else
            //{
            //    //lb_1.Location = new Point(lb_1.Location.X + 10, lb1.Location.Y + 10);
            //    lb_2.Location = lb_1poz;

            //}
            
            //lb_1Down = false;
        }

        private void lb_1_Click(object sender, EventArgs e)
        {
            //lb_1poz = lb_1.Location;
            a = lb1.Tag;
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            if(a==lb1.Tag)
            {
                lb_1.Location= lb1.Location;
                isUp++;
            }
            myGo(isUp);
        }

        private void lb_2_Click(object sender, EventArgs e)
        { 
            a = lb2.Tag;
        }

        private void lb2_Click(object sender, EventArgs e)
        {
           if (a == lb2.Tag)
            {
                lb_2.Location = lb2.Location;
                isUp++;
            }
            myGo(isUp);
        }

        private void lb_3_Click(object sender, EventArgs e)
        {
            a = lb3.Tag;
        }

        private void lb3_Click(object sender, EventArgs e)
        {
            if (a == lb3.Tag)
            {
                lb_3.Location = lb3.Location;
                isUp++;
            }
            myGo(isUp);
        }

        private void lb_4_Click(object sender, EventArgs e)
        {
            a = lb4.Tag;
        }

        private void lb4_Click(object sender, EventArgs e)
        {
            if (a == lb4.Tag)
            {
                lb_4.Location = lb4.Location;
                isUp++;
            }
            myGo(isUp);
        }

        private void lb_5_Click(object sender, EventArgs e)
        {
            a = lb5.Tag;
        }

        private void lb5_Click(object sender, EventArgs e)
        {
            if (a == lb5.Tag)
            {
                lb_5.Location = lb5.Location;
                isUp++;
            }
            myGo(isUp);
        }

        private void lb_6_Click_1(object sender, EventArgs e)
        {
            a = lb6.Tag;
        }

        private void lb6_Click(object sender, EventArgs e)
        {
            if (a == lb6.Tag)
            {
                lb_6.Location = lb6.Location;
                isUp++;
            }
            myGo(isUp);
        }

        private void lb_7_Click(object sender, EventArgs e)
        {
            a = lb7.Tag;
        }

        private void lb7_Click(object sender, EventArgs e)
        {
            if (a == lb7.Tag)
            {
                lb_7.Location = lb7.Location;
                isUp++;
            }
            myGo(isUp);
        }

        private void lb_8_Click(object sender, EventArgs e)
        {
            a = lb8.Tag;
        }

        private void lb8_Click(object sender, EventArgs e)
        {
            if (a == lb8.Tag)
            {
                lb_8.Location = lb8.Location;
                isUp++;
            }
            myGo(isUp);
        }

        private void lb_9_Click(object sender, EventArgs e)
        {
            a = lb9.Tag;
        }

        private void lb9_Click(object sender, EventArgs e)
        {
            if (a == lb9.Tag)
            {
                lb_9.Location = lb9.Location;
                isUp++;
            }
            myGo(isUp);
        }

        private void lb_0_Click(object sender, EventArgs e)
        {
            a = lb0.Tag;
        }

        private void lb0_Click(object sender, EventArgs e)
        {
            if (a == lb0.Tag)
            {
                lb_0.Location = lb0.Location;
                isUp++;
            }
            myGo(isUp);
        }
    }
}
