﻿namespace Rock_Paper_Scissors
{
    partial class frmLaunch
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
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnTwoPlayer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBestOf = new System.Windows.Forms.GroupBox();
            this.btn3Games = new System.Windows.Forms.RadioButton();
            this.btn5 = new System.Windows.Forms.RadioButton();
            this.btn7 = new System.Windows.Forms.RadioButton();
            this.grpBestOf.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.Location = new System.Drawing.Point(14, 12);
            this.btnSinglePlayer.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(209, 54);
            this.btnSinglePlayer.TabIndex = 0;
            this.btnSinglePlayer.Text = "1 Player\r\nPlay Against a Computer-Controlled Bot\r\n";
            this.btnSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // btnTwoPlayer
            // 
            this.btnTwoPlayer.Location = new System.Drawing.Point(14, 72);
            this.btnTwoPlayer.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTwoPlayer.Name = "btnTwoPlayer";
            this.btnTwoPlayer.Size = new System.Drawing.Size(209, 54);
            this.btnTwoPlayer.TabIndex = 1;
            this.btnTwoPlayer.Text = "2 Player\r\nPlay Against Another Human\r\n";
            this.btnTwoPlayer.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(59, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 54);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBestOf
            // 
            this.grpBestOf.Controls.Add(this.btn7);
            this.grpBestOf.Controls.Add(this.btn5);
            this.grpBestOf.Controls.Add(this.btn3Games);
            this.grpBestOf.Location = new System.Drawing.Point(14, 138);
            this.grpBestOf.Name = "grpBestOf";
            this.grpBestOf.Size = new System.Drawing.Size(209, 50);
            this.grpBestOf.TabIndex = 3;
            this.grpBestOf.TabStop = false;
            this.grpBestOf.Text = "Best Of:";
            // 
            // btn3Games
            // 
            this.btn3Games.AutoSize = true;
            this.btn3Games.Location = new System.Drawing.Point(26, 19);
            this.btn3Games.Name = "btn3Games";
            this.btn3Games.Size = new System.Drawing.Size(31, 17);
            this.btn3Games.TabIndex = 0;
            this.btn3Games.TabStop = true;
            this.btn3Games.Text = "3";
            this.btn3Games.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.Location = new System.Drawing.Point(86, 19);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(31, 17);
            this.btn5.TabIndex = 1;
            this.btn5.TabStop = true;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.Location = new System.Drawing.Point(153, 19);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(31, 17);
            this.btn7.TabIndex = 2;
            this.btn7.TabStop = true;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // frmLaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(237, 260);
            this.Controls.Add(this.grpBestOf);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTwoPlayer);
            this.Controls.Add(this.btnSinglePlayer);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(253, 236);
            this.Name = "frmLaunch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.grpBestOf.ResumeLayout(false);
            this.grpBestOf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnTwoPlayer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBestOf;
        private System.Windows.Forms.RadioButton btn7;
        private System.Windows.Forms.RadioButton btn5;
        private System.Windows.Forms.RadioButton btn3Games;
    }
}

