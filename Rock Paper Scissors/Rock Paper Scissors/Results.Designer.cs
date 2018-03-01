namespace Rock_Paper_Scissors
{
    partial class Results
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
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.pcboxPlayerOne = new System.Windows.Forms.PictureBox();
            this.pcBoxPlayerTwo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            this.lblRoundCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxPlayerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxPlayerTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPlayerOne.Location = new System.Drawing.Point(13, 13);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(149, 31);
            this.lblPlayerOne.TabIndex = 0;
            this.lblPlayerOne.Text = "Player One";
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerTwo.Location = new System.Drawing.Point(329, 13);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(150, 31);
            this.lblPlayerTwo.TabIndex = 1;
            this.lblPlayerTwo.Text = "Player Two";
            // 
            // pcboxPlayerOne
            // 
            this.pcboxPlayerOne.Location = new System.Drawing.Point(13, 61);
            this.pcboxPlayerOne.Name = "pcboxPlayerOne";
            this.pcboxPlayerOne.Size = new System.Drawing.Size(150, 125);
            this.pcboxPlayerOne.TabIndex = 2;
            this.pcboxPlayerOne.TabStop = false;
            // 
            // pcBoxPlayerTwo
            // 
            this.pcBoxPlayerTwo.Location = new System.Drawing.Point(329, 61);
            this.pcBoxPlayerTwo.Name = "pcBoxPlayerTwo";
            this.pcBoxPlayerTwo.Size = new System.Drawing.Size(150, 125);
            this.pcBoxPlayerTwo.TabIndex = 3;
            this.pcBoxPlayerTwo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(7, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player One Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(324, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player Two Score";
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.Location = new System.Drawing.Point(382, 230);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(0, 54);
            this.lblPlayer2Score.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(172, 318);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 47);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next Round";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.Navy;
            this.lblWin.Location = new System.Drawing.Point(167, 89);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(156, 48);
            this.lblWin.TabIndex = 9;
            this.lblWin.Text = "Player One Wins \r\n     the Round";
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.Location = new System.Drawing.Point(56, 230);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(0, 54);
            this.lblPlayer1Score.TabIndex = 4;
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.Location = new System.Drawing.Point(206, 19);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(79, 25);
            this.lblRounds.TabIndex = 10;
            this.lblRounds.Text = "Rounds";
            // 
            // lblRoundCount
            // 
            this.lblRoundCount.AutoSize = true;
            this.lblRoundCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundCount.ForeColor = System.Drawing.Color.Black;
            this.lblRoundCount.Location = new System.Drawing.Point(222, 44);
            this.lblRoundCount.Name = "lblRoundCount";
            this.lblRoundCount.Size = new System.Drawing.Size(43, 25);
            this.lblRoundCount.TabIndex = 11;
            this.lblRoundCount.Text = "0/5";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(491, 377);
            this.Controls.Add(this.lblRoundCount);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.pcBoxPlayerTwo);
            this.Controls.Add(this.pcboxPlayerOne);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.lblPlayerOne);
            this.Name = "Results";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.pcboxPlayerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxPlayerTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.PictureBox pcboxPlayerOne;
        private System.Windows.Forms.PictureBox pcBoxPlayerTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label lblRoundCount;
    }
}