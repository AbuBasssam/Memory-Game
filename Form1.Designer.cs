namespace Memory_Game
{
    partial class Form1
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
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.cmbSecnods = new System.Windows.Forms.ComboBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.cmbMinutes = new System.Windows.Forms.ComboBox();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cmbSquareNumber = new System.Windows.Forms.ComboBox();
            this.lblSet = new System.Windows.Forms.Label();
            this.cmbSets = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblHidePairs = new System.Windows.Forms.Label();
            this.lblHideMistake = new System.Windows.Forms.Label();
            this.lblHideMoves = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFastFlipSpeed = new System.Windows.Forms.Button();
            this.btnSlowFliepSpeed = new System.Windows.Forms.Button();
            this.btnStandredFlipSpeed = new System.Windows.Forms.Button();
            this.lblFlipSpeed = new System.Windows.Forms.Label();
            this.btnSoloMode = new System.Windows.Forms.Button();
            this.lblGameMode = new System.Windows.Forms.Label();
            this.btnHardDiffculty = new System.Windows.Forms.Button();
            this.btnEasyDiffculty = new System.Windows.Forms.Button();
            this.btnMeduimDiffculty = new System.Windows.Forms.Button();
            this.btnOffHideMoves = new System.Windows.Forms.Button();
            this.btnOnHideMoves = new System.Windows.Forms.Button();
            this.btnOffHideMistake = new System.Windows.Forms.Button();
            this.btnOnHideMistake = new System.Windows.Forms.Button();
            this.btnOffHidePairs = new System.Windows.Forms.Button();
            this.btnOnHidePairs = new System.Windows.Forms.Button();
            this.lblDiffculty = new System.Windows.Forms.Label();
            this.btnAgainstComputerMode = new System.Windows.Forms.Button();
            this.btnWithFriendMode = new System.Windows.Forms.Button();
            this.gbTime.SuspendLayout();
            this.gbGame.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.lblSeconds);
            this.gbTime.Controls.Add(this.cmbSecnods);
            this.gbTime.Controls.Add(this.lblMinutes);
            this.gbTime.Controls.Add(this.cmbMinutes);
            this.gbTime.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTime.Location = new System.Drawing.Point(23, 40);
            this.gbTime.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.gbTime.Name = "gbTime";
            this.gbTime.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.gbTime.Size = new System.Drawing.Size(381, 141);
            this.gbTime.TabIndex = 8;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Time";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(5, 102);
            this.lblSeconds.Margin = new System.Windows.Forms.Padding(23, 20, 23, 20);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(96, 28);
            this.lblSeconds.TabIndex = 7;
            this.lblSeconds.Text = "Secnods";
            // 
            // cmbSecnods
            // 
            this.cmbSecnods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecnods.FormattingEnabled = true;
            this.cmbSecnods.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbSecnods.Location = new System.Drawing.Point(131, 99);
            this.cmbSecnods.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.cmbSecnods.Name = "cmbSecnods";
            this.cmbSecnods.Size = new System.Drawing.Size(181, 36);
            this.cmbSecnods.TabIndex = 6;
            this.cmbSecnods.SelectedIndexChanged += new System.EventHandler(this.cmbSecnods_SelectedIndexChanged);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(5, 46);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(91, 28);
            this.lblMinutes.TabIndex = 5;
            this.lblMinutes.Text = "Minutes";
            // 
            // cmbMinutes
            // 
            this.cmbMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutes.FormattingEnabled = true;
            this.cmbMinutes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbMinutes.Location = new System.Drawing.Point(131, 43);
            this.cmbMinutes.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.cmbMinutes.Name = "cmbMinutes";
            this.cmbMinutes.Size = new System.Drawing.Size(181, 36);
            this.cmbMinutes.TabIndex = 4;
            this.cmbMinutes.SelectedIndexChanged += new System.EventHandler(this.cmbMinutes_SelectedIndexChanged);
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.lblLevel);
            this.gbGame.Controls.Add(this.cmbSquareNumber);
            this.gbGame.Controls.Add(this.lblSet);
            this.gbGame.Controls.Add(this.cmbSets);
            this.gbGame.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGame.Location = new System.Drawing.Point(429, 40);
            this.gbGame.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.gbGame.Name = "gbGame";
            this.gbGame.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.gbGame.Size = new System.Drawing.Size(432, 145);
            this.gbGame.TabIndex = 9;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Game";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(5, 90);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(63, 28);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "Level";
            // 
            // cmbSquareNumber
            // 
            this.cmbSquareNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSquareNumber.FormattingEnabled = true;
            this.cmbSquareNumber.Items.AddRange(new object[] {
            "4x3",
            "4x4",
            "4x5",
            "4x6"});
            this.cmbSquareNumber.Location = new System.Drawing.Point(99, 90);
            this.cmbSquareNumber.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.cmbSquareNumber.Name = "cmbSquareNumber";
            this.cmbSquareNumber.Size = new System.Drawing.Size(181, 36);
            this.cmbSquareNumber.TabIndex = 6;
            this.cmbSquareNumber.SelectedIndexChanged += new System.EventHandler(this.cmbSquareNumber_SelectedIndexChanged);
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Location = new System.Drawing.Point(5, 37);
            this.lblSet.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(45, 28);
            this.lblSet.TabIndex = 5;
            this.lblSet.Text = "Set";
            // 
            // cmbSets
            // 
            this.cmbSets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSets.FormattingEnabled = true;
            this.cmbSets.Items.AddRange(new object[] {
            "Animals",
            "Cars",
            "Numbers"});
            this.cmbSets.Location = new System.Drawing.Point(99, 34);
            this.cmbSets.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.cmbSets.Name = "cmbSets";
            this.cmbSets.Size = new System.Drawing.Size(181, 36);
            this.cmbSets.TabIndex = 4;
            this.cmbSets.SelectedIndexChanged += new System.EventHandler(this.cmbSets_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(296, 628);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(226, 58);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Finish";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblHidePairs
            // 
            this.lblHidePairs.AutoSize = true;
            this.lblHidePairs.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHidePairs.Location = new System.Drawing.Point(6, 160);
            this.lblHidePairs.Margin = new System.Windows.Forms.Padding(11, 10, 17, 15);
            this.lblHidePairs.Name = "lblHidePairs";
            this.lblHidePairs.Size = new System.Drawing.Size(138, 34);
            this.lblHidePairs.TabIndex = 8;
            this.lblHidePairs.Text = "Hide pairs";
            // 
            // lblHideMistake
            // 
            this.lblHideMistake.AutoSize = true;
            this.lblHideMistake.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHideMistake.Location = new System.Drawing.Point(6, 220);
            this.lblHideMistake.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lblHideMistake.Name = "lblHideMistake";
            this.lblHideMistake.Size = new System.Drawing.Size(175, 34);
            this.lblHideMistake.TabIndex = 9;
            this.lblHideMistake.Text = "Hide mistake";
            // 
            // lblHideMoves
            // 
            this.lblHideMoves.AutoSize = true;
            this.lblHideMoves.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHideMoves.Location = new System.Drawing.Point(6, 280);
            this.lblHideMoves.Margin = new System.Windows.Forms.Padding(11, 10, 17, 15);
            this.lblHideMoves.Name = "lblHideMoves";
            this.lblHideMoves.Size = new System.Drawing.Size(160, 34);
            this.lblHideMoves.TabIndex = 11;
            this.lblHideMoves.Text = "Hide moves";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnFastFlipSpeed);
            this.panel1.Controls.Add(this.btnSlowFliepSpeed);
            this.panel1.Controls.Add(this.btnStandredFlipSpeed);
            this.panel1.Controls.Add(this.lblFlipSpeed);
            this.panel1.Controls.Add(this.btnSoloMode);
            this.panel1.Controls.Add(this.lblGameMode);
            this.panel1.Controls.Add(this.btnHardDiffculty);
            this.panel1.Controls.Add(this.btnEasyDiffculty);
            this.panel1.Controls.Add(this.btnMeduimDiffculty);
            this.panel1.Controls.Add(this.btnOffHideMoves);
            this.panel1.Controls.Add(this.btnOnHideMoves);
            this.panel1.Controls.Add(this.btnOffHideMistake);
            this.panel1.Controls.Add(this.btnOnHideMistake);
            this.panel1.Controls.Add(this.btnOffHidePairs);
            this.panel1.Controls.Add(this.btnOnHidePairs);
            this.panel1.Controls.Add(this.lblHideMoves);
            this.panel1.Controls.Add(this.lblHidePairs);
            this.panel1.Controls.Add(this.lblHideMistake);
            this.panel1.Controls.Add(this.lblDiffculty);
            this.panel1.Controls.Add(this.btnAgainstComputerMode);
            this.panel1.Controls.Add(this.btnWithFriendMode);
            this.panel1.Location = new System.Drawing.Point(22, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 405);
            this.panel1.TabIndex = 19;
            // 
            // btnFastFlipSpeed
            // 
            this.btnFastFlipSpeed.AutoSize = true;
            this.btnFastFlipSpeed.BackColor = System.Drawing.Color.White;
            this.btnFastFlipSpeed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFastFlipSpeed.FlatAppearance.BorderSize = 0;
            this.btnFastFlipSpeed.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFastFlipSpeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFastFlipSpeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFastFlipSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastFlipSpeed.Location = new System.Drawing.Point(674, 350);
            this.btnFastFlipSpeed.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnFastFlipSpeed.Name = "btnFastFlipSpeed";
            this.btnFastFlipSpeed.Size = new System.Drawing.Size(145, 48);
            this.btnFastFlipSpeed.TabIndex = 43;
            this.btnFastFlipSpeed.Text = "Fast";
            this.btnFastFlipSpeed.UseVisualStyleBackColor = false;
            this.btnFastFlipSpeed.Click += new System.EventHandler(this.btnFlipSpeed_Click);
            // 
            // btnSlowFliepSpeed
            // 
            this.btnSlowFliepSpeed.AutoSize = true;
            this.btnSlowFliepSpeed.BackColor = System.Drawing.Color.White;
            this.btnSlowFliepSpeed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSlowFliepSpeed.FlatAppearance.BorderSize = 0;
            this.btnSlowFliepSpeed.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSlowFliepSpeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnSlowFliepSpeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnSlowFliepSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlowFliepSpeed.Location = new System.Drawing.Point(331, 350);
            this.btnSlowFliepSpeed.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnSlowFliepSpeed.Name = "btnSlowFliepSpeed";
            this.btnSlowFliepSpeed.Size = new System.Drawing.Size(145, 48);
            this.btnSlowFliepSpeed.TabIndex = 41;
            this.btnSlowFliepSpeed.Text = "Slow";
            this.btnSlowFliepSpeed.UseVisualStyleBackColor = false;
            this.btnSlowFliepSpeed.Click += new System.EventHandler(this.btnFlipSpeed_Click);
            // 
            // btnStandredFlipSpeed
            // 
            this.btnStandredFlipSpeed.AutoSize = true;
            this.btnStandredFlipSpeed.BackColor = System.Drawing.Color.White;
            this.btnStandredFlipSpeed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStandredFlipSpeed.FlatAppearance.BorderSize = 0;
            this.btnStandredFlipSpeed.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStandredFlipSpeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnStandredFlipSpeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnStandredFlipSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandredFlipSpeed.Location = new System.Drawing.Point(503, 350);
            this.btnStandredFlipSpeed.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnStandredFlipSpeed.Name = "btnStandredFlipSpeed";
            this.btnStandredFlipSpeed.Size = new System.Drawing.Size(145, 48);
            this.btnStandredFlipSpeed.TabIndex = 42;
            this.btnStandredFlipSpeed.Text = "Standred";
            this.btnStandredFlipSpeed.UseVisualStyleBackColor = false;
            this.btnStandredFlipSpeed.Click += new System.EventHandler(this.btnFlipSpeed_Click);
            // 
            // lblFlipSpeed
            // 
            this.lblFlipSpeed.AutoSize = true;
            this.lblFlipSpeed.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlipSpeed.Location = new System.Drawing.Point(6, 350);
            this.lblFlipSpeed.Margin = new System.Windows.Forms.Padding(11, 10, 17, 15);
            this.lblFlipSpeed.Name = "lblFlipSpeed";
            this.lblFlipSpeed.Size = new System.Drawing.Size(142, 34);
            this.lblFlipSpeed.TabIndex = 40;
            this.lblFlipSpeed.Text = "Flip Speed";
            // 
            // btnSoloMode
            // 
            this.btnSoloMode.AutoSize = true;
            this.btnSoloMode.BackColor = System.Drawing.Color.White;
            this.btnSoloMode.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSoloMode.FlatAppearance.BorderSize = 0;
            this.btnSoloMode.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSoloMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSoloMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSoloMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoloMode.Location = new System.Drawing.Point(331, 10);
            this.btnSoloMode.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnSoloMode.Name = "btnSoloMode";
            this.btnSoloMode.Size = new System.Drawing.Size(145, 48);
            this.btnSoloMode.TabIndex = 33;
            this.btnSoloMode.Text = "Solo";
            this.btnSoloMode.UseVisualStyleBackColor = false;
            this.btnSoloMode.Click += new System.EventHandler(this.GameMode_Click);
            // 
            // lblGameMode
            // 
            this.lblGameMode.AutoSize = true;
            this.lblGameMode.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMode.Location = new System.Drawing.Point(6, 10);
            this.lblGameMode.Margin = new System.Windows.Forms.Padding(11, 10, 17, 15);
            this.lblGameMode.Name = "lblGameMode";
            this.lblGameMode.Size = new System.Drawing.Size(164, 34);
            this.lblGameMode.TabIndex = 32;
            this.lblGameMode.Text = "Game Mode";
            // 
            // btnHardDiffculty
            // 
            this.btnHardDiffculty.BackColor = System.Drawing.Color.White;
            this.btnHardDiffculty.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHardDiffculty.FlatAppearance.BorderSize = 0;
            this.btnHardDiffculty.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnHardDiffculty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnHardDiffculty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnHardDiffculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardDiffculty.Location = new System.Drawing.Point(674, 75);
            this.btnHardDiffculty.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnHardDiffculty.Name = "btnHardDiffculty";
            this.btnHardDiffculty.Size = new System.Drawing.Size(145, 48);
            this.btnHardDiffculty.TabIndex = 38;
            this.btnHardDiffculty.Text = "Hard";
            this.btnHardDiffculty.UseVisualStyleBackColor = false;
            // 
            // btnEasyDiffculty
            // 
            this.btnEasyDiffculty.BackColor = System.Drawing.Color.White;
            this.btnEasyDiffculty.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEasyDiffculty.FlatAppearance.BorderSize = 0;
            this.btnEasyDiffculty.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnEasyDiffculty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEasyDiffculty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEasyDiffculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasyDiffculty.Location = new System.Drawing.Point(331, 75);
            this.btnEasyDiffculty.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnEasyDiffculty.Name = "btnEasyDiffculty";
            this.btnEasyDiffculty.Size = new System.Drawing.Size(145, 48);
            this.btnEasyDiffculty.TabIndex = 37;
            this.btnEasyDiffculty.Text = "Easy";
            this.btnEasyDiffculty.UseVisualStyleBackColor = false;
            // 
            // btnMeduimDiffculty
            // 
            this.btnMeduimDiffculty.BackColor = System.Drawing.Color.White;
            this.btnMeduimDiffculty.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMeduimDiffculty.FlatAppearance.BorderSize = 0;
            this.btnMeduimDiffculty.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnMeduimDiffculty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnMeduimDiffculty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMeduimDiffculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeduimDiffculty.Location = new System.Drawing.Point(503, 75);
            this.btnMeduimDiffculty.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnMeduimDiffculty.Name = "btnMeduimDiffculty";
            this.btnMeduimDiffculty.Size = new System.Drawing.Size(145, 48);
            this.btnMeduimDiffculty.TabIndex = 39;
            this.btnMeduimDiffculty.Text = "Medium";
            this.btnMeduimDiffculty.UseVisualStyleBackColor = false;
            // 
            // btnOffHideMoves
            // 
            this.btnOffHideMoves.AutoSize = true;
            this.btnOffHideMoves.BackColor = System.Drawing.Color.White;
            this.btnOffHideMoves.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOffHideMoves.FlatAppearance.BorderSize = 0;
            this.btnOffHideMoves.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnOffHideMoves.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnOffHideMoves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnOffHideMoves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffHideMoves.ForeColor = System.Drawing.Color.Purple;
            this.btnOffHideMoves.Location = new System.Drawing.Point(674, 280);
            this.btnOffHideMoves.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnOffHideMoves.Name = "btnOffHideMoves";
            this.btnOffHideMoves.Size = new System.Drawing.Size(145, 48);
            this.btnOffHideMoves.TabIndex = 28;
            this.btnOffHideMoves.Text = "OFF";
            this.btnOffHideMoves.UseVisualStyleBackColor = false;
            this.btnOffHideMoves.Click += new System.EventHandler(this.HideMove_Click);
            // 
            // btnOnHideMoves
            // 
            this.btnOnHideMoves.AutoSize = true;
            this.btnOnHideMoves.BackColor = System.Drawing.Color.White;
            this.btnOnHideMoves.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOnHideMoves.FlatAppearance.BorderSize = 0;
            this.btnOnHideMoves.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOnHideMoves.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOnHideMoves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOnHideMoves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnHideMoves.ForeColor = System.Drawing.Color.Purple;
            this.btnOnHideMoves.Location = new System.Drawing.Point(503, 280);
            this.btnOnHideMoves.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnOnHideMoves.Name = "btnOnHideMoves";
            this.btnOnHideMoves.Size = new System.Drawing.Size(145, 48);
            this.btnOnHideMoves.TabIndex = 27;
            this.btnOnHideMoves.Text = "ON";
            this.btnOnHideMoves.UseVisualStyleBackColor = false;
            this.btnOnHideMoves.Click += new System.EventHandler(this.HideMove_Click);
            // 
            // btnOffHideMistake
            // 
            this.btnOffHideMistake.AutoSize = true;
            this.btnOffHideMistake.BackColor = System.Drawing.Color.White;
            this.btnOffHideMistake.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOffHideMistake.FlatAppearance.BorderSize = 0;
            this.btnOffHideMistake.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnOffHideMistake.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnOffHideMistake.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnOffHideMistake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffHideMistake.ForeColor = System.Drawing.Color.Purple;
            this.btnOffHideMistake.Location = new System.Drawing.Point(674, 220);
            this.btnOffHideMistake.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnOffHideMistake.Name = "btnOffHideMistake";
            this.btnOffHideMistake.Size = new System.Drawing.Size(145, 48);
            this.btnOffHideMistake.TabIndex = 26;
            this.btnOffHideMistake.Text = "OFF";
            this.btnOffHideMistake.UseVisualStyleBackColor = false;
            this.btnOffHideMistake.Click += new System.EventHandler(this.HideMistake_Click);
            // 
            // btnOnHideMistake
            // 
            this.btnOnHideMistake.AutoSize = true;
            this.btnOnHideMistake.BackColor = System.Drawing.Color.White;
            this.btnOnHideMistake.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOnHideMistake.FlatAppearance.BorderSize = 0;
            this.btnOnHideMistake.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOnHideMistake.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOnHideMistake.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOnHideMistake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnHideMistake.ForeColor = System.Drawing.Color.Purple;
            this.btnOnHideMistake.Location = new System.Drawing.Point(503, 220);
            this.btnOnHideMistake.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnOnHideMistake.Name = "btnOnHideMistake";
            this.btnOnHideMistake.Size = new System.Drawing.Size(145, 48);
            this.btnOnHideMistake.TabIndex = 25;
            this.btnOnHideMistake.Text = "ON";
            this.btnOnHideMistake.UseVisualStyleBackColor = false;
            this.btnOnHideMistake.Click += new System.EventHandler(this.HideMistake_Click);
            // 
            // btnOffHidePairs
            // 
            this.btnOffHidePairs.AutoSize = true;
            this.btnOffHidePairs.BackColor = System.Drawing.Color.White;
            this.btnOffHidePairs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOffHidePairs.FlatAppearance.BorderSize = 0;
            this.btnOffHidePairs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnOffHidePairs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnOffHidePairs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnOffHidePairs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffHidePairs.ForeColor = System.Drawing.Color.Purple;
            this.btnOffHidePairs.Location = new System.Drawing.Point(674, 160);
            this.btnOffHidePairs.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnOffHidePairs.Name = "btnOffHidePairs";
            this.btnOffHidePairs.Size = new System.Drawing.Size(145, 48);
            this.btnOffHidePairs.TabIndex = 24;
            this.btnOffHidePairs.Text = "OFF";
            this.btnOffHidePairs.UseVisualStyleBackColor = false;
            this.btnOffHidePairs.Click += new System.EventHandler(this.HidePairs_Click);
            // 
            // btnOnHidePairs
            // 
            this.btnOnHidePairs.AutoSize = true;
            this.btnOnHidePairs.BackColor = System.Drawing.Color.White;
            this.btnOnHidePairs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOnHidePairs.FlatAppearance.BorderSize = 0;
            this.btnOnHidePairs.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOnHidePairs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOnHidePairs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOnHidePairs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnHidePairs.ForeColor = System.Drawing.Color.Purple;
            this.btnOnHidePairs.Location = new System.Drawing.Point(503, 160);
            this.btnOnHidePairs.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnOnHidePairs.Name = "btnOnHidePairs";
            this.btnOnHidePairs.Size = new System.Drawing.Size(145, 48);
            this.btnOnHidePairs.TabIndex = 23;
            this.btnOnHidePairs.Text = "ON";
            this.btnOnHidePairs.UseVisualStyleBackColor = false;
            this.btnOnHidePairs.Click += new System.EventHandler(this.HidePairs_Click);
            // 
            // lblDiffculty
            // 
            this.lblDiffculty.AutoSize = true;
            this.lblDiffculty.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiffculty.Location = new System.Drawing.Point(6, 75);
            this.lblDiffculty.Margin = new System.Windows.Forms.Padding(11, 10, 17, 15);
            this.lblDiffculty.Name = "lblDiffculty";
            this.lblDiffculty.Size = new System.Drawing.Size(116, 34);
            this.lblDiffculty.TabIndex = 36;
            this.lblDiffculty.Text = "Diffculty";
            // 
            // btnAgainstComputerMode
            // 
            this.btnAgainstComputerMode.AutoSize = true;
            this.btnAgainstComputerMode.BackColor = System.Drawing.Color.White;
            this.btnAgainstComputerMode.Enabled = false;
            this.btnAgainstComputerMode.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgainstComputerMode.FlatAppearance.BorderSize = 0;
            this.btnAgainstComputerMode.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgainstComputerMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgainstComputerMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgainstComputerMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgainstComputerMode.Location = new System.Drawing.Point(674, 10);
            this.btnAgainstComputerMode.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnAgainstComputerMode.Name = "btnAgainstComputerMode";
            this.btnAgainstComputerMode.Size = new System.Drawing.Size(146, 48);
            this.btnAgainstComputerMode.TabIndex = 35;
            this.btnAgainstComputerMode.Text = "Against Computer";
            this.btnAgainstComputerMode.UseVisualStyleBackColor = false;
            this.btnAgainstComputerMode.Click += new System.EventHandler(this.GameMode_Click);
            // 
            // btnWithFriendMode
            // 
            this.btnWithFriendMode.AutoSize = true;
            this.btnWithFriendMode.BackColor = System.Drawing.Color.White;
            this.btnWithFriendMode.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnWithFriendMode.FlatAppearance.BorderSize = 0;
            this.btnWithFriendMode.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnWithFriendMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnWithFriendMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnWithFriendMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithFriendMode.Location = new System.Drawing.Point(503, 10);
            this.btnWithFriendMode.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnWithFriendMode.Name = "btnWithFriendMode";
            this.btnWithFriendMode.Size = new System.Drawing.Size(145, 48);
            this.btnWithFriendMode.TabIndex = 34;
            this.btnWithFriendMode.Text = "With Friend";
            this.btnWithFriendMode.UseVisualStyleBackColor = false;
            this.btnWithFriendMode.Click += new System.EventHandler(this.GameMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(871, 698);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.gbTime);
            this.Name = "Form1";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.ComboBox cmbSecnods;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.ComboBox cmbMinutes;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cmbSquareNumber;
        private System.Windows.Forms.Label lblSet;
        private System.Windows.Forms.ComboBox cmbSets;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblHidePairs;
        private System.Windows.Forms.Label lblHideMistake;
        private System.Windows.Forms.Label lblHideMoves;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOffHidePairs;
        private System.Windows.Forms.Button btnOnHidePairs;
        private System.Windows.Forms.Button btnOffHideMoves;
        private System.Windows.Forms.Button btnOnHideMoves;
        private System.Windows.Forms.Button btnOffHideMistake;
        private System.Windows.Forms.Button btnOnHideMistake;
        private System.Windows.Forms.Label lblDiffculty;
        private System.Windows.Forms.Button btnAgainstComputerMode;
        private System.Windows.Forms.Button btnSoloMode;
        private System.Windows.Forms.Label lblGameMode;
        private System.Windows.Forms.Button btnHardDiffculty;
        private System.Windows.Forms.Button btnWithFriendMode;
        private System.Windows.Forms.Button btnEasyDiffculty;
        private System.Windows.Forms.Button btnMeduimDiffculty;
        private System.Windows.Forms.Label lblFlipSpeed;
        private System.Windows.Forms.Button btnFastFlipSpeed;
        private System.Windows.Forms.Button btnSlowFliepSpeed;
        private System.Windows.Forms.Button btnStandredFlipSpeed;
    }
}