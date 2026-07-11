namespace Pizza
{
    partial class OrderJuiceForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.Amont = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.rbStrawberry = new System.Windows.Forms.RadioButton();
            this.rbCocktail = new System.Windows.Forms.RadioButton();
            this.rbMango = new System.Windows.Forms.RadioButton();
            this.rbOrange = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.numericUpDownAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.gbWhereToEat);
            this.panel1.Controls.Add(this.gbToppings);
            this.panel1.Controls.Add(this.gbSize);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(93, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 529);
            this.panel1.TabIndex = 0;
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.Transparent;
            this.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnNewUser.Location = new System.Drawing.Point(466, 689);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(109, 54);
            this.btnNewUser.TabIndex = 39;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderPizza.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.Color.Black;
            this.btnOrderPizza.Location = new System.Drawing.Point(283, 687);
            this.btnOrderPizza.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(175, 50);
            this.btnOrderPizza.TabIndex = 23;
            this.btnOrderPizza.Text = "Add To Cart";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numericUpDownAmount.Location = new System.Drawing.Point(57, 474);
            this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 32);
            this.numericUpDownAmount.TabIndex = 28;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDownAmount_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 417);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 38);
            this.label3.TabIndex = 27;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(321, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 87);
            this.label2.TabIndex = 26;
            this.label2.Text = "Order Your Juice";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbAmount);
            this.groupBox2.Controls.Add(this.Amont);
            this.groupBox2.Controls.Add(this.lblTotalPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblWhereToEat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblSize);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(784, 161);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(335, 350);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Summary";
            // 
            // lbAmount
            // 
            this.lbAmount.Location = new System.Drawing.Point(128, 133);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(146, 25);
            this.lbAmount.TabIndex = 12;
            this.lbAmount.Text = "1";
            // 
            // Amont
            // 
            this.Amont.AutoSize = true;
            this.Amont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amont.Location = new System.Drawing.Point(29, 135);
            this.Amont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Amont.Name = "Amont";
            this.Amont.Size = new System.Drawing.Size(87, 25);
            this.Amont.TabIndex = 11;
            this.Amont.Text = "Amont :";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPrice.Location = new System.Drawing.Point(115, 256);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(129, 91);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "$0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Price: ";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Location = new System.Drawing.Point(125, 209);
            this.lblWhereToEat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(77, 25);
            this.lblWhereToEat.TabIndex = 8;
            this.lblWhereToEat.Text = "Drink in";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Where to Drink: ";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(142, 85);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(146, 25);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Mango";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type Juice:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(66, 39);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(82, 25);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Meduim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size: ";
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbWhereToEat.Location = new System.Drawing.Point(371, 371);
            this.gbWhereToEat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbWhereToEat.Size = new System.Drawing.Size(335, 85);
            this.gbWhereToEat.TabIndex = 22;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Drink";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTakeOut.Location = new System.Drawing.Point(119, 37);
            this.rbTakeOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(115, 29);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.AnyOptionChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEatIn.Location = new System.Drawing.Point(18, 37);
            this.rbEatIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(98, 29);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "";
            this.rbEatIn.Text = "Drink in";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.AnyOptionChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.rbStrawberry);
            this.gbToppings.Controls.Add(this.rbCocktail);
            this.gbToppings.Controls.Add(this.rbMango);
            this.gbToppings.Controls.Add(this.rbOrange);
            this.gbToppings.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbToppings.Location = new System.Drawing.Point(371, 161);
            this.gbToppings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbToppings.Size = new System.Drawing.Size(350, 160);
            this.gbToppings.TabIndex = 21;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Type Juice";
            // 
            // rbStrawberry
            // 
            this.rbStrawberry.AutoSize = true;
            this.rbStrawberry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbStrawberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbStrawberry.Location = new System.Drawing.Point(156, 47);
            this.rbStrawberry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbStrawberry.Name = "rbStrawberry";
            this.rbStrawberry.Size = new System.Drawing.Size(127, 29);
            this.rbStrawberry.TabIndex = 19;
            this.rbStrawberry.Tag = "15";
            this.rbStrawberry.Text = "Strawberry";
            this.rbStrawberry.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbStrawberry.UseVisualStyleBackColor = true;
            this.rbStrawberry.CheckedChanged += new System.EventHandler(this.AnyOptionChanged);
            // 
            // rbCocktail
            // 
            this.rbCocktail.AutoSize = true;
            this.rbCocktail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCocktail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbCocktail.Location = new System.Drawing.Point(156, 100);
            this.rbCocktail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbCocktail.Name = "rbCocktail";
            this.rbCocktail.Size = new System.Drawing.Size(99, 29);
            this.rbCocktail.TabIndex = 18;
            this.rbCocktail.Tag = "15";
            this.rbCocktail.Text = "Cocktel";
            this.rbCocktail.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbCocktail.UseVisualStyleBackColor = true;
            this.rbCocktail.CheckedChanged += new System.EventHandler(this.AnyOptionChanged);
            // 
            // rbMango
            // 
            this.rbMango.AutoSize = true;
            this.rbMango.Checked = true;
            this.rbMango.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMango.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbMango.Location = new System.Drawing.Point(16, 47);
            this.rbMango.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMango.Name = "rbMango";
            this.rbMango.Size = new System.Drawing.Size(94, 29);
            this.rbMango.TabIndex = 5;
            this.rbMango.TabStop = true;
            this.rbMango.Tag = "10";
            this.rbMango.Text = "Mango";
            this.rbMango.UseVisualStyleBackColor = true;
            this.rbMango.CheckedChanged += new System.EventHandler(this.AnyOptionChanged);
            // 
            // rbOrange
            // 
            this.rbOrange.AutoSize = true;
            this.rbOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbOrange.Location = new System.Drawing.Point(16, 102);
            this.rbOrange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.Size = new System.Drawing.Size(99, 29);
            this.rbOrange.TabIndex = 17;
            this.rbOrange.Tag = "10";
            this.rbOrange.Text = "Orange";
            this.rbOrange.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbOrange.UseVisualStyleBackColor = true;
            this.rbOrange.CheckedChanged += new System.EventHandler(this.AnyOptionChanged);
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbSize.Location = new System.Drawing.Point(55, 161);
            this.gbSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSize.Name = "gbSize";
            this.gbSize.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSize.Size = new System.Drawing.Size(248, 187);
            this.gbSize.TabIndex = 20;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLarge.Location = new System.Drawing.Point(40, 130);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(72, 29);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Tag = "30";
            this.rbLarge.Text = "Larg";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.AnyOptionChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMedium.Location = new System.Drawing.Point(40, 85);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(103, 29);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "20";
            this.rbMedium.Text = "Meduim";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.AnyOptionChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSmall.Location = new System.Drawing.Point(40, 39);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(82, 29);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.AnyOptionChanged);
            // 
            // OrderJuiceForm
            // 
            this.AcceptButton = this.btnNewUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1303, 792);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOrderPizza);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "OrderJuiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderJuice";
            this.Load += new System.EventHandler(this.OrderJuiceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label Amont;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.RadioButton rbStrawberry;
        private System.Windows.Forms.RadioButton rbCocktail;
        private System.Windows.Forms.RadioButton rbMango;
        private System.Windows.Forms.RadioButton rbOrange;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Button btnNewUser;
    }
}