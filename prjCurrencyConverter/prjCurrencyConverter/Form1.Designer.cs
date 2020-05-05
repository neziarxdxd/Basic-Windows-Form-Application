namespace prjCurrencyConverter
{
    partial class frmCurrency
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblEquivalent = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtEquivalent = new System.Windows.Forms.TextBox();
            this.rbtnDollar = new System.Windows.Forms.RadioButton();
            this.rbtnPeso = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(42, 41);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(110, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount in Dollars:";
            // 
            // lblEquivalent
            // 
            this.lblEquivalent.AutoSize = true;
            this.lblEquivalent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquivalent.Location = new System.Drawing.Point(42, 77);
            this.lblEquivalent.Name = "lblEquivalent";
            this.lblEquivalent.Size = new System.Drawing.Size(128, 13);
            this.lblEquivalent.TabIndex = 1;
            this.lblEquivalent.Text = "Equivalent in Dollars:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(42, 123);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(0, 13);
            this.lblRate.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(197, 41);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(148, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // txtEquivalent
            // 
            this.txtEquivalent.Enabled = false;
            this.txtEquivalent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquivalent.Location = new System.Drawing.Point(197, 74);
            this.txtEquivalent.Name = "txtEquivalent";
            this.txtEquivalent.Size = new System.Drawing.Size(148, 20);
            this.txtEquivalent.TabIndex = 4;
            // 
            // rbtnDollar
            // 
            this.rbtnDollar.AutoSize = true;
            this.rbtnDollar.Checked = true;
            this.rbtnDollar.Location = new System.Drawing.Point(45, 194);
            this.rbtnDollar.Name = "rbtnDollar";
            this.rbtnDollar.Size = new System.Drawing.Size(67, 17);
            this.rbtnDollar.TabIndex = 5;
            this.rbtnDollar.Text = "Dollar - $";
            this.rbtnDollar.UseVisualStyleBackColor = true;
            this.rbtnDollar.CheckedChanged += new System.EventHandler(this.rbtnDollar_CheckedChanged);
            // 
            // rbtnPeso
            // 
            this.rbtnPeso.AutoSize = true;
            this.rbtnPeso.Location = new System.Drawing.Point(170, 194);
            this.rbtnPeso.Name = "rbtnPeso";
            this.rbtnPeso.Size = new System.Drawing.Size(80, 17);
            this.rbtnPeso.TabIndex = 6;
            this.rbtnPeso.Text = "Peso - Php ";
            this.rbtnPeso.UseVisualStyleBackColor = true;
            this.rbtnPeso.CheckedChanged += new System.EventHandler(this.rbtnPeso_CheckedChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(399, 36);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(399, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(399, 94);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(551, 270);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.rbtnPeso);
            this.Controls.Add(this.rbtnDollar);
            this.Controls.Add(this.txtEquivalent);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblEquivalent);
            this.Controls.Add(this.lblAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCurrency";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.frmCurrency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblEquivalent;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtEquivalent;
        private System.Windows.Forms.RadioButton rbtnDollar;
        private System.Windows.Forms.RadioButton rbtnPeso;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

