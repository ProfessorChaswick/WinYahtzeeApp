namespace WinYahtzee
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picDi5 = new System.Windows.Forms.PictureBox();
            this.picDi1 = new System.Windows.Forms.PictureBox();
            this.picDi2 = new System.Windows.Forms.PictureBox();
            this.picDi3 = new System.Windows.Forms.PictureBox();
            this.picDi4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDi5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDi3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDi4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(565, 546);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // picDi5
            // 
            this.picDi5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDi5.Location = new System.Drawing.Point(663, 505);
            this.picDi5.Name = "picDi5";
            this.picDi5.Size = new System.Drawing.Size(35, 35);
            this.picDi5.TabIndex = 2;
            this.picDi5.TabStop = false;
            // 
            // picDi1
            // 
            this.picDi1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDi1.Location = new System.Drawing.Point(499, 505);
            this.picDi1.Name = "picDi1";
            this.picDi1.Size = new System.Drawing.Size(35, 35);
            this.picDi1.TabIndex = 3;
            this.picDi1.TabStop = false;
            // 
            // picDi2
            // 
            this.picDi2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDi2.Location = new System.Drawing.Point(540, 505);
            this.picDi2.Name = "picDi2";
            this.picDi2.Size = new System.Drawing.Size(35, 35);
            this.picDi2.TabIndex = 4;
            this.picDi2.TabStop = false;
            // 
            // picDi3
            // 
            this.picDi3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDi3.Location = new System.Drawing.Point(581, 505);
            this.picDi3.Name = "picDi3";
            this.picDi3.Size = new System.Drawing.Size(35, 35);
            this.picDi3.TabIndex = 5;
            this.picDi3.TabStop = false;
            // 
            // picDi4
            // 
            this.picDi4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDi4.Location = new System.Drawing.Point(622, 505);
            this.picDi4.Name = "picDi4";
            this.picDi4.Size = new System.Drawing.Size(35, 35);
            this.picDi4.TabIndex = 6;
            this.picDi4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 569);
            this.Controls.Add(this.picDi4);
            this.Controls.Add(this.picDi3);
            this.Controls.Add(this.picDi2);
            this.Controls.Add(this.picDi1);
            this.Controls.Add(this.picDi5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Yahtzee © Professor Chaswick";
            ((System.ComponentModel.ISupportInitialize)(this.picDi5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDi3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDi4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRoll;
        private Label label1;
        private PictureBox picDi5;
        private PictureBox picDi1;
        private PictureBox picDi2;
        private PictureBox picDi3;
        private PictureBox picDi4;
    }
}