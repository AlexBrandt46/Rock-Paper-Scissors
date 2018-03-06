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
            this.pcBoxRock = new System.Windows.Forms.PictureBox();
            this.pcBoxPaper = new System.Windows.Forms.PictureBox();
            this.pcBoxScissors = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxScissors)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcBoxScissors);
            this.groupBox1.Controls.Add(this.pcBoxPaper);
            this.groupBox1.Controls.Add(this.pcBoxRock);
            this.groupBox1.Controls.Add(this.btnScissors);
            this.groupBox1.Controls.Add(this.btnPaper);
            this.groupBox1.Controls.Add(this.btnRock);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Choice:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnScissors
            // 
            this.btnScissors.AutoSize = true;
            this.btnScissors.Location = new System.Drawing.Point(7, 206);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(14, 13);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.TabStop = true;
            this.btnScissors.UseVisualStyleBackColor = true;
            // 
            // btnPaper
            // 
            this.btnPaper.AutoSize = true;
            this.btnPaper.Location = new System.Drawing.Point(6, 110);
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
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(13, 333);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(192, 59);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // pcBoxRock
            // 
            this.pcBoxRock.Image = global::Rock_Paper_Scissors.Properties.Resources.rock;
            this.pcBoxRock.Location = new System.Drawing.Point(28, 20);
            this.pcBoxRock.Name = "pcBoxRock";
            this.pcBoxRock.Size = new System.Drawing.Size(148, 81);
            this.pcBoxRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxRock.TabIndex = 3;
            this.pcBoxRock.TabStop = false;
            // 
            // pcBoxPaper
            // 
            this.pcBoxPaper.Image = global::Rock_Paper_Scissors.Properties.Resources.paper;
            this.pcBoxPaper.Location = new System.Drawing.Point(28, 110);
            this.pcBoxPaper.Name = "pcBoxPaper";
            this.pcBoxPaper.Size = new System.Drawing.Size(148, 81);
            this.pcBoxPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxPaper.TabIndex = 4;
            this.pcBoxPaper.TabStop = false;
            // 
            // pcBoxScissors
            // 
            this.pcBoxScissors.Image = global::Rock_Paper_Scissors.Properties.Resources.scissors;
            this.pcBoxScissors.Location = new System.Drawing.Point(28, 206);
            this.pcBoxScissors.Name = "pcBoxScissors";
            this.pcBoxScissors.Size = new System.Drawing.Size(148, 81);
            this.pcBoxScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxScissors.TabIndex = 5;
            this.pcBoxScissors.TabStop = false;
            // 
            // PlayerChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(219, 404);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PlayerChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Choice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxScissors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnScissors;
        private System.Windows.Forms.RadioButton btnPaper;
        private System.Windows.Forms.RadioButton btnRock;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.PictureBox pcBoxScissors;
        private System.Windows.Forms.PictureBox pcBoxPaper;
        private System.Windows.Forms.PictureBox pcBoxRock;
    }
}