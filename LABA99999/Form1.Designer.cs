namespace LABA99999
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
            textBoxInputString = new TextBox();
            pictureBox1 = new PictureBox();
            Commands_ListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxInputString
            // 
            textBoxInputString.Location = new Point(784, 133);
            textBoxInputString.Name = "textBoxInputString";
            textBoxInputString.Size = new Size(373, 39);
            textBoxInputString.TabIndex = 0;
            textBoxInputString.KeyDown += TextBox_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(688, 701);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Commands_ListBox
            // 
            Commands_ListBox.FormattingEnabled = true;
            Commands_ListBox.ItemHeight = 32;
            Commands_ListBox.Location = new Point(784, 214);
            Commands_ListBox.Name = "Commands_ListBox";
            Commands_ListBox.Size = new Size(373, 260);
            Commands_ListBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 725);
            Controls.Add(Commands_ListBox);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxInputString);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInputString;
        private PictureBox pictureBox1;
        private ListBox Commands_ListBox;
    }
}