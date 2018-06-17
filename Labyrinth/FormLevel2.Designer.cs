namespace Labyrinth2D
{
    partial class FormLevel2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_finish = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_key = new System.Windows.Forms.Label();
            this.label_door = new System.Windows.Forms.Label();
            this.label_wall2 = new System.Windows.Forms.Label();
            this.label_wall1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 270);
            this.label6.TabIndex = 15;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Green;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(542, 11);
            this.label5.TabIndex = 14;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(542, 11);
            this.label4.TabIndex = 13;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 11);
            this.label3.TabIndex = 12;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 440);
            this.label2.TabIndex = 11;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 440);
            this.label1.TabIndex = 10;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // label_finish
            // 
            this.label_finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_finish.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_finish.Location = new System.Drawing.Point(451, 11);
            this.label_finish.Name = "label_finish";
            this.label_finish.Size = new System.Drawing.Size(85, 44);
            this.label_finish.TabIndex = 9;
            this.label_finish.Text = "Финиш";
            this.label_finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_finish.MouseEnter += new System.EventHandler(this.label_finish_MouseEnter);
            // 
            // label_start
            // 
            this.label_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_start.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_start.Location = new System.Drawing.Point(11, 10);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(84, 43);
            this.label_start.TabIndex = 8;
            this.label_start.Text = "Старт";
            this.label_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Green;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 270);
            this.label7.TabIndex = 16;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // label_key
            // 
            this.label_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_key.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_key.Location = new System.Drawing.Point(345, 39);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(73, 43);
            this.label_key.TabIndex = 17;
            this.label_key.Text = "Ключ";
            this.label_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_key.MouseEnter += new System.EventHandler(this.label_key_MouseEnter);
            // 
            // label_door
            // 
            this.label_door.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_door.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_door.Location = new System.Drawing.Point(451, 238);
            this.label_door.Name = "label_door";
            this.label_door.Size = new System.Drawing.Size(84, 43);
            this.label_door.TabIndex = 18;
            this.label_door.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_door.MouseEnter += new System.EventHandler(this.label_door_MouseEnter);
            // 
            // label_wall2
            // 
            this.label_wall2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_wall2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wall2.Location = new System.Drawing.Point(2, 182);
            this.label_wall2.Name = "label_wall2";
            this.label_wall2.Size = new System.Drawing.Size(542, 44);
            this.label_wall2.TabIndex = 19;
            this.label_wall2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_wall2.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // label_wall1
            // 
            this.label_wall1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_wall1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wall1.Location = new System.Drawing.Point(2, 113);
            this.label_wall1.Name = "label_wall1";
            this.label_wall1.Size = new System.Drawing.Size(542, 31);
            this.label_wall1.TabIndex = 20;
            this.label_wall1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_wall1.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 900;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(546, 440);
            this.Controls.Add(this.label_door);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_finish);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label_wall2);
            this.Controls.Add(this.label_wall1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLevel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLevel2";
            this.Load += new System.EventHandler(this.FormLevel2_Load);
            this.Shown += new System.EventHandler(this.FormLevel2_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_finish;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Label label_door;
        private System.Windows.Forms.Label label_wall2;
        private System.Windows.Forms.Label label_wall1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}