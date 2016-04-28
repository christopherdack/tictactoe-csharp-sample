namespace tic_tac_toe_dack
{
    partial class frmTicTacToe
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnSquare1 = new System.Windows.Forms.Button();
            this.btnSquare2 = new System.Windows.Forms.Button();
            this.btnSquare3 = new System.Windows.Forms.Button();
            this.btnSquare4 = new System.Windows.Forms.Button();
            this.btnSquare5 = new System.Windows.Forms.Button();
            this.btnSquare6 = new System.Windows.Forms.Button();
            this.btnSquare7 = new System.Windows.Forms.Button();
            this.btnSquare8 = new System.Windows.Forms.Button();
            this.btnSquare9 = new System.Windows.Forms.Button();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.lblGamesTied = new System.Windows.Forms.Label();
            this.lblPlayer2Wins = new System.Windows.Forms.Label();
            this.lblPlayer1Wins = new System.Windows.Forms.Label();
            this.lblGameNumber = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.lblGamesTiedLabel = new System.Windows.Forms.Label();
            this.lblPlayer2WinsLabel = new System.Windows.Forms.Label();
            this.lblPlayer1WinsLabel = new System.Windows.Forms.Label();
            this.lblGameNumberLabel = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(539, 63);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(53, 20);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Score";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(539, 110);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(70, 20);
            this.lblPlayer1.TabIndex = 11;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(539, 156);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(70, 20);
            this.lblPlayer2.TabIndex = 12;
            this.lblPlayer2.Text = "Player 2";
            // 
            // btnReset
            // 
            this.btnReset.AccessibleDescription = "Reset button to clear all game data and start over";
            this.btnReset.AccessibleName = "Reset button";
            this.btnReset.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnReset.Enabled = false;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Khaki;
            this.btnReset.Location = new System.Drawing.Point(41, 580);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(268, 45);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleDescription = "Exit button";
            this.btnExit.AccessibleName = "Exit button";
            this.btnExit.BackColor = System.Drawing.Color.Tan;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(521, 580);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(314, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.AccessibleDescription = "Play Again button";
            this.btnPlayAgain.AccessibleName = "Play Again button";
            this.btnPlayAgain.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnPlayAgain.Enabled = false;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.Khaki;
            this.btnPlayAgain.Location = new System.Drawing.Point(41, 506);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(268, 45);
            this.btnPlayAgain.TabIndex = 1;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnSquare1
            // 
            this.btnSquare1.AccessibleDescription = "First square on game board";
            this.btnSquare1.AccessibleName = "Square 1";
            this.btnSquare1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSquare1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSquare1.Location = new System.Drawing.Point(41, 41);
            this.btnSquare1.Name = "btnSquare1";
            this.btnSquare1.Size = new System.Drawing.Size(120, 120);
            this.btnSquare1.TabIndex = 13;
            this.btnSquare1.TabStop = false;
            this.btnSquare1.Tag = "1";
            this.btnSquare1.UseVisualStyleBackColor = false;
            this.btnSquare1.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnSquare2
            // 
            this.btnSquare2.AccessibleDescription = "Second square on game board";
            this.btnSquare2.AccessibleName = "Square 2";
            this.btnSquare2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSquare2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSquare2.Location = new System.Drawing.Point(189, 41);
            this.btnSquare2.Name = "btnSquare2";
            this.btnSquare2.Size = new System.Drawing.Size(120, 120);
            this.btnSquare2.TabIndex = 14;
            this.btnSquare2.TabStop = false;
            this.btnSquare2.Tag = "2";
            this.btnSquare2.UseVisualStyleBackColor = false;
            this.btnSquare2.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnSquare3
            // 
            this.btnSquare3.AccessibleDescription = "Third square on game board";
            this.btnSquare3.AccessibleName = "Square 3";
            this.btnSquare3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSquare3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSquare3.Location = new System.Drawing.Point(339, 41);
            this.btnSquare3.Name = "btnSquare3";
            this.btnSquare3.Size = new System.Drawing.Size(120, 120);
            this.btnSquare3.TabIndex = 15;
            this.btnSquare3.TabStop = false;
            this.btnSquare3.Tag = "3";
            this.btnSquare3.UseVisualStyleBackColor = false;
            this.btnSquare3.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnSquare4
            // 
            this.btnSquare4.AccessibleDescription = "Fourth square on game board";
            this.btnSquare4.AccessibleName = "Square 4";
            this.btnSquare4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSquare4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSquare4.Location = new System.Drawing.Point(41, 189);
            this.btnSquare4.Name = "btnSquare4";
            this.btnSquare4.Size = new System.Drawing.Size(120, 120);
            this.btnSquare4.TabIndex = 16;
            this.btnSquare4.TabStop = false;
            this.btnSquare4.Tag = "4";
            this.btnSquare4.UseVisualStyleBackColor = false;
            this.btnSquare4.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnSquare5
            // 
            this.btnSquare5.AccessibleDescription = "Fifth square on game board";
            this.btnSquare5.AccessibleName = "Square 5";
            this.btnSquare5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSquare5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSquare5.Location = new System.Drawing.Point(189, 189);
            this.btnSquare5.Name = "btnSquare5";
            this.btnSquare5.Size = new System.Drawing.Size(120, 120);
            this.btnSquare5.TabIndex = 17;
            this.btnSquare5.TabStop = false;
            this.btnSquare5.Tag = "5";
            this.btnSquare5.UseVisualStyleBackColor = false;
            this.btnSquare5.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnSquare6
            // 
            this.btnSquare6.AccessibleDescription = "Sixth square on game board";
            this.btnSquare6.AccessibleName = "Square 6";
            this.btnSquare6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSquare6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSquare6.Location = new System.Drawing.Point(339, 189);
            this.btnSquare6.Name = "btnSquare6";
            this.btnSquare6.Size = new System.Drawing.Size(120, 120);
            this.btnSquare6.TabIndex = 18;
            this.btnSquare6.TabStop = false;
            this.btnSquare6.Tag = "6";
            this.btnSquare6.UseVisualStyleBackColor = false;
            this.btnSquare6.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnSquare7
            // 
            this.btnSquare7.AccessibleDescription = "Seventh square on game board";
            this.btnSquare7.AccessibleName = "Square 7";
            this.btnSquare7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSquare7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSquare7.Location = new System.Drawing.Point(41, 339);
            this.btnSquare7.Name = "btnSquare7";
            this.btnSquare7.Size = new System.Drawing.Size(120, 120);
            this.btnSquare7.TabIndex = 19;
            this.btnSquare7.TabStop = false;
            this.btnSquare7.Tag = "7";
            this.btnSquare7.UseVisualStyleBackColor = false;
            this.btnSquare7.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnSquare8
            // 
            this.btnSquare8.AccessibleDescription = "Eighth square on game board";
            this.btnSquare8.AccessibleName = "Square 8";
            this.btnSquare8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSquare8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSquare8.Location = new System.Drawing.Point(189, 339);
            this.btnSquare8.Name = "btnSquare8";
            this.btnSquare8.Size = new System.Drawing.Size(120, 120);
            this.btnSquare8.TabIndex = 20;
            this.btnSquare8.TabStop = false;
            this.btnSquare8.Tag = "8";
            this.btnSquare8.UseVisualStyleBackColor = false;
            this.btnSquare8.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnSquare9
            // 
            this.btnSquare9.AccessibleDescription = "Ninth square on game board";
            this.btnSquare9.AccessibleName = "Square 9";
            this.btnSquare9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSquare9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSquare9.Location = new System.Drawing.Point(339, 339);
            this.btnSquare9.Name = "btnSquare9";
            this.btnSquare9.Size = new System.Drawing.Size(120, 120);
            this.btnSquare9.TabIndex = 21;
            this.btnSquare9.TabStop = false;
            this.btnSquare9.Tag = "9";
            this.btnSquare9.UseVisualStyleBackColor = false;
            this.btnSquare9.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // pnlResults
            // 
            this.pnlResults.AccessibleDescription = "Result display panel";
            this.pnlResults.AccessibleName = "Panel Results";
            this.pnlResults.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlResults.Controls.Add(this.lblGamesTied);
            this.pnlResults.Controls.Add(this.lblPlayer2Wins);
            this.pnlResults.Controls.Add(this.lblPlayer1Wins);
            this.pnlResults.Controls.Add(this.lblGameNumber);
            this.pnlResults.Controls.Add(this.lblPlayerTurn);
            this.pnlResults.Controls.Add(this.lblGamesTiedLabel);
            this.pnlResults.Controls.Add(this.lblPlayer2WinsLabel);
            this.pnlResults.Controls.Add(this.lblPlayer1WinsLabel);
            this.pnlResults.Controls.Add(this.lblGameNumberLabel);
            this.pnlResults.Controls.Add(this.lblTitle);
            this.pnlResults.Location = new System.Drawing.Point(521, 41);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(314, 418);
            this.pnlResults.TabIndex = 22;
            // 
            // lblGamesTied
            // 
            this.lblGamesTied.AccessibleName = "Games Tied display";
            this.lblGamesTied.AutoSize = true;
            this.lblGamesTied.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesTied.Location = new System.Drawing.Point(250, 367);
            this.lblGamesTied.Name = "lblGamesTied";
            this.lblGamesTied.Size = new System.Drawing.Size(19, 20);
            this.lblGamesTied.TabIndex = 9;
            this.lblGamesTied.Text = "0";
            this.lblGamesTied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayer2Wins
            // 
            this.lblPlayer2Wins.AccessibleName = "Player 2 win display";
            this.lblPlayer2Wins.AutoSize = true;
            this.lblPlayer2Wins.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Wins.Location = new System.Drawing.Point(250, 294);
            this.lblPlayer2Wins.Name = "lblPlayer2Wins";
            this.lblPlayer2Wins.Size = new System.Drawing.Size(19, 20);
            this.lblPlayer2Wins.TabIndex = 8;
            this.lblPlayer2Wins.Text = "0";
            this.lblPlayer2Wins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayer1Wins
            // 
            this.lblPlayer1Wins.AccessibleName = "Player 1 win display";
            this.lblPlayer1Wins.AutoSize = true;
            this.lblPlayer1Wins.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Wins.Location = new System.Drawing.Point(250, 217);
            this.lblPlayer1Wins.Name = "lblPlayer1Wins";
            this.lblPlayer1Wins.Size = new System.Drawing.Size(19, 20);
            this.lblPlayer1Wins.TabIndex = 7;
            this.lblPlayer1Wins.Text = "0";
            this.lblPlayer1Wins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGameNumber
            // 
            this.lblGameNumber.AccessibleName = "Game Number display";
            this.lblGameNumber.AutoSize = true;
            this.lblGameNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameNumber.Location = new System.Drawing.Point(250, 148);
            this.lblGameNumber.Name = "lblGameNumber";
            this.lblGameNumber.Size = new System.Drawing.Size(19, 20);
            this.lblGameNumber.TabIndex = 6;
            this.lblGameNumber.Text = "1";
            this.lblGameNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AccessibleName = "Player\'s Turn label";
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.BackColor = System.Drawing.Color.DarkGreen;
            this.lblPlayerTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayerTurn.Location = new System.Drawing.Point(25, 64);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Padding = new System.Windows.Forms.Padding(12);
            this.lblPlayerTurn.Size = new System.Drawing.Size(259, 60);
            this.lblPlayerTurn.TabIndex = 5;
            this.lblPlayerTurn.Text = "Player 1\'s Turn";
            this.lblPlayerTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamesTiedLabel
            // 
            this.lblGamesTiedLabel.AccessibleName = "Games tied";
            this.lblGamesTiedLabel.AutoSize = true;
            this.lblGamesTiedLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesTiedLabel.Location = new System.Drawing.Point(36, 367);
            this.lblGamesTiedLabel.Name = "lblGamesTiedLabel";
            this.lblGamesTiedLabel.Size = new System.Drawing.Size(107, 20);
            this.lblGamesTiedLabel.TabIndex = 4;
            this.lblGamesTiedLabel.Text = "Games tied:";
            this.lblGamesTiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayer2WinsLabel
            // 
            this.lblPlayer2WinsLabel.AccessibleName = "Player 2 Win Total";
            this.lblPlayer2WinsLabel.AutoSize = true;
            this.lblPlayer2WinsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2WinsLabel.Location = new System.Drawing.Point(36, 294);
            this.lblPlayer2WinsLabel.Name = "lblPlayer2WinsLabel";
            this.lblPlayer2WinsLabel.Size = new System.Drawing.Size(122, 20);
            this.lblPlayer2WinsLabel.TabIndex = 3;
            this.lblPlayer2WinsLabel.Text = "Player 2 wins:";
            this.lblPlayer2WinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayer1WinsLabel
            // 
            this.lblPlayer1WinsLabel.AccessibleName = "Player 1 Win Total";
            this.lblPlayer1WinsLabel.AutoSize = true;
            this.lblPlayer1WinsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1WinsLabel.Location = new System.Drawing.Point(36, 221);
            this.lblPlayer1WinsLabel.Name = "lblPlayer1WinsLabel";
            this.lblPlayer1WinsLabel.Size = new System.Drawing.Size(122, 20);
            this.lblPlayer1WinsLabel.TabIndex = 2;
            this.lblPlayer1WinsLabel.Text = "Player 1 wins:";
            this.lblPlayer1WinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGameNumberLabel
            // 
            this.lblGameNumberLabel.AccessibleName = "Game Number label";
            this.lblGameNumberLabel.AutoSize = true;
            this.lblGameNumberLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameNumberLabel.Location = new System.Drawing.Point(35, 148);
            this.lblGameNumberLabel.Name = "lblGameNumberLabel";
            this.lblGameNumberLabel.Size = new System.Drawing.Size(132, 20);
            this.lblGameNumberLabel.TabIndex = 1;
            this.lblGameNumberLabel.Text = "Game Number:";
            this.lblGameNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleName = "Title label";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tic-Tac-Toe";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTicTacToe
            // 
            this.AccessibleDescription = "Tic Tac Toe game";
            this.AccessibleName = "Tic Tac Toe game";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(871, 691);
            this.ControlBox = false;
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.btnSquare9);
            this.Controls.Add(this.btnSquare8);
            this.Controls.Add(this.btnSquare7);
            this.Controls.Add(this.btnSquare6);
            this.Controls.Add(this.btnSquare5);
            this.Controls.Add(this.btnSquare4);
            this.Controls.Add(this.btnSquare3);
            this.Controls.Add(this.btnSquare2);
            this.Controls.Add(this.btnSquare1);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTicTacToe";
            this.Padding = new System.Windows.Forms.Padding(22);
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.frmTicTacToe_Load);
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnSquare1;
        private System.Windows.Forms.Button btnSquare2;
        private System.Windows.Forms.Button btnSquare3;
        private System.Windows.Forms.Button btnSquare4;
        private System.Windows.Forms.Button btnSquare5;
        private System.Windows.Forms.Button btnSquare6;
        private System.Windows.Forms.Button btnSquare7;
        private System.Windows.Forms.Button btnSquare8;
        private System.Windows.Forms.Button btnSquare9;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblGamesTied;
        private System.Windows.Forms.Label lblPlayer2Wins;
        private System.Windows.Forms.Label lblPlayer1Wins;
        private System.Windows.Forms.Label lblGameNumber;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label lblGamesTiedLabel;
        private System.Windows.Forms.Label lblPlayer2WinsLabel;
        private System.Windows.Forms.Label lblPlayer1WinsLabel;
        private System.Windows.Forms.Label lblGameNumberLabel;
        private System.Windows.Forms.Label lblTitle;
    }
}

