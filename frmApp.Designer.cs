namespace Memory_Game
{
    partial class frmApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMoves = new System.Windows.Forms.RichTextBox();
            this.txtMistake = new System.Windows.Forms.RichTextBox();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.btnSound = new Memory_Game.Custom_btn();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(5, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 366);
            this.panel1.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(748, 376);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(168, 49);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(748, 441);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(168, 49);
            this.btnShuffle.TabIndex = 22;
            this.btnShuffle.Text = "Restart";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.Location = new System.Drawing.Point(350, 10);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(73, 29);
            this.lblTimer.TabIndex = 23;
            this.lblTimer.Text = "00:00";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.BackColor = System.Drawing.Color.Aqua;
            this.txtPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayer2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2.ForeColor = System.Drawing.Color.White;
            this.txtPlayer2.Location = new System.Drawing.Point(484, 87);
            this.txtPlayer2.Multiline = true;
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(457, 47);
            this.txtPlayer2.TabIndex = 24;
            this.txtPlayer2.Text = "Player2\r\nPairs :\r\n";
            this.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnSound);
            this.panel2.Controls.Add(this.txtMoves);
            this.panel2.Controls.Add(this.txtMistake);
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(5, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 70);
            this.panel2.TabIndex = 25;
            // 
            // txtMoves
            // 
            this.txtMoves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.txtMoves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoves.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoves.Location = new System.Drawing.Point(15, 10);
            this.txtMoves.Margin = new System.Windows.Forms.Padding(15);
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.ReadOnly = true;
            this.txtMoves.Size = new System.Drawing.Size(105, 40);
            this.txtMoves.TabIndex = 25;
            this.txtMoves.Text = "Moves :";
            // 
            // txtMistake
            // 
            this.txtMistake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.txtMistake.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMistake.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMistake.Location = new System.Drawing.Point(155, 10);
            this.txtMistake.Margin = new System.Windows.Forms.Padding(15);
            this.txtMistake.Name = "txtMistake";
            this.txtMistake.ReadOnly = true;
            this.txtMistake.Size = new System.Drawing.Size(152, 40);
            this.txtMistake.TabIndex = 24;
            this.txtMistake.Text = "Mistake :";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.BackColor = System.Drawing.Color.Lime;
            this.txtPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayer1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1.ForeColor = System.Drawing.Color.White;
            this.txtPlayer1.Location = new System.Drawing.Point(5, 87);
            this.txtPlayer1.Multiline = true;
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(473, 47);
            this.txtPlayer1.TabIndex = 26;
            this.txtPlayer1.Text = "Player1\r\nPairs :\r\n";
            this.txtPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSound
            // 
            this.btnSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSound.FlatAppearance.BorderSize = 0;
            this.btnSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Image = global::Memory_Game.Properties.Resources.volume_up__1_;
            this.btnSound.Location = new System.Drawing.Point(833, 8);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(90, 55);
            this.btnSound.TabIndex = 27;
            this.btnSound.Tag = "ON";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(953, 502);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmApp";
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.frmApp_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.RichTextBox txtMoves;
        private System.Windows.Forms.RichTextBox txtMistake;
        private Custom_btn btnSound;
    }
}