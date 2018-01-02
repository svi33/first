namespace For_Game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.hero = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.door4 = new System.Windows.Forms.Label();
            this.door3 = new System.Windows.Forms.Label();
            this.door1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.door2 = new System.Windows.Forms.Label();
            this.U = new System.Windows.Forms.Label();
            this.U_ = new System.Windows.Forms.Label();
            this.T_ = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.R_ = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.E_ = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.O = new System.Windows.Forms.Label();
            this.G_ = new System.Windows.Forms.Label();
            this.O_ = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // hero
            // 
            this.hero.Image = ((System.Drawing.Image)(resources.GetObject("hero.Image")));
            this.hero.Location = new System.Drawing.Point(30, 428);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(43, 43);
            this.hero.TabIndex = 1;
            this.hero.TabStop = false;
            this.hero.Tag = "hero";
            this.hero.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(1, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 23);
            this.label1.TabIndex = 2;
            this.label1.Tag = "wall";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(1, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(773, 23);
            this.label2.TabIndex = 3;
            this.label2.Tag = "wall";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(751, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 506);
            this.label3.TabIndex = 4;
            this.label3.Tag = "wall";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(1, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 506);
            this.label4.TabIndex = 5;
            this.label4.Tag = "wall";
            this.label4.Visible = false;
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(662, 22);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(83, 82);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Exit.TabIndex = 6;
            this.Exit.TabStop = false;
            this.Exit.Tag = "Exit";
            this.Exit.Visible = false;
            // 
            // enemy
            // 
            this.enemy.Image = ((System.Drawing.Image)(resources.GetObject("enemy.Image")));
            this.enemy.Location = new System.Drawing.Point(700, 325);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(45, 45);
            this.enemy.TabIndex = 7;
            this.enemy.TabStop = false;
            this.enemy.Tag = "enemy";
            this.enemy.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(12, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 23);
            this.label5.TabIndex = 8;
            this.label5.Tag = "wall";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(493, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 23);
            this.label6.TabIndex = 9;
            this.label6.Tag = "wall";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 23);
            this.label7.TabIndex = 10;
            this.label7.Tag = "wall";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(493, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 23);
            this.label8.TabIndex = 11;
            this.label8.Tag = "wall";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(12, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 23);
            this.label9.TabIndex = 12;
            this.label9.Tag = "wall";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(493, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 23);
            this.label10.TabIndex = 13;
            this.label10.Tag = "wall";
            this.label10.Visible = false;
            // 
            // door4
            // 
            this.door4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.door4.Location = new System.Drawing.Point(278, 107);
            this.door4.Name = "door4";
            this.door4.Size = new System.Drawing.Size(217, 23);
            this.door4.TabIndex = 14;
            this.door4.Tag = "Door";
            this.door4.Visible = false;
            // 
            // door3
            // 
            this.door3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.door3.Location = new System.Drawing.Point(278, 239);
            this.door3.Name = "door3";
            this.door3.Size = new System.Drawing.Size(217, 23);
            this.door3.TabIndex = 15;
            this.door3.Tag = "Door";
            this.door3.Visible = false;
            // 
            // door1
            // 
            this.door1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.door1.Location = new System.Drawing.Point(278, 373);
            this.door1.Name = "door1";
            this.door1.Size = new System.Drawing.Size(217, 23);
            this.door1.TabIndex = 16;
            this.door1.Tag = "Door";
            this.door1.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(496, 400);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 13);
            this.label14.TabIndex = 17;
            this.label14.Tag = "walls";
            this.label14.Text = "WHO LET\'S THE DOG O";
            this.label14.Visible = false;
            // 
            // door2
            // 
            this.door2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.door2.Location = new System.Drawing.Point(496, 253);
            this.door2.Name = "door2";
            this.door2.Size = new System.Drawing.Size(25, 120);
            this.door2.TabIndex = 18;
            this.door2.Tag = "Door";
            this.door2.Visible = false;
            // 
            // U
            // 
            this.U.AutoSize = true;
            this.U.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.U.Location = new System.Drawing.Point(506, 479);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(15, 13);
            this.U.TabIndex = 19;
            this.U.Tag = "U";
            this.U.Text = "U";
            this.U.Visible = false;
            // 
            // U_
            // 
            this.U_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.U_.Location = new System.Drawing.Point(638, 400);
            this.U_.Name = "U_";
            this.U_.Size = new System.Drawing.Size(15, 13);
            this.U_.TabIndex = 20;
            this.U_.Tag = "U_";
            this.U_.Visible = false;
            // 
            // T_
            // 
            this.T_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.T_.Location = new System.Drawing.Point(670, 400);
            this.T_.Name = "T_";
            this.T_.Size = new System.Drawing.Size(15, 13);
            this.T_.TabIndex = 21;
            this.T_.Tag = "T_";
            this.T_.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Location = new System.Drawing.Point(708, 400);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 22;
            this.label16.Tag = "walls";
            this.label16.Text = "?";
            this.label16.Visible = false;
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.T.Location = new System.Drawing.Point(218, 479);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(14, 13);
            this.T.TabIndex = 23;
            this.T.Tag = "T";
            this.T.Text = "T";
            this.T.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(781, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 47);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(839, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 47);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button3_MouseClick);
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(700, 191);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(45, 45);
            this.enemy2.TabIndex = 26;
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "enemy";
            this.enemy2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(527, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 27;
            this.label11.Tag = "walls";
            this.label11.Text = "HEAR IS HE";
            this.label11.Visible = false;
            // 
            // R_
            // 
            this.R_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.R_.Location = new System.Drawing.Point(610, 271);
            this.R_.Name = "R_";
            this.R_.Size = new System.Drawing.Size(15, 13);
            this.R_.TabIndex = 28;
            this.R_.Tag = "R_";
            this.R_.Visible = false;
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.R.Location = new System.Drawing.Point(218, 344);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(15, 13);
            this.R.TabIndex = 29;
            this.R.Tag = "R";
            this.R.Text = "R";
            this.R.Visible = false;
            // 
            // E_
            // 
            this.E_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.E_.Location = new System.Drawing.Point(638, 271);
            this.E_.Name = "E_";
            this.E_.Size = new System.Drawing.Size(15, 13);
            this.E_.TabIndex = 30;
            this.E_.Tag = "E_";
            this.E_.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(675, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 31;
            this.label12.Tag = "walls";
            this.label12.Text = "!";
            this.label12.Visible = false;
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.E.Location = new System.Drawing.Point(539, 344);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(14, 13);
            this.E.TabIndex = 32;
            this.E.Tag = "E";
            this.E.Text = "E";
            this.E.Visible = false;
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.G.Location = new System.Drawing.Point(218, 206);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(15, 13);
            this.G.TabIndex = 33;
            this.G.Tag = "G";
            this.G.Text = "G";
            this.G.Visible = false;
            // 
            // O
            // 
            this.O.AutoSize = true;
            this.O.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.O.Location = new System.Drawing.Point(515, 206);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(15, 13);
            this.O.TabIndex = 34;
            this.O.Tag = "O";
            this.O.Text = "O";
            this.O.Visible = false;
            // 
            // G_
            // 
            this.G_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.G_.Location = new System.Drawing.Point(538, 139);
            this.G_.Name = "G_";
            this.G_.Size = new System.Drawing.Size(15, 13);
            this.G_.TabIndex = 35;
            this.G_.Tag = "G__";
            this.G_.Visible = false;
            // 
            // O_
            // 
            this.O_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.O_.Location = new System.Drawing.Point(580, 139);
            this.O_.Name = "O_";
            this.O_.Size = new System.Drawing.Size(15, 13);
            this.O_.TabIndex = 36;
            this.O_.Tag = "O_";
            this.O_.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(615, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 37;
            this.label13.Tag = "walls";
            this.label13.Text = "!";
            this.label13.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(643, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 38;
            this.label15.Tag = "walls";
            this.label15.Text = "!";
            this.label15.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.Location = new System.Drawing.Point(670, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 13);
            this.label17.TabIndex = 39;
            this.label17.Tag = "walls";
            this.label17.Text = "!";
            this.label17.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(901, 524);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.O_);
            this.Controls.Add(this.G_);
            this.Controls.Add(this.O);
            this.Controls.Add(this.G);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.E);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.E_);
            this.Controls.Add(this.R);
            this.Controls.Add(this.R_);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.T);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.T_);
            this.Controls.Add(this.U_);
            this.Controls.Add(this.U);
            this.Controls.Add(this.door2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.door1);
            this.Controls.Add(this.door3);
            this.Controls.Add(this.door4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hero);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label door4;
        private System.Windows.Forms.Label door3;
        private System.Windows.Forms.Label door1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label door2;
        private System.Windows.Forms.Label U;
        private System.Windows.Forms.Label U_;
        private System.Windows.Forms.Label T_;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label R_;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label E_;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Label O;
        private System.Windows.Forms.Label G_;
        private System.Windows.Forms.Label O_;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
    }
}

