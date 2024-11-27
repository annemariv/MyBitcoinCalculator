namespace Bitcoin_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bitcoinCurrency = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bitcoinInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tulemusLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bitcoinCurrency
            // 
            this.bitcoinCurrency.FormattingEnabled = true;
            this.bitcoinCurrency.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP",
            "EEK"});
            this.bitcoinCurrency.Location = new System.Drawing.Point(337, 133);
            this.bitcoinCurrency.Name = "bitcoinCurrency";
            this.bitcoinCurrency.Size = new System.Drawing.Size(121, 28);
            this.bitcoinCurrency.TabIndex = 0;
            this.bitcoinCurrency.Text = "Vali valuuta";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(319, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Arvuta kurss";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bitcoinInput
            // 
            this.bitcoinInput.Location = new System.Drawing.Point(346, 101);
            this.bitcoinInput.Name = "bitcoinInput";
            this.bitcoinInput.Size = new System.Drawing.Size(100, 26);
            this.bitcoinInput.TabIndex = 2;
            this.bitcoinInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(306, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sisesta Bitcoini arv";
            // 
            // tulemusLabel
            // 
            this.tulemusLabel.AutoSize = true;
            this.tulemusLabel.BackColor = System.Drawing.Color.Transparent;
            this.tulemusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tulemusLabel.Location = new System.Drawing.Point(355, 241);
            this.tulemusLabel.Name = "tulemusLabel";
            this.tulemusLabel.Size = new System.Drawing.Size(76, 20);
            this.tulemusLabel.TabIndex = 4;
            this.tulemusLabel.Text = "Tulemus";
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.resultLabel.Location = new System.Drawing.Point(221, 264);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(351, 59);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "pole";
            this.resultLabel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.tulemusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitcoinInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bitcoinCurrency);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Bitcoin calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bitcoinCurrency;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bitcoinInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tulemusLabel;
        private System.Windows.Forms.TextBox resultLabel;
    }
}

