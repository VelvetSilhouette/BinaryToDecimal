namespace BinaryToDecimal
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
            btnGenerate = new Button();
            txbBinary = new TextBox();
            txbDecimal = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(374, 34);
            btnGenerate.Margin = new Padding(3, 2, 3, 2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(86, 58);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txbBinary
            // 
            txbBinary.AcceptsReturn = true;
            txbBinary.Location = new Point(30, 34);
            txbBinary.Margin = new Padding(3, 2, 3, 2);
            txbBinary.MaxLength = 8;
            txbBinary.Name = "txbBinary";
            txbBinary.PlaceholderText = "Binary";
            txbBinary.Size = new Size(324, 23);
            txbBinary.TabIndex = 1;
            // 
            // txbDecimal
            // 
            txbDecimal.Location = new Point(30, 73);
            txbDecimal.Margin = new Padding(3, 2, 3, 2);
            txbDecimal.Multiline = true;
            txbDecimal.Name = "txbDecimal";
            txbDecimal.PlaceholderText = "Decimal";
            txbDecimal.ReadOnly = true;
            txbDecimal.Size = new Size(324, 20);
            txbDecimal.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 3;
            label1.Text = "MAPPA Animation";
            // 
            // Form1
            // 
            AcceptButton = btnGenerate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 124);
            Controls.Add(label1);
            Controls.Add(txbDecimal);
            Controls.Add(txbBinary);
            Controls.Add(btnGenerate);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Bin2Dec Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        public TextBox txbBinary;
        public TextBox txbDecimal;
        private Label label1;
    }
}