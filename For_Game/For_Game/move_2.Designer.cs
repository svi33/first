namespace For_Game
{
    partial class move_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(move_2));
            this.ground = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.hero = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.shadow = new System.Windows.Forms.PictureBox();
            this.L_wall = new System.Windows.Forms.PictureBox();
            this.R_wall = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_wall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_wall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ground.Location = new System.Drawing.Point(0, 531);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(788, 30);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            this.ground.Tag = "ground";
            this.ground.Visible = false;
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.White;
            this.door.Image = ((System.Drawing.Image)(resources.GetObject("door.Image")));
            this.door.Location = new System.Drawing.Point(35, 1);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(107, 100);
            this.door.TabIndex = 1;
            this.door.TabStop = false;
            this.door.Tag = "door";
            this.door.Visible = false;
            // 
            // hero
            // 
            this.hero.Image = ((System.Drawing.Image)(resources.GetObject("hero.Image")));
            this.hero.Location = new System.Drawing.Point(162, 374);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(43, 43);
            this.hero.TabIndex = 2;
            this.hero.TabStop = false;
            this.hero.Tag = "hero";
            this.hero.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(211, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 203);
            this.button1.TabIndex = 3;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(402, 424);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 37);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "ground";
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(35, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 36);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "ground";
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox3.Location = new System.Drawing.Point(402, 234);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(276, 38);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "ground";
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox4.Location = new System.Drawing.Point(249, 117);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(230, 36);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "ground";
            this.pictureBox4.Visible = false;
            // 
            // shadow
            // 
            this.shadow.Image = ((System.Drawing.Image)(resources.GetObject("shadow.Image")));
            this.shadow.Location = new System.Drawing.Point(371, 293);
            this.shadow.Name = "shadow";
            this.shadow.Size = new System.Drawing.Size(43, 43);
            this.shadow.TabIndex = 8;
            this.shadow.TabStop = false;
            this.shadow.Tag = "shadow";
            this.shadow.Visible = false;
            // 
            // L_wall
            // 
            this.L_wall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.L_wall.Location = new System.Drawing.Point(0, 1);
            this.L_wall.Name = "L_wall";
            this.L_wall.Size = new System.Drawing.Size(35, 548);
            this.L_wall.TabIndex = 9;
            this.L_wall.TabStop = false;
            this.L_wall.Tag = "wall";
            this.L_wall.Visible = false;
            // 
            // R_wall
            // 
            this.R_wall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.R_wall.Location = new System.Drawing.Point(753, -24);
            this.R_wall.Name = "R_wall";
            this.R_wall.Size = new System.Drawing.Size(35, 573);
            this.R_wall.TabIndex = 10;
            this.R_wall.TabStop = false;
            this.R_wall.Tag = "wall";
            this.R_wall.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox5.Location = new System.Drawing.Point(137, -24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(619, 36);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "ground";
            this.pictureBox5.Visible = false;
            // 
            // move_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.R_wall);
            this.Controls.Add(this.L_wall);
            this.Controls.Add(this.shadow);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.door);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.hero);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "move_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_wall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_wall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox shadow;
        private System.Windows.Forms.PictureBox L_wall;
        private System.Windows.Forms.PictureBox R_wall;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

