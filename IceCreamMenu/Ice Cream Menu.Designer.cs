namespace IceCreamMenu
{
    partial class FormIceCream
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIceCream));
            this.label1 = new System.Windows.Forms.Label();
            this.gbFlavor = new System.Windows.Forms.GroupBox();
            this.rbchocolate = new System.Windows.Forms.RadioButton();
            this.rbstrawberry = new System.Windows.Forms.RadioButton();
            this.rbvanilla = new System.Windows.Forms.RadioButton();
            this.gbServing = new System.Windows.Forms.GroupBox();
            this.rbCone = new System.Windows.Forms.RadioButton();
            this.rbCup = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkCaramelSauce = new System.Windows.Forms.CheckBox();
            this.chkChocolateChips = new System.Windows.Forms.CheckBox();
            this.chkSprinkles = new System.Windows.Forms.CheckBox();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblServing = new System.Windows.Forms.Label();
            this.lblFlavor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbFlavor.SuspendLayout();
            this.gbServing.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ice Cream Parlor";
            // 
            // gbFlavor
            // 
            this.gbFlavor.BackColor = System.Drawing.Color.Transparent;
            this.gbFlavor.Controls.Add(this.rbchocolate);
            this.gbFlavor.Controls.Add(this.rbstrawberry);
            this.gbFlavor.Controls.Add(this.rbvanilla);
            this.gbFlavor.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFlavor.ForeColor = System.Drawing.Color.Fuchsia;
            this.gbFlavor.Location = new System.Drawing.Point(40, 120);
            this.gbFlavor.Name = "gbFlavor";
            this.gbFlavor.Size = new System.Drawing.Size(139, 192);
            this.gbFlavor.TabIndex = 1;
            this.gbFlavor.TabStop = false;
            this.gbFlavor.Text = "Flavor";
            // 
            // rbchocolate
            // 
            this.rbchocolate.AutoSize = true;
            this.rbchocolate.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbchocolate.Location = new System.Drawing.Point(16, 153);
            this.rbchocolate.Name = "rbchocolate";
            this.rbchocolate.Size = new System.Drawing.Size(98, 22);
            this.rbchocolate.TabIndex = 6;
            this.rbchocolate.TabStop = true;
            this.rbchocolate.Tag = "9";
            this.rbchocolate.Text = "chocolate";
            this.rbchocolate.UseVisualStyleBackColor = true;
            this.rbchocolate.CheckedChanged += new System.EventHandler(this.Flavor_CheckedChanged);
            // 
            // rbstrawberry
            // 
            this.rbstrawberry.AutoSize = true;
            this.rbstrawberry.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbstrawberry.Location = new System.Drawing.Point(16, 98);
            this.rbstrawberry.Name = "rbstrawberry";
            this.rbstrawberry.Size = new System.Drawing.Size(104, 22);
            this.rbstrawberry.TabIndex = 5;
            this.rbstrawberry.TabStop = true;
            this.rbstrawberry.Tag = "7";
            this.rbstrawberry.Text = "strawberry";
            this.rbstrawberry.UseVisualStyleBackColor = true;
            this.rbstrawberry.CheckedChanged += new System.EventHandler(this.Flavor_CheckedChanged);
            // 
            // rbvanilla
            // 
            this.rbvanilla.AutoSize = true;
            this.rbvanilla.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbvanilla.Location = new System.Drawing.Point(16, 43);
            this.rbvanilla.Name = "rbvanilla";
            this.rbvanilla.Size = new System.Drawing.Size(72, 22);
            this.rbvanilla.TabIndex = 4;
            this.rbvanilla.TabStop = true;
            this.rbvanilla.Tag = "5";
            this.rbvanilla.Text = "vanilla";
            this.rbvanilla.UseVisualStyleBackColor = true;
            this.rbvanilla.CheckedChanged += new System.EventHandler(this.Flavor_CheckedChanged);
            // 
            // gbServing
            // 
            this.gbServing.BackColor = System.Drawing.Color.Transparent;
            this.gbServing.Controls.Add(this.rbCone);
            this.gbServing.Controls.Add(this.rbCup);
            this.gbServing.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServing.ForeColor = System.Drawing.Color.Fuchsia;
            this.gbServing.Location = new System.Drawing.Point(247, 120);
            this.gbServing.Name = "gbServing";
            this.gbServing.Size = new System.Drawing.Size(139, 192);
            this.gbServing.TabIndex = 2;
            this.gbServing.TabStop = false;
            this.gbServing.Text = "Serving";
            // 
            // rbCone
            // 
            this.rbCone.AutoSize = true;
            this.rbCone.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCone.Location = new System.Drawing.Point(16, 43);
            this.rbCone.Name = "rbCone";
            this.rbCone.Size = new System.Drawing.Size(64, 22);
            this.rbCone.TabIndex = 7;
            this.rbCone.TabStop = true;
            this.rbCone.Tag = "2";
            this.rbCone.Text = "Cone";
            this.rbCone.UseVisualStyleBackColor = true;
            this.rbCone.CheckedChanged += new System.EventHandler(this.Serving_CheckedChanged);
            // 
            // rbCup
            // 
            this.rbCup.AutoSize = true;
            this.rbCup.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCup.Location = new System.Drawing.Point(16, 98);
            this.rbCup.Name = "rbCup";
            this.rbCup.Size = new System.Drawing.Size(56, 22);
            this.rbCup.TabIndex = 8;
            this.rbCup.TabStop = true;
            this.rbCup.Tag = "0";
            this.rbCup.Text = "Cup";
            this.rbCup.UseVisualStyleBackColor = true;
            this.rbCup.CheckedChanged += new System.EventHandler(this.Serving_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chkNuts);
            this.gbToppings.Controls.Add(this.chkCaramelSauce);
            this.gbToppings.Controls.Add(this.chkChocolateChips);
            this.gbToppings.Controls.Add(this.chkSprinkles);
            this.gbToppings.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.Fuchsia;
            this.gbToppings.Location = new System.Drawing.Point(454, 120);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(168, 192);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkNuts
            // 
            this.chkNuts.AutoSize = true;
            this.chkNuts.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNuts.Location = new System.Drawing.Point(15, 148);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(62, 22);
            this.chkNuts.TabIndex = 3;
            this.chkNuts.Tag = "1";
            this.chkNuts.Text = "Nuts";
            this.chkNuts.UseVisualStyleBackColor = true;
            this.chkNuts.CheckedChanged += new System.EventHandler(this.Toppings_CheckedChanged);
            // 
            // chkCaramelSauce
            // 
            this.chkCaramelSauce.AutoSize = true;
            this.chkCaramelSauce.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCaramelSauce.Location = new System.Drawing.Point(15, 113);
            this.chkCaramelSauce.Name = "chkCaramelSauce";
            this.chkCaramelSauce.Size = new System.Drawing.Size(139, 22);
            this.chkCaramelSauce.TabIndex = 2;
            this.chkCaramelSauce.Tag = "1";
            this.chkCaramelSauce.Text = " Caramel Sauce";
            this.chkCaramelSauce.UseVisualStyleBackColor = true;
            this.chkCaramelSauce.CheckedChanged += new System.EventHandler(this.Toppings_CheckedChanged);
            // 
            // chkChocolateChips
            // 
            this.chkChocolateChips.AutoSize = true;
            this.chkChocolateChips.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChocolateChips.Location = new System.Drawing.Point(15, 78);
            this.chkChocolateChips.Name = "chkChocolateChips";
            this.chkChocolateChips.Size = new System.Drawing.Size(154, 22);
            this.chkChocolateChips.TabIndex = 1;
            this.chkChocolateChips.Tag = "1";
            this.chkChocolateChips.Text = " Chocolate Chips";
            this.chkChocolateChips.UseVisualStyleBackColor = true;
            this.chkChocolateChips.CheckedChanged += new System.EventHandler(this.Toppings_CheckedChanged);
            // 
            // chkSprinkles
            // 
            this.chkSprinkles.AutoSize = true;
            this.chkSprinkles.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSprinkles.Location = new System.Drawing.Point(15, 43);
            this.chkSprinkles.Name = "chkSprinkles";
            this.chkSprinkles.Size = new System.Drawing.Size(93, 22);
            this.chkSprinkles.TabIndex = 0;
            this.chkSprinkles.Tag = "1";
            this.chkSprinkles.Text = "Sprinkles";
            this.chkSprinkles.UseVisualStyleBackColor = true;
            this.chkSprinkles.CheckedChanged += new System.EventHandler(this.Toppings_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.lblServing);
            this.gbOrderSummary.Controls.Add(this.lblFlavor);
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.label3);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.ForeColor = System.Drawing.Color.Fuchsia;
            this.gbOrderSummary.Location = new System.Drawing.Point(690, 120);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(185, 224);
            this.gbOrderSummary.TabIndex = 4;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.Lime;
            this.lblToppings.Location = new System.Drawing.Point(19, 148);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(75, 18);
            this.lblToppings.TabIndex = 9;
            this.lblToppings.Text = "Toppings";
            // 
            // lblServing
            // 
            this.lblServing.AutoSize = true;
            this.lblServing.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServing.ForeColor = System.Drawing.Color.Lime;
            this.lblServing.Location = new System.Drawing.Point(105, 84);
            this.lblServing.Name = "lblServing";
            this.lblServing.Size = new System.Drawing.Size(62, 18);
            this.lblServing.TabIndex = 8;
            this.lblServing.Text = "Serving";
            // 
            // lblFlavor
            // 
            this.lblFlavor.AutoSize = true;
            this.lblFlavor.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlavor.ForeColor = System.Drawing.Color.Lime;
            this.lblFlavor.Location = new System.Drawing.Point(92, 49);
            this.lblFlavor.Name = "lblFlavor";
            this.lblFlavor.Size = new System.Drawing.Size(52, 18);
            this.lblFlavor.TabIndex = 5;
            this.lblFlavor.Text = "Flavor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toppings:-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Serving:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Flavor:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(926, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 192);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Price:-";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Kristen ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(6, 43);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(160, 131);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "$0";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnOrder.Location = new System.Drawing.Point(340, 368);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(201, 65);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Order Icecream";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnReset.Location = new System.Drawing.Point(583, 368);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(201, 65);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Fuchsia;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(804, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "How Many Icecream";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Fuchsia;
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.Location = new System.Drawing.Point(994, 380);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 39);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // FormIceCream
            // 
            this.AcceptButton = this.btnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 641);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbServing);
            this.Controls.Add(this.gbFlavor);
            this.Controls.Add(this.label1);
            this.Name = "FormIceCream";
            this.Text = "Ice Cream";
            this.Load += new System.EventHandler(this.FormIceCream_Load);
            this.gbFlavor.ResumeLayout(false);
            this.gbFlavor.PerformLayout();
            this.gbServing.ResumeLayout(false);
            this.gbServing.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFlavor;
        private System.Windows.Forms.RadioButton rbchocolate;
        private System.Windows.Forms.RadioButton rbstrawberry;
        private System.Windows.Forms.RadioButton rbvanilla;
        private System.Windows.Forms.GroupBox gbServing;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.RadioButton rbCone;
        private System.Windows.Forms.RadioButton rbCup;
        private System.Windows.Forms.CheckBox chkNuts;
        private System.Windows.Forms.CheckBox chkCaramelSauce;
        private System.Windows.Forms.CheckBox chkChocolateChips;
        private System.Windows.Forms.CheckBox chkSprinkles;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblServing;
        private System.Windows.Forms.Label lblFlavor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

