namespace Drink_Vending_Machine_Simulator
{
    partial class mainForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colaPictureBox = new System.Windows.Forms.PictureBox();
            this.colaQuantityLeftLabel = new System.Windows.Forms.Label();
            this.dirinksLeftLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lemonLimePictureBox = new System.Windows.Forms.PictureBox();
            this.lemonQuantityLeftLabel = new System.Windows.Forms.Label();
            this.drinksLeftLabel2 = new System.Windows.Forms.Label();
            this.priceLabel2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rootBeerPictureBox = new System.Windows.Forms.PictureBox();
            this.beerQuantityLeftLabel = new System.Windows.Forms.Label();
            this.drinksLeftLabel4 = new System.Windows.Forms.Label();
            this.priceLabel4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grapeSodaPictureBox = new System.Windows.Forms.PictureBox();
            this.grapeQuantityLeftLabel = new System.Windows.Forms.Label();
            this.drinksLeftLabel5 = new System.Windows.Forms.Label();
            this.priceLabel5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.creamSodaPictureBox = new System.Windows.Forms.PictureBox();
            this.sodaQuantityLeftLabel = new System.Windows.Forms.Label();
            this.drinksLabelLeft3 = new System.Windows.Forms.Label();
            this.priceLabel3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.infoTotalSalesLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimePictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPictureBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPictureBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(337, 419);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 45);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(149, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(215, 71);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Select a Drink";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.colaPictureBox);
            this.groupBox1.Controls.Add(this.colaQuantityLeftLabel);
            this.groupBox1.Controls.Add(this.dirinksLeftLabel);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // colaPictureBox
            // 
            this.colaPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colaPictureBox.Image = global::Drink_Vending_Machine_Simulator.Properties.Resources.Cola;
            this.colaPictureBox.Location = new System.Drawing.Point(7, 19);
            this.colaPictureBox.Name = "colaPictureBox";
            this.colaPictureBox.Size = new System.Drawing.Size(125, 69);
            this.colaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colaPictureBox.TabIndex = 3;
            this.colaPictureBox.TabStop = false;
            this.colaPictureBox.Click += new System.EventHandler(this.colaPictureBox_Click);
            // 
            // colaQuantityLeftLabel
            // 
            this.colaQuantityLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaQuantityLeftLabel.Location = new System.Drawing.Point(162, 68);
            this.colaQuantityLeftLabel.Name = "colaQuantityLeftLabel";
            this.colaQuantityLeftLabel.Size = new System.Drawing.Size(72, 20);
            this.colaQuantityLeftLabel.TabIndex = 2;
            this.colaQuantityLeftLabel.Text = "20";
            this.colaQuantityLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dirinksLeftLabel
            // 
            this.dirinksLeftLabel.AutoSize = true;
            this.dirinksLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirinksLeftLabel.Location = new System.Drawing.Point(159, 42);
            this.dirinksLeftLabel.Name = "dirinksLeftLabel";
            this.dirinksLeftLabel.Size = new System.Drawing.Size(75, 17);
            this.dirinksLeftLabel.TabIndex = 1;
            this.dirinksLeftLabel.Text = "Drinks left:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(172, 16);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(49, 17);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "$1.00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lemonLimePictureBox);
            this.groupBox3.Controls.Add(this.lemonQuantityLeftLabel);
            this.groupBox3.Controls.Add(this.drinksLeftLabel2);
            this.groupBox3.Controls.Add(this.priceLabel2);
            this.groupBox3.Location = new System.Drawing.Point(12, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // lemonLimePictureBox
            // 
            this.lemonLimePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lemonLimePictureBox.Image = global::Drink_Vending_Machine_Simulator.Properties.Resources.LemonLime;
            this.lemonLimePictureBox.Location = new System.Drawing.Point(8, 19);
            this.lemonLimePictureBox.Name = "lemonLimePictureBox";
            this.lemonLimePictureBox.Size = new System.Drawing.Size(125, 69);
            this.lemonLimePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lemonLimePictureBox.TabIndex = 3;
            this.lemonLimePictureBox.TabStop = false;
            this.lemonLimePictureBox.Click += new System.EventHandler(this.lemonLimePictureBox_Click);
            // 
            // lemonQuantityLeftLabel
            // 
            this.lemonQuantityLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemonQuantityLeftLabel.Location = new System.Drawing.Point(163, 68);
            this.lemonQuantityLeftLabel.Name = "lemonQuantityLeftLabel";
            this.lemonQuantityLeftLabel.Size = new System.Drawing.Size(72, 20);
            this.lemonQuantityLeftLabel.TabIndex = 2;
            this.lemonQuantityLeftLabel.Text = "20";
            this.lemonQuantityLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksLeftLabel2
            // 
            this.drinksLeftLabel2.AutoSize = true;
            this.drinksLeftLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLeftLabel2.Location = new System.Drawing.Point(160, 42);
            this.drinksLeftLabel2.Name = "drinksLeftLabel2";
            this.drinksLeftLabel2.Size = new System.Drawing.Size(75, 17);
            this.drinksLeftLabel2.TabIndex = 1;
            this.drinksLeftLabel2.Text = "Drinks left:";
            // 
            // priceLabel2
            // 
            this.priceLabel2.AutoSize = true;
            this.priceLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel2.Location = new System.Drawing.Point(173, 16);
            this.priceLabel2.Name = "priceLabel2";
            this.priceLabel2.Size = new System.Drawing.Size(49, 17);
            this.priceLabel2.TabIndex = 0;
            this.priceLabel2.Text = "$1.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rootBeerPictureBox);
            this.groupBox2.Controls.Add(this.beerQuantityLeftLabel);
            this.groupBox2.Controls.Add(this.drinksLeftLabel4);
            this.groupBox2.Controls.Add(this.priceLabel4);
            this.groupBox2.Location = new System.Drawing.Point(261, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // rootBeerPictureBox
            // 
            this.rootBeerPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rootBeerPictureBox.Image = global::Drink_Vending_Machine_Simulator.Properties.Resources.RootBeer;
            this.rootBeerPictureBox.Location = new System.Drawing.Point(6, 19);
            this.rootBeerPictureBox.Name = "rootBeerPictureBox";
            this.rootBeerPictureBox.Size = new System.Drawing.Size(125, 69);
            this.rootBeerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rootBeerPictureBox.TabIndex = 3;
            this.rootBeerPictureBox.TabStop = false;
            this.rootBeerPictureBox.Click += new System.EventHandler(this.rootBeerPictureBox_Click);
            // 
            // beerQuantityLeftLabel
            // 
            this.beerQuantityLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beerQuantityLeftLabel.Location = new System.Drawing.Point(161, 68);
            this.beerQuantityLeftLabel.Name = "beerQuantityLeftLabel";
            this.beerQuantityLeftLabel.Size = new System.Drawing.Size(72, 20);
            this.beerQuantityLeftLabel.TabIndex = 2;
            this.beerQuantityLeftLabel.Text = "20";
            this.beerQuantityLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksLeftLabel4
            // 
            this.drinksLeftLabel4.AutoSize = true;
            this.drinksLeftLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLeftLabel4.Location = new System.Drawing.Point(161, 42);
            this.drinksLeftLabel4.Name = "drinksLeftLabel4";
            this.drinksLeftLabel4.Size = new System.Drawing.Size(75, 17);
            this.drinksLeftLabel4.TabIndex = 1;
            this.drinksLeftLabel4.Text = "Drinks left:";
            // 
            // priceLabel4
            // 
            this.priceLabel4.AutoSize = true;
            this.priceLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel4.Location = new System.Drawing.Point(174, 16);
            this.priceLabel4.Name = "priceLabel4";
            this.priceLabel4.Size = new System.Drawing.Size(49, 17);
            this.priceLabel4.TabIndex = 0;
            this.priceLabel4.Text = "$1.00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grapeSodaPictureBox);
            this.groupBox4.Controls.Add(this.grapeQuantityLeftLabel);
            this.groupBox4.Controls.Add(this.drinksLeftLabel5);
            this.groupBox4.Controls.Add(this.priceLabel5);
            this.groupBox4.Location = new System.Drawing.Point(261, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // grapeSodaPictureBox
            // 
            this.grapeSodaPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grapeSodaPictureBox.Image = global::Drink_Vending_Machine_Simulator.Properties.Resources.GrapeSoda;
            this.grapeSodaPictureBox.Location = new System.Drawing.Point(6, 19);
            this.grapeSodaPictureBox.Name = "grapeSodaPictureBox";
            this.grapeSodaPictureBox.Size = new System.Drawing.Size(125, 69);
            this.grapeSodaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grapeSodaPictureBox.TabIndex = 3;
            this.grapeSodaPictureBox.TabStop = false;
            this.grapeSodaPictureBox.Click += new System.EventHandler(this.grapeSodaPictureBox_Click);
            // 
            // grapeQuantityLeftLabel
            // 
            this.grapeQuantityLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grapeQuantityLeftLabel.Location = new System.Drawing.Point(164, 68);
            this.grapeQuantityLeftLabel.Name = "grapeQuantityLeftLabel";
            this.grapeQuantityLeftLabel.Size = new System.Drawing.Size(72, 20);
            this.grapeQuantityLeftLabel.TabIndex = 2;
            this.grapeQuantityLeftLabel.Text = "20";
            this.grapeQuantityLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksLeftLabel5
            // 
            this.drinksLeftLabel5.AutoSize = true;
            this.drinksLeftLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLeftLabel5.Location = new System.Drawing.Point(161, 42);
            this.drinksLeftLabel5.Name = "drinksLeftLabel5";
            this.drinksLeftLabel5.Size = new System.Drawing.Size(75, 17);
            this.drinksLeftLabel5.TabIndex = 1;
            this.drinksLeftLabel5.Text = "Drinks left:";
            // 
            // priceLabel5
            // 
            this.priceLabel5.AutoSize = true;
            this.priceLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel5.Location = new System.Drawing.Point(174, 16);
            this.priceLabel5.Name = "priceLabel5";
            this.priceLabel5.Size = new System.Drawing.Size(49, 17);
            this.priceLabel5.TabIndex = 0;
            this.priceLabel5.Text = "$1.50";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.creamSodaPictureBox);
            this.groupBox5.Controls.Add(this.sodaQuantityLeftLabel);
            this.groupBox5.Controls.Add(this.drinksLabelLeft3);
            this.groupBox5.Controls.Add(this.priceLabel3);
            this.groupBox5.Location = new System.Drawing.Point(12, 295);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 100);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // creamSodaPictureBox
            // 
            this.creamSodaPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creamSodaPictureBox.Image = global::Drink_Vending_Machine_Simulator.Properties.Resources.CreamSoda;
            this.creamSodaPictureBox.Location = new System.Drawing.Point(8, 19);
            this.creamSodaPictureBox.Name = "creamSodaPictureBox";
            this.creamSodaPictureBox.Size = new System.Drawing.Size(125, 69);
            this.creamSodaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.creamSodaPictureBox.TabIndex = 3;
            this.creamSodaPictureBox.TabStop = false;
            this.creamSodaPictureBox.Click += new System.EventHandler(this.creamSodaPictureBox_Click);
            // 
            // sodaQuantityLeftLabel
            // 
            this.sodaQuantityLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sodaQuantityLeftLabel.Location = new System.Drawing.Point(163, 70);
            this.sodaQuantityLeftLabel.Name = "sodaQuantityLeftLabel";
            this.sodaQuantityLeftLabel.Size = new System.Drawing.Size(72, 20);
            this.sodaQuantityLeftLabel.TabIndex = 2;
            this.sodaQuantityLeftLabel.Text = "20";
            this.sodaQuantityLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksLabelLeft3
            // 
            this.drinksLabelLeft3.AutoSize = true;
            this.drinksLabelLeft3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabelLeft3.Location = new System.Drawing.Point(160, 44);
            this.drinksLabelLeft3.Name = "drinksLabelLeft3";
            this.drinksLabelLeft3.Size = new System.Drawing.Size(75, 17);
            this.drinksLabelLeft3.TabIndex = 1;
            this.drinksLabelLeft3.Text = "Drinks left:";
            // 
            // priceLabel3
            // 
            this.priceLabel3.AutoSize = true;
            this.priceLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel3.Location = new System.Drawing.Point(173, 18);
            this.priceLabel3.Name = "priceLabel3";
            this.priceLabel3.Size = new System.Drawing.Size(49, 17);
            this.priceLabel3.TabIndex = 0;
            this.priceLabel3.Text = "$1.50";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.totalSalesLabel);
            this.groupBox6.Controls.Add(this.infoTotalSalesLabel);
            this.groupBox6.Location = new System.Drawing.Point(261, 295);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(242, 100);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesLabel.Location = new System.Drawing.Point(72, 48);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(100, 23);
            this.totalSalesLabel.TabIndex = 3;
            this.totalSalesLabel.Text = "$0.00";
            this.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoTotalSalesLabel
            // 
            this.infoTotalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTotalSalesLabel.Location = new System.Drawing.Point(47, 16);
            this.infoTotalSalesLabel.Name = "infoTotalSalesLabel";
            this.infoTotalSalesLabel.Size = new System.Drawing.Size(148, 32);
            this.infoTotalSalesLabel.TabIndex = 2;
            this.infoTotalSalesLabel.Text = "Total Sales:";
            this.infoTotalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(108, 419);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 45);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.resetButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(522, 476);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Drink Vending Machine Simulator";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimePictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPictureBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPictureBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox colaPictureBox;
        private System.Windows.Forms.Label colaQuantityLeftLabel;
        private System.Windows.Forms.Label dirinksLeftLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lemonQuantityLeftLabel;
        private System.Windows.Forms.Label drinksLeftLabel2;
        private System.Windows.Forms.Label priceLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label drinksLeftLabel4;
        private System.Windows.Forms.Label priceLabel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label grapeQuantityLeftLabel;
        private System.Windows.Forms.Label drinksLeftLabel5;
        private System.Windows.Forms.Label priceLabel5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox creamSodaPictureBox;
        private System.Windows.Forms.Label sodaQuantityLeftLabel;
        private System.Windows.Forms.Label drinksLabelLeft3;
        private System.Windows.Forms.Label priceLabel3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label infoTotalSalesLabel;
        private System.Windows.Forms.PictureBox lemonLimePictureBox;
        private System.Windows.Forms.PictureBox rootBeerPictureBox;
        private System.Windows.Forms.PictureBox grapeSodaPictureBox;
        private System.Windows.Forms.Label beerQuantityLeftLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

