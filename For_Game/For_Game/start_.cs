using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Game
{
    public partial class start_ : Form
    {

      static  SQLiteConnection connecty;
       static int num_level = 0;
        static int Adm_level=0;
        string nameUser = "";
        bool UserToBase = false;
         SQLiteConnection connect;
     
        public start_()
        {
            InitializeComponent();
            textBox1.Validating += TextBox1_Validating;
            connecty = new SQLiteConnection("Data Source=For_Game.db;version=3");
        }
        

        private void MyLabel_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            GomyLevel(Convert.ToInt32(lbl.Tag));
        }
        
        private Label CreateLabel(Point poz)
        {
            Label lb = new Label();
            lb.BorderStyle = BorderStyle.Fixed3D;
            lb.FlatStyle = FlatStyle.Flat;
            lb.Width = 70;
            lb.Height =30;
            lb.Text = "level ";
            lb.BackColor = Color.Gold;
           // lb.Image = Properties.Resources.lock_1_1;
            lb.Location = poz;
            lb.Click += MyLabel_Click;
            return lb;
        }
        
        public static void SaveUserToBase(string name,int num)
        {
             connecty.Open();
            SQLiteCommand command1 = connecty.CreateCommand();
            command1.CommandText = "INSERT INTO UserGame ( name,n_file)values (@name,@n_file)";
            command1.Parameters.Add("@n_file", DbType.Int32).Value = num;
            command1.Parameters.Add("@name", DbType.String).Value = name;
            command1.ExecuteNonQuery();
            connecty.Close();
        }

        public static void UpdateUserToBase(string name,int n_LVL)
        {
          connecty.Open();
            SQLiteCommand command2 = connecty.CreateCommand();
            command2.CommandText = "Update UserGame Set n_file=@n_file where name=@name";
            command2.Parameters.Add("@n_file", DbType.Int32).Value = n_LVL;
            command2.Parameters.Add("@name", DbType.String).Value = name;
            command2.ExecuteNonQuery(); 
            connecty.Close();
        }

        public bool UserBase(string name)
        {
            SQLiteCommand command = connect.CreateCommand();
            if(name!="Admin")
            { 
            command.CommandText = "SELECT n_file FROM UserGame WHERE name=@name";
 
            command.Parameters.Add("@name", DbType.String).Value = name;
            SQLiteDataReader sqlRead = command.ExecuteReader();
            if (sqlRead.HasRows)
            {
                while (sqlRead.Read())
                {
                    num_level = Convert.ToInt32(sqlRead["n_file"]);

                }
                    sqlRead.Close();
                return true;
            }else
                return false;
            }
            else {
                command.CommandText = "SELECT Max(n_file) FROM UserGame ";
              
               Adm_level = Convert.ToInt32(command.ExecuteScalar()); 
                return true;
            }
        }

        private void start__Load(object sender, EventArgs e)
        {
            connect = new SQLiteConnection("Data Source=For_Game.db;version=3");
            connect.Open();
        }

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Не указано имя!");
            }
            else if (textBox1.Text.Length < 2)
            {
                errorProvider1.SetError(textBox1, "Слишком короткое имя!");
                string temp = textBox1.Text;
                temp = temp.Substring(0, 1).ToUpper() + (temp.Length > 1 ? temp.Substring(1) : "");
                textBox1.Text = temp;
            }
            else
            {
                errorProvider1.Clear();
                string temp = textBox1.Text;
                temp = temp.Substring(0, 1).ToUpper() + (temp.Length > 1 ? temp.Substring(1) : "");
                textBox1.Text = temp;
                nameUser = temp;
                    UserToBase = UserBase(nameUser);
              
            }
        }

        private void start__FormClosing(object sender, FormClosingEventArgs e)
        {
            if(UserToBase&&nameUser!="Admin")
            {
                UpdateUserToBase(nameUser, num_level);
            }
            else if(nameUser != "Admin")
            {
                SaveUserToBase(nameUser, num_level);
            }
        }

        private void NGame_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "") { MessageBox.Show("Введите имя"); return; }
            if (textBox1.Text.Length < 2) { MessageBox.Show("Введите нормальное имя"); return; }


            label1.Visible = false;
            textBox1.ReadOnly = true;
            num_level = 0;
            GomyLevel(num_level);
        }
      
        public void myLevel(int levl)
        {
            if (nameUser == "Admin") levl = Adm_level;
            Point poz = new Point();
            int x = panel2.Location.X;
            int y = panel2.Location.Y;

            for (int i = 0; i <= levl; i++)
            {
                Label lb;
                lb = CreateLabel(poz);
                lb.Tag = i;
                lb.Text += (i + 1).ToString();
                panel2.Controls.Add(lb);
                poz.X += lb.Width + 2;

                if (poz.X > panel2.Width - lb.Width)
                {
                    poz.X = 0;
                    
                    poz.Y += lb.Height + 2;
                }
            }
        }

        public void myDeleteLabel()
        {
            for (int i = this.panel2.Controls.Count - 1; i >= 0; i--)
            {
                Control c = this.panel2.Controls[i];
                if (c is Label)
                {
                        this.panel2.Controls.Remove(c);
                }
            }
        }

        public void GomyLevel(int r)
        {
            if (r == 0)
            {
                End_Win.H_Name = textBox1.Text;
                End_Win.Flag = false;
                test_1 Lev_1 = new test_1();
                Visible = false;
                Lev_1.ShowDialog();
                Visible = true;
                label2.Visible = false;
               // ++num_level;
                if (End_Win.Flag)
                {
                    myDeleteLabel();
                    ++r;
                    myLevel(r);
                    num_level = 1;
                    MessageBox.Show("Хорошо! Продолжаем.\n Доступен новый уровень! \n Let's go!");
                }
            }
            if (r == 1)
            {
              
                End_Win.Flag = false;
                move_2 Lev_2 = new move_2(); //new Form1();
                Visible = false;
                Lev_2.ShowDialog();
                Visible = true;
              //  ++num_level;
                if (End_Win.Flag)
                {
                    myDeleteLabel();
                    ++r;
                    myLevel(r);
                    num_level = 2;
                    MessageBox.Show("Хорошо!\n Доступен новый уровень! \n Let's go!");
                }
            }
             if (r == 2)
            {
               
                End_Win.Flag = false;
                // test_2 Lev_3 = new test_2();
                frm5 Lev_3 = new frm5();
                Visible = false;
                Lev_3.ShowDialog();
                Visible = true;
               // ++num_level;
                if (End_Win.Flag)
                {

                    myDeleteLabel();
                    ++r;
                    myLevel(r);
                    num_level = 3;
                    MessageBox.Show("Good!\n Доступен новый уровень! \n Let's go!");
                }
            }
             if (r == 3)
            {
              
                End_Win.Flag = false;
                // move_1 Lev_4 = new move_1();
                Form1 Lev_4 = new Form1();
                Visible = false;
                Lev_4.ShowDialog();
                Visible = true;
              //  ++num_level;
                if (End_Win.Flag)
                {

                    myDeleteLabel();
                    ++r;
                    myLevel(r);
                    num_level = 4;
                    MessageBox.Show("Good!\n Доступен новый уровень! \n Let's go!");
                   
                }
            }
            if (r == 4)
            {

                End_Win.Flag = false;
                //frm5 Lev_5 = new frm5();
                test_2 Lev_5 = new test_2();
                Visible = false;
                Lev_5.ShowDialog();
                Visible = true;
              //  ++num_level;
                if (End_Win.Flag)
                {

                    myDeleteLabel();
                    ++r;
                    myLevel(r);
                    num_level = 5;
                    MessageBox.Show("Good!\n Доступен новый уровень! \n Let's go!");

                }
            }
            /////////////////////////////////////
            if (r == 5)
            { 
               
                End_Win.Flag = false;
                move_1 Lev_6 = new move_1();
                // move_1 Lev_4 = new move_1();
                this.Visible = false;
                Lev_6.ShowDialog();
                this.Visible = true;
                //++num_level;
               // MessageBox.Show("Уровень в разрaботке.\n Спасибо за проявленный интерес. ");
                if (End_Win.Flag)
                {

                    myDeleteLabel();
                    ++r;
                    myLevel(r);
                    num_level = 6;
                    MessageBox.Show("Good!\n Доступен новый уровень! \n Let's go!");
                    
                }
            }
            if (r == 6)
            {

                End_Win.Flag = false;

                // move_1 Lev_4 = new move_1();
                //  this.Visible = false;
                // Lev_4.ShowDialog();
                // this.Visible = true;
                //++num_level;
                MessageBox.Show("Уровень в разрaботке.\n Спасибо за проявленный интерес. ");
                if (End_Win.Flag)
                {

                    myDeleteLabel();
                    ++r;
                    myLevel(r);
                    num_level = 7;
                    MessageBox.Show("Good!\n Доступен новый уровень! \n Let's go!");

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;

            if (UserToBase == true)
            {
                myLevel(num_level);
            }
        }
    }
}
////
