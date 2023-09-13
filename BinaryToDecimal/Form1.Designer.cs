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
            ConfBtn = new Button();
            BinTxt = new TextBox();
            DecTxt = new TextBox();
            SuspendLayout();
            // 
            // ConfBtn
            // 
            ConfBtn.Location = new Point(428, 46);
            ConfBtn.Name = "ConfBtn";
            ConfBtn.Size = new Size(98, 77);
            ConfBtn.TabIndex = 0;
            ConfBtn.Text = "Generate";
            ConfBtn.UseVisualStyleBackColor = true;
            ConfBtn.Click += ConfBtn_Click;
            // 
            // BinTxt
            // 
            BinTxt.AcceptsReturn = true;
            BinTxt.Location = new Point(34, 46);
            BinTxt.MaxLength = 8;
            BinTxt.Name = "BinTxt";
            BinTxt.PlaceholderText = "Binary";
            BinTxt.Size = new Size(370, 27);
            BinTxt.TabIndex = 1;
            // 
            // DecTxt
            // 
            DecTxt.Location = new Point(34, 97);
            DecTxt.Multiline = true;
            DecTxt.Name = "DecTxt";
            DecTxt.PlaceholderText = "Decimal";
            DecTxt.ReadOnly = true;
            DecTxt.Size = new Size(370, 26);
            DecTxt.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 165);
            Controls.Add(DecTxt);
            Controls.Add(BinTxt);
            Controls.Add(ConfBtn);
            Name = "Form1";
            Text = "Bin2Dec Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConfBtn;
        public TextBox BinTxt;
        public TextBox DecTxt;
    }
}