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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnRoll = new Button();
            label1 = new Label();
            picDi5 = new PictureBox();
            picDi1 = new PictureBox();
            picDi2 = new PictureBox();
            picDi3 = new PictureBox();
            picDi4 = new PictureBox();
            lblHoverTip = new Label();
            panel1 = new Panel();
            lblGT = new Label();
            lblTotalBottom = new Label();
            lblYahtzeeBonus = new Label();
            lblChance = new Label();
            lblYahtzee = new Label();
            lblLarge = new Label();
            lblSmall = new Label();
            lblFH = new Label();
            lbl4K = new Label();
            lbl3K = new Label();
            lblTotalTop = new Label();
            lblTopBonus = new Label();
            lblSixes = new Label();
            lblFives = new Label();
            lblFours = new Label();
            lblThrees = new Label();
            lblTwos = new Label();
            lblOnes = new Label();
            scrBtnChance = new Button();
            scrBtnYzee = new Button();
            scrBtnLgStr = new Button();
            scrBtnSmStr = new Button();
            scrBtnFH = new Button();
            pictureBox5 = new PictureBox();
            scrBtn4K = new Button();
            scrBtn3K = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label20 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label19 = new Label();
            scrBtnSix = new Button();
            label13 = new Label();
            scrBtnFive = new Button();
            scrBtnFour = new Button();
            scrBtnThree = new Button();
            ScrBtnTwo = new Button();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            scrBtnOne = new Button();
            label2 = new Label();
            lblNumOfRolls = new Label();
            lblHeld1 = new Label();
            lblHeld2 = new Label();
            lblHeld3 = new Label();
            lblHeld4 = new Label();
            lblHeld5 = new Label();
            lblGameOver = new Label();
            lblBonusAnnounce = new Label();
            btnNew = new Button();
            ((System.ComponentModel.ISupportInitialize)picDi5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDi1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDi2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDi3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDi4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRoll
            // 
            btnRoll.BackColor = Color.DarkGreen;
            btnRoll.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoll.ForeColor = Color.GhostWhite;
            btnRoll.Location = new Point(213, 507);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(40, 35);
            btnRoll.TabIndex = 0;
            btnRoll.Text = "roll";
            btnRoll.UseVisualStyleBackColor = false;
            btnRoll.Click += btnRoll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 17);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // picDi5
            // 
            picDi5.BackColor = Color.Green;
            picDi5.BorderStyle = BorderStyle.Fixed3D;
            picDi5.Image = Resource1.blank;
            picDi5.Location = new Point(377, 464);
            picDi5.Name = "picDi5";
            picDi5.Size = new Size(35, 40);
            picDi5.TabIndex = 2;
            picDi5.TabStop = false;
            picDi5.Click += picDi5_Click;
            picDi5.MouseLeave += picDi1_MouseLeave;
            picDi5.MouseHover += picDi1_MouseHover;
            // 
            // picDi1
            // 
            picDi1.BackColor = Color.Green;
            picDi1.BorderStyle = BorderStyle.Fixed3D;
            picDi1.Image = Resource1.blank;
            picDi1.Location = new Point(213, 464);
            picDi1.Name = "picDi1";
            picDi1.Size = new Size(35, 40);
            picDi1.TabIndex = 3;
            picDi1.TabStop = false;
            picDi1.Click += picDi1_Click;
            picDi1.MouseLeave += picDi1_MouseLeave;
            picDi1.MouseHover += picDi1_MouseHover;
            // 
            // picDi2
            // 
            picDi2.BackColor = Color.Green;
            picDi2.BorderStyle = BorderStyle.Fixed3D;
            picDi2.Image = Resource1.blank;
            picDi2.Location = new Point(254, 464);
            picDi2.Name = "picDi2";
            picDi2.Size = new Size(35, 40);
            picDi2.TabIndex = 4;
            picDi2.TabStop = false;
            picDi2.Click += picDi2_Click;
            picDi2.MouseLeave += picDi1_MouseLeave;
            picDi2.MouseHover += picDi1_MouseHover;
            // 
            // picDi3
            // 
            picDi3.BackColor = Color.Green;
            picDi3.BorderStyle = BorderStyle.Fixed3D;
            picDi3.Image = Resource1.blank;
            picDi3.Location = new Point(295, 464);
            picDi3.Name = "picDi3";
            picDi3.Size = new Size(35, 40);
            picDi3.TabIndex = 5;
            picDi3.TabStop = false;
            picDi3.Click += picDi3_Click;
            picDi3.MouseLeave += picDi1_MouseLeave;
            picDi3.MouseHover += picDi1_MouseHover;
            // 
            // picDi4
            // 
            picDi4.BackColor = Color.Green;
            picDi4.BorderStyle = BorderStyle.Fixed3D;
            picDi4.Image = Resource1.blank;
            picDi4.Location = new Point(336, 464);
            picDi4.Name = "picDi4";
            picDi4.Size = new Size(35, 40);
            picDi4.TabIndex = 6;
            picDi4.TabStop = false;
            picDi4.Click += picDi4_Click;
            picDi4.MouseLeave += picDi1_MouseLeave;
            picDi4.MouseHover += picDi1_MouseHover;
            // 
            // lblHoverTip
            // 
            lblHoverTip.BackColor = Color.Thistle;
            lblHoverTip.BorderStyle = BorderStyle.FixedSingle;
            lblHoverTip.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoverTip.ForeColor = Color.Blue;
            lblHoverTip.Location = new Point(290, 507);
            lblHoverTip.Name = "lblHoverTip";
            lblHoverTip.Size = new Size(89, 16);
            lblHoverTip.TabIndex = 7;
            lblHoverTip.Text = "Click to Hold";
            lblHoverTip.TextAlign = ContentAlignment.MiddleLeft;
            lblHoverTip.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(lblGT);
            panel1.Controls.Add(lblTotalBottom);
            panel1.Controls.Add(lblYahtzeeBonus);
            panel1.Controls.Add(lblChance);
            panel1.Controls.Add(lblYahtzee);
            panel1.Controls.Add(lblLarge);
            panel1.Controls.Add(lblSmall);
            panel1.Controls.Add(lblFH);
            panel1.Controls.Add(lbl4K);
            panel1.Controls.Add(lbl3K);
            panel1.Controls.Add(lblTotalTop);
            panel1.Controls.Add(lblTopBonus);
            panel1.Controls.Add(lblSixes);
            panel1.Controls.Add(lblFives);
            panel1.Controls.Add(lblFours);
            panel1.Controls.Add(lblThrees);
            panel1.Controls.Add(lblTwos);
            panel1.Controls.Add(lblOnes);
            panel1.Controls.Add(scrBtnChance);
            panel1.Controls.Add(scrBtnYzee);
            panel1.Controls.Add(scrBtnLgStr);
            panel1.Controls.Add(scrBtnSmStr);
            panel1.Controls.Add(scrBtnFH);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(scrBtn4K);
            panel1.Controls.Add(scrBtn3K);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(scrBtnSix);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(scrBtnFive);
            panel1.Controls.Add(scrBtnFour);
            panel1.Controls.Add(scrBtnThree);
            panel1.Controls.Add(ScrBtnTwo);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(scrBtnOne);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(15, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 528);
            panel1.TabIndex = 8;
            // 
            // lblGT
            // 
            lblGT.BackColor = SystemColors.Control;
            lblGT.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGT.ForeColor = Color.Black;
            lblGT.Location = new Point(139, 496);
            lblGT.Name = "lblGT";
            lblGT.Size = new Size(45, 28);
            lblGT.TabIndex = 54;
            lblGT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalBottom
            // 
            lblTotalBottom.BackColor = SystemColors.Control;
            lblTotalBottom.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalBottom.ForeColor = Color.Black;
            lblTotalBottom.Location = new Point(139, 467);
            lblTotalBottom.Name = "lblTotalBottom";
            lblTotalBottom.Size = new Size(45, 28);
            lblTotalBottom.TabIndex = 53;
            lblTotalBottom.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblYahtzeeBonus
            // 
            lblYahtzeeBonus.BackColor = Color.WhiteSmoke;
            lblYahtzeeBonus.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblYahtzeeBonus.ForeColor = Color.Purple;
            lblYahtzeeBonus.Location = new Point(139, 438);
            lblYahtzeeBonus.Name = "lblYahtzeeBonus";
            lblYahtzeeBonus.Size = new Size(45, 28);
            lblYahtzeeBonus.TabIndex = 52;
            lblYahtzeeBonus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblChance
            // 
            lblChance.BackColor = SystemColors.Control;
            lblChance.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblChance.ForeColor = Color.Blue;
            lblChance.Location = new Point(139, 409);
            lblChance.Name = "lblChance";
            lblChance.Size = new Size(45, 28);
            lblChance.TabIndex = 51;
            lblChance.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblYahtzee
            // 
            lblYahtzee.BackColor = SystemColors.Control;
            lblYahtzee.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblYahtzee.ForeColor = Color.Blue;
            lblYahtzee.Location = new Point(139, 380);
            lblYahtzee.Name = "lblYahtzee";
            lblYahtzee.Size = new Size(45, 28);
            lblYahtzee.TabIndex = 50;
            lblYahtzee.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLarge
            // 
            lblLarge.BackColor = SystemColors.Control;
            lblLarge.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLarge.ForeColor = Color.Blue;
            lblLarge.Location = new Point(139, 351);
            lblLarge.Name = "lblLarge";
            lblLarge.Size = new Size(45, 28);
            lblLarge.TabIndex = 49;
            lblLarge.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSmall
            // 
            lblSmall.BackColor = SystemColors.Control;
            lblSmall.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSmall.ForeColor = Color.Blue;
            lblSmall.Location = new Point(139, 322);
            lblSmall.Name = "lblSmall";
            lblSmall.Size = new Size(45, 28);
            lblSmall.TabIndex = 48;
            lblSmall.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFH
            // 
            lblFH.BackColor = SystemColors.Control;
            lblFH.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFH.ForeColor = Color.Blue;
            lblFH.Location = new Point(139, 293);
            lblFH.Name = "lblFH";
            lblFH.Size = new Size(45, 28);
            lblFH.TabIndex = 47;
            lblFH.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl4K
            // 
            lbl4K.BackColor = SystemColors.Control;
            lbl4K.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4K.ForeColor = Color.Blue;
            lbl4K.Location = new Point(139, 264);
            lbl4K.Name = "lbl4K";
            lbl4K.Size = new Size(45, 28);
            lbl4K.TabIndex = 46;
            lbl4K.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl3K
            // 
            lbl3K.BackColor = SystemColors.Control;
            lbl3K.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3K.ForeColor = Color.Blue;
            lbl3K.Location = new Point(139, 235);
            lbl3K.Name = "lbl3K";
            lbl3K.Size = new Size(45, 28);
            lbl3K.TabIndex = 45;
            lbl3K.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalTop
            // 
            lblTotalTop.BackColor = SystemColors.Control;
            lblTotalTop.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalTop.ForeColor = Color.Black;
            lblTotalTop.Location = new Point(139, 206);
            lblTotalTop.Name = "lblTotalTop";
            lblTotalTop.Size = new Size(45, 28);
            lblTotalTop.TabIndex = 44;
            lblTotalTop.TextAlign = ContentAlignment.MiddleRight;
            lblTotalTop.MouseDoubleClick += lblTotalTop_MouseDoubleClick;
            // 
            // lblTopBonus
            // 
            lblTopBonus.BackColor = SystemColors.Control;
            lblTopBonus.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopBonus.ForeColor = Color.Black;
            lblTopBonus.Location = new Point(139, 177);
            lblTopBonus.Name = "lblTopBonus";
            lblTopBonus.Size = new Size(45, 28);
            lblTopBonus.TabIndex = 43;
            lblTopBonus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSixes
            // 
            lblSixes.BackColor = SystemColors.Control;
            lblSixes.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSixes.ForeColor = Color.Blue;
            lblSixes.Location = new Point(139, 148);
            lblSixes.Name = "lblSixes";
            lblSixes.Size = new Size(45, 28);
            lblSixes.TabIndex = 42;
            lblSixes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFives
            // 
            lblFives.BackColor = SystemColors.Control;
            lblFives.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFives.ForeColor = Color.Blue;
            lblFives.Location = new Point(139, 119);
            lblFives.Name = "lblFives";
            lblFives.Size = new Size(45, 28);
            lblFives.TabIndex = 41;
            lblFives.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFours
            // 
            lblFours.BackColor = SystemColors.Control;
            lblFours.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFours.ForeColor = Color.Blue;
            lblFours.Location = new Point(139, 90);
            lblFours.Name = "lblFours";
            lblFours.Size = new Size(45, 28);
            lblFours.TabIndex = 40;
            lblFours.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblThrees
            // 
            lblThrees.BackColor = SystemColors.Control;
            lblThrees.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblThrees.ForeColor = Color.Blue;
            lblThrees.Location = new Point(139, 61);
            lblThrees.Name = "lblThrees";
            lblThrees.Size = new Size(45, 28);
            lblThrees.TabIndex = 39;
            lblThrees.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTwos
            // 
            lblTwos.BackColor = SystemColors.Control;
            lblTwos.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTwos.ForeColor = Color.Blue;
            lblTwos.Location = new Point(139, 32);
            lblTwos.Name = "lblTwos";
            lblTwos.Size = new Size(45, 28);
            lblTwos.TabIndex = 38;
            lblTwos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblOnes
            // 
            lblOnes.BackColor = SystemColors.Control;
            lblOnes.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOnes.ForeColor = Color.Blue;
            lblOnes.Location = new Point(139, 3);
            lblOnes.Name = "lblOnes";
            lblOnes.Size = new Size(45, 28);
            lblOnes.TabIndex = 37;
            lblOnes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // scrBtnChance
            // 
            scrBtnChance.BackColor = Color.Green;
            scrBtnChance.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            scrBtnChance.ForeColor = Color.White;
            scrBtnChance.Location = new Point(3, 411);
            scrBtnChance.Name = "scrBtnChance";
            scrBtnChance.Size = new Size(28, 28);
            scrBtnChance.TabIndex = 36;
            scrBtnChance.UseVisualStyleBackColor = false;
            scrBtnChance.Click += scrBtnChance_Click;
            // 
            // scrBtnYzee
            // 
            scrBtnYzee.BackColor = Color.Green;
            scrBtnYzee.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            scrBtnYzee.ForeColor = Color.White;
            scrBtnYzee.Location = new Point(3, 380);
            scrBtnYzee.Name = "scrBtnYzee";
            scrBtnYzee.Size = new Size(28, 28);
            scrBtnYzee.TabIndex = 35;
            scrBtnYzee.UseVisualStyleBackColor = false;
            scrBtnYzee.Click += scrBtnYzee_Click;
            // 
            // scrBtnLgStr
            // 
            scrBtnLgStr.BackColor = Color.Green;
            scrBtnLgStr.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            scrBtnLgStr.ForeColor = Color.White;
            scrBtnLgStr.Location = new Point(3, 353);
            scrBtnLgStr.Name = "scrBtnLgStr";
            scrBtnLgStr.Size = new Size(28, 28);
            scrBtnLgStr.TabIndex = 34;
            scrBtnLgStr.UseVisualStyleBackColor = false;
            scrBtnLgStr.Click += scrBtnLgStr_Click;
            // 
            // scrBtnSmStr
            // 
            scrBtnSmStr.BackColor = Color.Green;
            scrBtnSmStr.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            scrBtnSmStr.ForeColor = Color.White;
            scrBtnSmStr.Location = new Point(3, 324);
            scrBtnSmStr.Name = "scrBtnSmStr";
            scrBtnSmStr.Size = new Size(28, 28);
            scrBtnSmStr.TabIndex = 33;
            scrBtnSmStr.UseVisualStyleBackColor = false;
            scrBtnSmStr.Click += scrBtnSmStr_Click;
            // 
            // scrBtnFH
            // 
            scrBtnFH.BackColor = Color.Green;
            scrBtnFH.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            scrBtnFH.ForeColor = Color.White;
            scrBtnFH.Location = new Point(3, 293);
            scrBtnFH.Name = "scrBtnFH";
            scrBtnFH.Size = new Size(28, 28);
            scrBtnFH.TabIndex = 32;
            scrBtnFH.UseVisualStyleBackColor = false;
            scrBtnFH.Click += scrBtnFH_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Resource1.arrow_right_241;
            pictureBox5.Location = new Point(3, 441);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(26, 27);
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // scrBtn4K
            // 
            scrBtn4K.BackColor = Color.Green;
            scrBtn4K.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            scrBtn4K.ForeColor = Color.White;
            scrBtn4K.Location = new Point(2, 265);
            scrBtn4K.Name = "scrBtn4K";
            scrBtn4K.Size = new Size(28, 28);
            scrBtn4K.TabIndex = 30;
            scrBtn4K.UseVisualStyleBackColor = false;
            scrBtn4K.Click += scrBtn4K_Click;
            // 
            // scrBtn3K
            // 
            scrBtn3K.BackColor = Color.Green;
            scrBtn3K.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            scrBtn3K.ForeColor = Color.White;
            scrBtn3K.Location = new Point(2, 236);
            scrBtn3K.Name = "scrBtn3K";
            scrBtn3K.Size = new Size(28, 28);
            scrBtn3K.TabIndex = 29;
            scrBtn3K.UseVisualStyleBackColor = false;
            scrBtn3K.Click += scrBtn3K_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Resource1.arrow_right_241;
            pictureBox4.Location = new Point(3, 498);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(26, 27);
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resource1.arrow_right_241;
            pictureBox3.Location = new Point(3, 469);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 27);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // label20
            // 
            label20.BackColor = SystemColors.Control;
            label20.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.DarkGreen;
            label20.Location = new Point(31, 264);
            label20.Name = "label20";
            label20.Size = new Size(106, 28);
            label20.TabIndex = 26;
            label20.Text = "4 of a Kind";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.arrow_right_241;
            pictureBox2.Location = new Point(3, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 27);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.arrow_right_241;
            pictureBox1.Location = new Point(3, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 27);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label19
            // 
            label19.BackColor = SystemColors.Control;
            label19.Font = new Font("Comic Sans MS", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.Green;
            label19.Location = new Point(76, 177);
            label19.Name = "label19";
            label19.Size = new Size(61, 28);
            label19.TabIndex = 23;
            label19.Text = "35 if top is 63 or more";
            // 
            // scrBtnSix
            // 
            scrBtnSix.BackColor = Color.Green;
            scrBtnSix.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            scrBtnSix.ForeColor = Color.White;
            scrBtnSix.Location = new Point(1, 148);
            scrBtnSix.Name = "scrBtnSix";
            scrBtnSix.Size = new Size(28, 28);
            scrBtnSix.TabIndex = 22;
            scrBtnSix.UseVisualStyleBackColor = false;
            scrBtnSix.Click += scrBtnSix_Click;
            // 
            // label13
            // 
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkGreen;
            label13.Location = new Point(31, 438);
            label13.Name = "label13";
            label13.Size = new Size(106, 28);
            label13.TabIndex = 12;
            label13.Text = "Yahtzee Bonus";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // scrBtnFive
            // 
            scrBtnFive.BackColor = Color.Green;
            scrBtnFive.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            scrBtnFive.ForeColor = Color.White;
            scrBtnFive.Location = new Point(1, 119);
            scrBtnFive.Name = "scrBtnFive";
            scrBtnFive.Size = new Size(28, 28);
            scrBtnFive.TabIndex = 21;
            scrBtnFive.UseVisualStyleBackColor = false;
            scrBtnFive.Click += scrBtnFive_Click;
            // 
            // scrBtnFour
            // 
            scrBtnFour.BackColor = Color.Green;
            scrBtnFour.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            scrBtnFour.ForeColor = Color.White;
            scrBtnFour.Location = new Point(1, 90);
            scrBtnFour.Name = "scrBtnFour";
            scrBtnFour.Size = new Size(28, 28);
            scrBtnFour.TabIndex = 20;
            scrBtnFour.UseVisualStyleBackColor = false;
            scrBtnFour.Click += scrBtnFour_Click;
            // 
            // scrBtnThree
            // 
            scrBtnThree.BackColor = Color.Green;
            scrBtnThree.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            scrBtnThree.ForeColor = Color.White;
            scrBtnThree.Location = new Point(1, 60);
            scrBtnThree.Name = "scrBtnThree";
            scrBtnThree.Size = new Size(28, 28);
            scrBtnThree.TabIndex = 19;
            scrBtnThree.UseVisualStyleBackColor = false;
            scrBtnThree.Click += scrBtnThree_Click;
            // 
            // ScrBtnTwo
            // 
            ScrBtnTwo.BackColor = Color.Green;
            ScrBtnTwo.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ScrBtnTwo.ForeColor = Color.White;
            ScrBtnTwo.Location = new Point(1, 33);
            ScrBtnTwo.Name = "ScrBtnTwo";
            ScrBtnTwo.Size = new Size(28, 28);
            ScrBtnTwo.TabIndex = 18;
            ScrBtnTwo.UseVisualStyleBackColor = false;
            ScrBtnTwo.Click += ScrBtnTwo_Click;
            // 
            // label18
            // 
            label18.BackColor = SystemColors.Control;
            label18.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.DarkGreen;
            label18.Location = new Point(31, 496);
            label18.Name = "label18";
            label18.Size = new Size(106, 28);
            label18.TabIndex = 17;
            label18.Text = "Grand Total";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            label17.BackColor = SystemColors.Control;
            label17.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.DarkGreen;
            label17.Location = new Point(31, 235);
            label17.Name = "label17";
            label17.Size = new Size(106, 28);
            label17.TabIndex = 16;
            label17.Text = "3 of a Kind";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.BackColor = SystemColors.Control;
            label16.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.DarkGreen;
            label16.Location = new Point(31, 409);
            label16.Name = "label16";
            label16.Size = new Size(106, 28);
            label16.TabIndex = 15;
            label16.Text = "Chance";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.BackColor = SystemColors.Control;
            label15.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.DarkGreen;
            label15.Location = new Point(31, 467);
            label15.Name = "label15";
            label15.Size = new Size(106, 28);
            label15.TabIndex = 14;
            label15.Text = "Total Bottom";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.BackColor = SystemColors.Control;
            label14.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.DarkGreen;
            label14.Location = new Point(31, 380);
            label14.Name = "label14";
            label14.Size = new Size(106, 28);
            label14.TabIndex = 13;
            label14.Text = "Yahtzee";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.Control;
            label12.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DarkGreen;
            label12.Location = new Point(31, 351);
            label12.Name = "label12";
            label12.Size = new Size(106, 28);
            label12.TabIndex = 11;
            label12.Text = "Lg. Straight";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(31, 322);
            label11.Name = "label11";
            label11.Size = new Size(106, 28);
            label11.TabIndex = 10;
            label11.Text = "Sm. Straight";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(31, 293);
            label10.Name = "label10";
            label10.Size = new Size(106, 28);
            label10.TabIndex = 9;
            label10.Text = "Full House";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(31, 32);
            label9.Name = "label9";
            label9.Size = new Size(106, 28);
            label9.TabIndex = 8;
            label9.Text = "Twos";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(31, 61);
            label8.Name = "label8";
            label8.Size = new Size(106, 28);
            label8.TabIndex = 7;
            label8.Text = "Threes";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(31, 90);
            label7.Name = "label7";
            label7.Size = new Size(106, 28);
            label7.TabIndex = 6;
            label7.Text = "Fours";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(31, 119);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 5;
            label6.Text = "Fives";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(31, 148);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 4;
            label5.Text = "Sixes";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(31, 177);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 3;
            label4.Text = "Bonus";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(31, 206);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 2;
            label3.Text = "Total Top";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // scrBtnOne
            // 
            scrBtnOne.BackColor = Color.Green;
            scrBtnOne.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            scrBtnOne.ForeColor = Color.White;
            scrBtnOne.Location = new Point(1, 4);
            scrBtnOne.Name = "scrBtnOne";
            scrBtnOne.Size = new Size(28, 28);
            scrBtnOne.TabIndex = 1;
            scrBtnOne.UseVisualStyleBackColor = false;
            scrBtnOne.Click += scrBtnOne_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(31, 3);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 0;
            label2.Text = "Ones";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNumOfRolls
            // 
            lblNumOfRolls.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumOfRolls.Location = new Point(259, 512);
            lblNumOfRolls.Name = "lblNumOfRolls";
            lblNumOfRolls.Size = new Size(25, 22);
            lblNumOfRolls.TabIndex = 9;
            lblNumOfRolls.Text = "3";
            lblNumOfRolls.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblHeld1
            // 
            lblHeld1.BackColor = Color.Yellow;
            lblHeld1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeld1.ForeColor = Color.Purple;
            lblHeld1.Location = new Point(213, 445);
            lblHeld1.Name = "lblHeld1";
            lblHeld1.Size = new Size(35, 16);
            lblHeld1.TabIndex = 10;
            lblHeld1.Text = "Held";
            lblHeld1.TextAlign = ContentAlignment.MiddleCenter;
            lblHeld1.Visible = false;
            // 
            // lblHeld2
            // 
            lblHeld2.BackColor = Color.Yellow;
            lblHeld2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeld2.ForeColor = Color.Purple;
            lblHeld2.Location = new Point(254, 445);
            lblHeld2.Name = "lblHeld2";
            lblHeld2.Size = new Size(35, 16);
            lblHeld2.TabIndex = 11;
            lblHeld2.Text = "Held";
            lblHeld2.TextAlign = ContentAlignment.MiddleCenter;
            lblHeld2.Visible = false;
            // 
            // lblHeld3
            // 
            lblHeld3.BackColor = Color.Yellow;
            lblHeld3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeld3.ForeColor = Color.Purple;
            lblHeld3.Location = new Point(295, 445);
            lblHeld3.Name = "lblHeld3";
            lblHeld3.Size = new Size(35, 16);
            lblHeld3.TabIndex = 12;
            lblHeld3.Text = "Held";
            lblHeld3.TextAlign = ContentAlignment.MiddleCenter;
            lblHeld3.Visible = false;
            // 
            // lblHeld4
            // 
            lblHeld4.BackColor = Color.Yellow;
            lblHeld4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeld4.ForeColor = Color.Purple;
            lblHeld4.Location = new Point(336, 445);
            lblHeld4.Name = "lblHeld4";
            lblHeld4.Size = new Size(35, 16);
            lblHeld4.TabIndex = 13;
            lblHeld4.Text = "Held";
            lblHeld4.TextAlign = ContentAlignment.MiddleCenter;
            lblHeld4.Visible = false;
            // 
            // lblHeld5
            // 
            lblHeld5.BackColor = Color.Yellow;
            lblHeld5.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeld5.ForeColor = Color.Purple;
            lblHeld5.Location = new Point(377, 445);
            lblHeld5.Name = "lblHeld5";
            lblHeld5.Size = new Size(35, 16);
            lblHeld5.TabIndex = 14;
            lblHeld5.Text = "Held";
            lblHeld5.TextAlign = ContentAlignment.MiddleCenter;
            lblHeld5.Visible = false;
            // 
            // lblGameOver
            // 
            lblGameOver.BackColor = Color.Gainsboro;
            lblGameOver.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGameOver.ForeColor = Color.ForestGreen;
            lblGameOver.Location = new Point(231, 80);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(178, 20);
            lblGameOver.TabIndex = 16;
            lblGameOver.Text = "Final Score 888";
            lblGameOver.TextAlign = ContentAlignment.BottomCenter;
            lblGameOver.Visible = false;
            // 
            // lblBonusAnnounce
            // 
            lblBonusAnnounce.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBonusAnnounce.ForeColor = SystemColors.Highlight;
            lblBonusAnnounce.Location = new Point(205, 198);
            lblBonusAnnounce.Name = "lblBonusAnnounce";
            lblBonusAnnounce.Size = new Size(193, 23);
            lblBonusAnnounce.TabIndex = 15;
            lblBonusAnnounce.TextAlign = ContentAlignment.MiddleLeft;
            lblBonusAnnounce.Visible = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.HotTrack;
            btnNew.FlatStyle = FlatStyle.Popup;
            btnNew.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.ForeColor = SystemColors.ButtonFace;
            btnNew.Location = new Point(293, 18);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 30);
            btnNew.TabIndex = 17;
            btnNew.Text = "New Game";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Visible = false;
            btnNew.Click += btnNew_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(421, 557);
            Controls.Add(btnNew);
            Controls.Add(lblGameOver);
            Controls.Add(lblBonusAnnounce);
            Controls.Add(lblHeld5);
            Controls.Add(lblHeld4);
            Controls.Add(lblHeld3);
            Controls.Add(lblHeld2);
            Controls.Add(lblHeld1);
            Controls.Add(lblNumOfRolls);
            Controls.Add(panel1);
            Controls.Add(lblHoverTip);
            Controls.Add(picDi4);
            Controls.Add(picDi3);
            Controls.Add(picDi2);
            Controls.Add(picDi1);
            Controls.Add(picDi5);
            Controls.Add(label1);
            Controls.Add(btnRoll);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SolitairZee © Professor Chaswick";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picDi5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDi1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDi2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDi3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDi4).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRoll;
        private Label label1;
        private PictureBox picDi5;
        private PictureBox picDi1;
        private PictureBox picDi2;
        private PictureBox picDi3;
        private PictureBox picDi4;
        private Label lblHoverTip;
        private Panel panel1;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button scrBtnOne;
        private Label label2;
        private Button scrBtnFive;
        private Button scrBtnFour;
        private Button scrBtnThree;
        private Button ScrBtnTwo;
        private PictureBox pictureBox1;
        private Label label19;
        private Button scrBtnSix;
        private Button scrBtnChance;
        private Button scrBtnYzee;
        private Button scrBtnLgStr;
        private Button scrBtnSmStr;
        private Button scrBtnFH;
        private PictureBox pictureBox5;
        private Button scrBtn4K;
        private Button scrBtn3K;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label20;
        private PictureBox pictureBox2;
        private Label lblOnes;
        private Label lblGT;
        private Label lblTotalBottom;
        private Label lblYahtzeeBonus;
        private Label lblChance;
        private Label lblYahtzee;
        private Label lblLarge;
        private Label lblSmall;
        private Label lblFH;
        private Label lbl4K;
        private Label lbl3K;
        private Label lblTotalTop;
        private Label lblTopBonus;
        private Label lblFives;
        private Label lblFours;
        private Label lblThrees;
        private Label lblTwos;
        private Label lblSixes;
        private Label lblNumOfRolls;
        private Label lblHeld1;
        private Label lblHeld2;
        private Label lblHeld3;
        private Label lblHeld4;
        private Label lblHeld5;
        private Label lblGameOver;
        private Label lblBonusAnnounce;
        private Button btnNew;
    }
}