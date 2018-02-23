namespace Rock_Paper_Scissors
{
    partial class PlayerChoice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnScissors = new System.Windows.Forms.RadioButton();
            this.btnPaper = new System.Windows.Forms.RadioButton();
            this.btnRock = new System.Windows.Forms.RadioButton();
            this.btnContinue = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnScissors);
            this.groupBox1.Controls.Add(this.btnPaper);
            this.groupBox1.Controls.Add(this.btnRock);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Choice:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnScissors
            // 
            this.btnScissors.AutoSize = true;
            this.btnScissors.Location = new System.Drawing.Point(6, 153);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(14, 13);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.TabStop = true;
            this.btnScissors.UseVisualStyleBackColor = true;
            // 
            // btnPaper
            // 
            this.btnPaper.AutoSize = true;
            this.btnPaper.Location = new System.Drawing.Point(7, 84);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(14, 13);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.TabStop = true;
            this.btnPaper.UseVisualStyleBackColor = true;
            // 
            // btnRock
            // 
            this.btnRock.AutoSize = true;
            this.btnRock.Location = new System.Drawing.Point(7, 20);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(14, 13);
            this.btnRock.TabIndex = 0;
            this.btnRock.TabStop = true;
            this.btnRock.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(20, 277);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(185, 59);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // PlayerChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 386);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PlayerChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Player Choice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnScissors;
        private System.Windows.Forms.RadioButton btnPaper;
        private System.Windows.Forms.RadioButton btnRock;
        private System.Windows.Forms.Button btnContinue;
    }
}