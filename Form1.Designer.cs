namespace BUPizzaPalace
{
    partial class frmMain
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
            this.pictPizza2 = new System.Windows.Forms.PictureBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.lblToppings = new System.Windows.Forms.Label();
            this.ckbPepperoni = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbCanadianBacon = new System.Windows.Forms.CheckBox();
            this.ckbSpicyItalianSausage = new System.Windows.Forms.CheckBox();
            this.ckbBlackOlives = new System.Windows.Forms.CheckBox();
            this.ckbGreenOlives = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbGreenPepper = new System.Windows.Forms.CheckBox();
            this.ckbBananaPeppers = new System.Windows.Forms.CheckBox();
            this.ckbMushroom = new System.Windows.Forms.CheckBox();
            this.ckbJalapeno = new System.Windows.Forms.CheckBox();
            this.ckbExtraCheese = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpSelections = new System.Windows.Forms.GroupBox();
            this.rtfOrderSummary = new System.Windows.Forms.RichTextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.grpFinalTotal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblPizzaPalace = new System.Windows.Forms.Label();
            this.pictPizza1 = new System.Windows.Forms.PictureBox();
            this.pictPizza3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza2)).BeginInit();
            this.grpCrust.SuspendLayout();
            this.grpSelections.SuspendLayout();
            this.grpFinalTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictPizza2
            // 
            this.pictPizza2.Image = global::BUPizzaPalace.Properties.Resources.image_pizza;
            this.pictPizza2.Location = new System.Drawing.Point(727, 42);
            this.pictPizza2.Name = "pictPizza2";
            this.pictPizza2.Size = new System.Drawing.Size(260, 179);
            this.pictPizza2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictPizza2.TabIndex = 0;
            this.pictPizza2.TabStop = false;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(6, 27);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(93, 37);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size:";
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboSize.Location = new System.Drawing.Point(105, 31);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(150, 33);
            this.cboSize.TabIndex = 2;
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.rdoRegular);
            this.grpCrust.Controls.Add(this.rdoThick);
            this.grpCrust.Controls.Add(this.rdoThin);
            this.grpCrust.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrust.Location = new System.Drawing.Point(306, 29);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(552, 52);
            this.grpCrust.TabIndex = 3;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust Type:";
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Location = new System.Drawing.Point(399, 7);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(148, 36);
            this.rdoRegular.TabIndex = 2;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Location = new System.Drawing.Point(277, 7);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(116, 36);
            this.rdoThick.TabIndex = 1;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(170, 7);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(101, 36);
            this.rdoThin.TabIndex = 0;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(6, 89);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(171, 37);
            this.lblToppings.TabIndex = 4;
            this.lblToppings.Text = "Toppings:";
            // 
            // ckbPepperoni
            // 
            this.ckbPepperoni.AutoSize = true;
            this.ckbPepperoni.Location = new System.Drawing.Point(13, 143);
            this.ckbPepperoni.Name = "ckbPepperoni";
            this.ckbPepperoni.Size = new System.Drawing.Size(142, 29);
            this.ckbPepperoni.TabIndex = 5;
            this.ckbPepperoni.Text = "Pepperoni";
            this.ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Location = new System.Drawing.Point(13, 178);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(129, 29);
            this.ckbSausage.TabIndex = 6;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            this.ckbCanadianBacon.AutoSize = true;
            this.ckbCanadianBacon.Location = new System.Drawing.Point(13, 213);
            this.ckbCanadianBacon.Name = "ckbCanadianBacon";
            this.ckbCanadianBacon.Size = new System.Drawing.Size(203, 29);
            this.ckbCanadianBacon.TabIndex = 7;
            this.ckbCanadianBacon.Text = "Canadian Bacon";
            this.ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSpicyItalianSausage
            // 
            this.ckbSpicyItalianSausage.AutoSize = true;
            this.ckbSpicyItalianSausage.Location = new System.Drawing.Point(218, 143);
            this.ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            this.ckbSpicyItalianSausage.Size = new System.Drawing.Size(251, 29);
            this.ckbSpicyItalianSausage.TabIndex = 8;
            this.ckbSpicyItalianSausage.Text = "Spicy Italian Sausage";
            this.ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            this.ckbBlackOlives.AutoSize = true;
            this.ckbBlackOlives.Location = new System.Drawing.Point(476, 143);
            this.ckbBlackOlives.Name = "ckbBlackOlives";
            this.ckbBlackOlives.Size = new System.Drawing.Size(163, 29);
            this.ckbBlackOlives.TabIndex = 10;
            this.ckbBlackOlives.Text = "Black Olives";
            this.ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlives
            // 
            this.ckbGreenOlives.AutoSize = true;
            this.ckbGreenOlives.Location = new System.Drawing.Point(476, 178);
            this.ckbGreenOlives.Name = "ckbGreenOlives";
            this.ckbGreenOlives.Size = new System.Drawing.Size(169, 29);
            this.ckbGreenOlives.TabIndex = 11;
            this.ckbGreenOlives.Text = "Green Olives";
            this.ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Location = new System.Drawing.Point(218, 178);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(101, 29);
            this.ckbOnion.TabIndex = 12;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            this.ckbGreenPepper.AutoSize = true;
            this.ckbGreenPepper.Location = new System.Drawing.Point(218, 213);
            this.ckbGreenPepper.Name = "ckbGreenPepper";
            this.ckbGreenPepper.Size = new System.Drawing.Size(172, 29);
            this.ckbGreenPepper.TabIndex = 13;
            this.ckbGreenPepper.Text = "GreenPepper";
            this.ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            this.ckbBananaPeppers.AutoSize = true;
            this.ckbBananaPeppers.Location = new System.Drawing.Point(476, 213);
            this.ckbBananaPeppers.Name = "ckbBananaPeppers";
            this.ckbBananaPeppers.Size = new System.Drawing.Size(204, 29);
            this.ckbBananaPeppers.TabIndex = 14;
            this.ckbBananaPeppers.Text = "Banana Peppers";
            this.ckbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            this.ckbMushroom.AutoSize = true;
            this.ckbMushroom.Location = new System.Drawing.Point(789, 161);
            this.ckbMushroom.Name = "ckbMushroom";
            this.ckbMushroom.Size = new System.Drawing.Size(145, 29);
            this.ckbMushroom.TabIndex = 16;
            this.ckbMushroom.Text = "Mushroom";
            this.ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // ckbJalapeno
            // 
            this.ckbJalapeno.AutoSize = true;
            this.ckbJalapeno.Location = new System.Drawing.Point(789, 125);
            this.ckbJalapeno.Name = "ckbJalapeno";
            this.ckbJalapeno.Size = new System.Drawing.Size(132, 29);
            this.ckbJalapeno.TabIndex = 17;
            this.ckbJalapeno.Text = "Jalapeno";
            this.ckbJalapeno.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            this.ckbExtraCheese.AutoSize = true;
            this.ckbExtraCheese.Location = new System.Drawing.Point(789, 197);
            this.ckbExtraCheese.Name = "ckbExtraCheese";
            this.ckbExtraCheese.Size = new System.Drawing.Size(174, 29);
            this.ckbExtraCheese.TabIndex = 18;
            this.ckbExtraCheese.Text = "Extra Cheese";
            this.ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(1010, 381);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(248, 111);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpSelections
            // 
            this.grpSelections.Controls.Add(this.lblSize);
            this.grpSelections.Controls.Add(this.cboSize);
            this.grpSelections.Controls.Add(this.ckbExtraCheese);
            this.grpSelections.Controls.Add(this.grpCrust);
            this.grpSelections.Controls.Add(this.ckbJalapeno);
            this.grpSelections.Controls.Add(this.lblToppings);
            this.grpSelections.Controls.Add(this.ckbMushroom);
            this.grpSelections.Controls.Add(this.ckbBananaPeppers);
            this.grpSelections.Controls.Add(this.ckbPepperoni);
            this.grpSelections.Controls.Add(this.ckbGreenPepper);
            this.grpSelections.Controls.Add(this.ckbSausage);
            this.grpSelections.Controls.Add(this.ckbOnion);
            this.grpSelections.Controls.Add(this.ckbCanadianBacon);
            this.grpSelections.Controls.Add(this.ckbGreenOlives);
            this.grpSelections.Controls.Add(this.ckbSpicyItalianSausage);
            this.grpSelections.Controls.Add(this.ckbBlackOlives);
            this.grpSelections.Location = new System.Drawing.Point(12, 232);
            this.grpSelections.Name = "grpSelections";
            this.grpSelections.Size = new System.Drawing.Size(966, 257);
            this.grpSelections.TabIndex = 20;
            this.grpSelections.TabStop = false;
            // 
            // rtfOrderSummary
            // 
            this.rtfOrderSummary.Location = new System.Drawing.Point(48, 547);
            this.rtfOrderSummary.Name = "rtfOrderSummary";
            this.rtfOrderSummary.Size = new System.Drawing.Size(673, 130);
            this.rtfOrderSummary.TabIndex = 21;
            this.rtfOrderSummary.Text = "";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(6, 56);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(104, 25);
            this.lblSubTotal.TabIndex = 22;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(6, 106);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(54, 25);
            this.lblTax.TabIndex = 23;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 152);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 25);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "Total:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(119, 56);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 31);
            this.txtSubTotal.TabIndex = 25;
            // 
            // grpFinalTotal
            // 
            this.grpFinalTotal.Controls.Add(this.txtTotal);
            this.grpFinalTotal.Controls.Add(this.txtTax);
            this.grpFinalTotal.Controls.Add(this.lblSubTotal);
            this.grpFinalTotal.Controls.Add(this.txtSubTotal);
            this.grpFinalTotal.Controls.Add(this.lblTax);
            this.grpFinalTotal.Controls.Add(this.lblTotal);
            this.grpFinalTotal.Location = new System.Drawing.Point(893, 509);
            this.grpFinalTotal.Name = "grpFinalTotal";
            this.grpFinalTotal.Size = new System.Drawing.Size(258, 218);
            this.grpFinalTotal.TabIndex = 26;
            this.grpFinalTotal.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(119, 152);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 31);
            this.txtTotal.TabIndex = 27;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(119, 106);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 31);
            this.txtTax.TabIndex = 26;
            // 
            // lblPizzaPalace
            // 
            this.lblPizzaPalace.AutoSize = true;
            this.lblPizzaPalace.Font = new System.Drawing.Font("Baskerville Old Face", 25.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaPalace.Location = new System.Drawing.Point(48, 42);
            this.lblPizzaPalace.Name = "lblPizzaPalace";
            this.lblPizzaPalace.Size = new System.Drawing.Size(380, 79);
            this.lblPizzaPalace.TabIndex = 27;
            this.lblPizzaPalace.Text = "Pizza Palace";
            // 
            // pictPizza1
            // 
            this.pictPizza1.Image = global::BUPizzaPalace.Properties.Resources.image_pizza;
            this.pictPizza1.Location = new System.Drawing.Point(461, 42);
            this.pictPizza1.Name = "pictPizza1";
            this.pictPizza1.Size = new System.Drawing.Size(260, 179);
            this.pictPizza1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictPizza1.TabIndex = 28;
            this.pictPizza1.TabStop = false;
            // 
            // pictPizza3
            // 
            this.pictPizza3.Image = global::BUPizzaPalace.Properties.Resources.image_pizza;
            this.pictPizza3.Location = new System.Drawing.Point(993, 42);
            this.pictPizza3.Name = "pictPizza3";
            this.pictPizza3.Size = new System.Drawing.Size(260, 179);
            this.pictPizza3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictPizza3.TabIndex = 29;
            this.pictPizza3.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 739);
            this.Controls.Add(this.pictPizza3);
            this.Controls.Add(this.pictPizza1);
            this.Controls.Add(this.lblPizzaPalace);
            this.Controls.Add(this.grpFinalTotal);
            this.Controls.Add(this.rtfOrderSummary);
            this.Controls.Add(this.grpSelections);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pictPizza2);
            this.Name = "frmMain";
            this.Text = "BUPizzaPalace";
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza2)).EndInit();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpSelections.ResumeLayout(false);
            this.grpSelections.PerformLayout();
            this.grpFinalTotal.ResumeLayout(false);
            this.grpFinalTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictPizza2;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.RadioButton rdoThick;
        private System.Windows.Forms.RadioButton rdoThin;
        private System.Windows.Forms.RadioButton rdoRegular;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.CheckBox ckbPepperoni;
        private System.Windows.Forms.CheckBox ckbSausage;
        private System.Windows.Forms.CheckBox ckbCanadianBacon;
        private System.Windows.Forms.CheckBox ckbSpicyItalianSausage;
        private System.Windows.Forms.CheckBox ckbBlackOlives;
        private System.Windows.Forms.CheckBox ckbGreenOlives;
        private System.Windows.Forms.CheckBox ckbOnion;
        private System.Windows.Forms.CheckBox ckbGreenPepper;
        private System.Windows.Forms.CheckBox ckbBananaPeppers;
        private System.Windows.Forms.CheckBox ckbMushroom;
        private System.Windows.Forms.CheckBox ckbJalapeno;
        private System.Windows.Forms.CheckBox ckbExtraCheese;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpSelections;
        private System.Windows.Forms.RichTextBox rtfOrderSummary;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.GroupBox grpFinalTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblPizzaPalace;
        private System.Windows.Forms.PictureBox pictPizza1;
        private System.Windows.Forms.PictureBox pictPizza3;
    }
}

