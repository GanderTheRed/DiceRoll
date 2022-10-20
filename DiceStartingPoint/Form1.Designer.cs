namespace DiceStartingPoint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGuess = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDice3 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.picDice3 = new System.Windows.Forms.PictureBox();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.picDice1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRoll);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbGuess);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDice3);
            this.groupBox1.Controls.Add(this.lblDice2);
            this.groupBox1.Controls.Add(this.lblDice1);
            this.groupBox1.Controls.Add(this.picDice3);
            this.groupBox1.Controls.Add(this.picDice2);
            this.groupBox1.Controls.Add(this.picDice1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dice";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(99, 216);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(194, 51);
            this.btnRoll.TabIndex = 10;
            this.btnRoll.Text = "Roll!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(143, 350);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(84, 45);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "0 / 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "Correct / Incorrect";
            // 
            // cmbGuess
            // 
            this.cmbGuess.FormattingEnabled = true;
            this.cmbGuess.Items.AddRange(new object[] {
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
            "18"});
            this.cmbGuess.Location = new System.Drawing.Point(131, 187);
            this.cmbGuess.Name = "cmbGuess";
            this.cmbGuess.Size = new System.Drawing.Size(121, 23);
            this.cmbGuess.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Guess";
            // 
            // lblDice3
            // 
            this.lblDice3.AutoSize = true;
            this.lblDice3.Location = new System.Drawing.Point(313, 31);
            this.lblDice3.Name = "lblDice3";
            this.lblDice3.Size = new System.Drawing.Size(13, 15);
            this.lblDice3.TabIndex = 5;
            this.lblDice3.Text = "0";
            // 
            // lblDice2
            // 
            this.lblDice2.AutoSize = true;
            this.lblDice2.Location = new System.Drawing.Point(187, 31);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(13, 15);
            this.lblDice2.TabIndex = 4;
            this.lblDice2.Text = "0";
            this.lblDice2.Click += new System.EventHandler(this.lblDice2_Click);
            // 
            // lblDice1
            // 
            this.lblDice1.AutoSize = true;
            this.lblDice1.Location = new System.Drawing.Point(62, 31);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(13, 15);
            this.lblDice1.TabIndex = 3;
            this.lblDice1.Text = "0";
            // 
            // picDice3
            // 
            this.picDice3.Location = new System.Drawing.Point(258, 49);
            this.picDice3.Name = "picDice3";
            this.picDice3.Size = new System.Drawing.Size(120, 120);
            this.picDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice3.TabIndex = 2;
            this.picDice3.TabStop = false;
            // 
            // picDice2
            // 
            this.picDice2.Location = new System.Drawing.Point(132, 49);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(120, 120);
            this.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice2.TabIndex = 1;
            this.picDice2.TabStop = false;
            // 
            // picDice1
            // 
            this.picDice1.Location = new System.Drawing.Point(6, 49);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(120, 120);
            this.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice1.TabIndex = 0;
            this.picDice1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblDice3;
        private Label lblDice2;
        private Label lblDice1;
        private PictureBox picDice3;
        private PictureBox picDice2;
        private PictureBox picDice1;
        private ComboBox cmbGuess;
        private Label label1;
        private Button btnRoll;
        private Label lblScore;
        private Label label2;
    }
}