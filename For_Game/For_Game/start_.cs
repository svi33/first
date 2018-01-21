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
        //List<Form> L_F = new List<Form>();
        List<string> Levels = new List<string>();
        //enum lvl { level_1, lvl2, lvl3, lvl4, lvl5, lvl6, lvl7 };
        int num_level = 0;
        string nameUser = "";
        bool UserToBase = false;
        private SQLiteConnection connect;

        public start_()
        {
            InitializeComponent();
            textBox1.Validating += TextBox1_Validating;
        }
    public static void SaveUserToBase(string name,int num)
        {
            SQLiteConnection connecty = new SQLiteConnection("Data Source=For_Game.db;version=3");
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
            SQLiteConnection connecty = new SQLiteConnection("Data Source=For_Game.db;version=3");
            connecty.Open();
            SQLiteCommand command1 = connecty.CreateCommand();
            command1.CommandText = "Update UserGame Set n_file=@num_level where name=@name";
            command1.Parameters.Add("@name", DbType.String).Value = name;
            command1.Parameters.Add("@n_file", DbType.Int32).Value = n_LVL;
           
            connecty.Close();
        }
        private void start__Load(object sender, EventArgs e)
        {
            connect = new SQLiteConnection("Data Source=For_Game.db;version=3");
            connect.Open();
            string lvl_1 = "level 1";
            Levels.Add(lvl_1);
            comboBox1.DataSource = null;
            comboBox1.DataSource = Levels;
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
                string lvl = "level ";
                temp = temp.Substring(0, 1).ToUpper() + (temp.Length > 1 ? temp.Substring(1) : "");
                textBox1.Text = temp;
                nameUser = temp;
                SQLiteCommand command = connect.CreateCommand();
                command.CommandText = "SELECT n_file FROM UserGame WHERE name=@name";

                command.Parameters.Add("@name", DbType.String).Value = nameUser;
                SQLiteDataReader sqlRead = command.ExecuteReader();
                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {
                        num_level = Convert.ToInt32(sqlRead["n_file"]);
                    }
                    UserToBase = true;
                   for(int i=1;i<num_level;i++)
                    {
                        string tem=lvl + i.ToString();
                        Levels.Add(tem);
                    }
                 
                    comboBox1.DataSource = null;
                    comboBox1.DataSource = Levels;
                }
                else
                {
                    num_level = 1;
                    UserToBase = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "") { MessageBox.Show("Введите имя"); return; }
            if (textBox1.Text.Length<2) { MessageBox.Show("Введите нормальное имя"); return; }


            label1.Visible = false;
            textBox1.ReadOnly = true;
            string l=comboBox1.Text;
           
            if (l.Equals(Levels[0]))
            {
                End_Win.H_Name = textBox1.Text;
                End_Win.Flag = false;
                test_1 Lev_1 = new test_1 ();
                this.Visible = false;
                Lev_1.ShowDialog();
                this.Visible = true;
                label2.Visible = false;
                if (End_Win.Flag)
                {
                        ++num_level;
                      
                     MessageBox.Show("Хорошо! Продолжаем.\n Доступен новый уровень! \n Let's go!");
                    if (Levels.Count == 1)
                    {
                        string lvl_2 = "level 2"; Levels.Add(lvl_2);
                        comboBox1.DataSource = null;
                        comboBox1.DataSource = Levels;
                        label3.Visible = true;
                    }
                 }
            }
          
            else if (l.Equals(Levels[1]))
            {
                label3.Visible = false;
                End_Win.Flag = false;
                Form1 Lev_2 = new Form1();
                this.Visible = false;
                Lev_2.ShowDialog();              
                this.Visible = true;
                if (End_Win.Flag)
                {
                        ++num_level;
                       
                        MessageBox.Show("Хорошо!\n Доступен новый уровень! \n Let's go!");
                    if (Levels.Count == 2)
                    {
                        string lvl_3 = "level 3"; Levels.Add(lvl_3);
                        comboBox1.DataSource = null;
                        comboBox1.DataSource = Levels;
                        label3.Visible = true;
                    }
                }
            }
          
            else if (l.Equals(Levels[2]))
            {
                label3.Visible = false;
                End_Win.Flag = false;
                test_2 Lev_3 = new test_2();
                this.Visible = false;
                Lev_3.ShowDialog();
                this.Visible = true;
                if (End_Win.Flag)
                {
                        ++num_level;
                       
                        MessageBox.Show("Good!\n Доступен новый уровень! \n Let's go!");
                    if (Levels.Count == 3)
                    {
                        string lvl_4 = "level 4"; Levels.Add(lvl_4);
                        comboBox1.DataSource = null;
                        comboBox1.DataSource = Levels;
                        label3.Visible = true;
                    }
                } 
            }
           
            
          else  if (l.Equals(Levels[3]))
            {
                label3.Visible = false;
                End_Win.Flag = false;
                move_1 Lev_4 = new move_1();
                this.Visible = false;
                Lev_4.ShowDialog();
                this.Visible = true;
                if (End_Win.Flag)
                {
                        ++num_level;
                        
                        MessageBox.Show("Good!\n Доступен новый уровень! \n Let's go!");
                    if (Levels.Count == 4)
                    {
                        string lvl_5 = "level 5"; Levels.Add(lvl_5);
                        comboBox1.DataSource = null;
                        comboBox1.DataSource = Levels;
                        label3.Visible = true;
                    }
                }
            }
               
                /////////////////////////////////////
                else if (l.Equals(Levels[5]))
            {
                label3.Visible = false;
                End_Win.Flag = false;
                // move_1 Lev_4 = new move_1();
                //  this.Visible = false;
                // Lev_4.ShowDialog();
                // this.Visible = true;
                MessageBox.Show("Уровень в разрботке.\n Спасибо за проявленный интерес. ");
                if (End_Win.Flag)
                {
                        ++num_level;
                       
                        MessageBox.Show("Good!\n Доступен новый уровень! \n Let's go!");
                    if (Levels.Count == 5)
                    {
                        string lvl_6 = "level 6"; Levels.Add(lvl_6);
                        comboBox1.DataSource = null;
                        comboBox1.DataSource = Levels;
                        label3.Visible = true;
                    }
                }
            }
            return;
        }

        private void start__FormClosing(object sender, FormClosingEventArgs e)
        {
            if(UserToBase)
            {
                UpdateUserToBase(nameUser, num_level);
            }
            else
            {
                SaveUserToBase(nameUser, num_level);
            }
        }
    }
}
