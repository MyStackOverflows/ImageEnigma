namespace ImageEnigma
{
    partial class HelpForm
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
            this.HelpTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // HelpTextBox
            // 
            this.HelpTextBox.Location = new System.Drawing.Point(0, 0);
            this.HelpTextBox.Name = "HelpTextBox";
            this.HelpTextBox.ReadOnly = true;
            this.HelpTextBox.Size = new System.Drawing.Size(485, 312);
            this.HelpTextBox.TabIndex = 0;
            this.HelpTextBox.Text = "";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.HelpTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "HelpForm";
            this.Text = "HELP LMAO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox HelpTextBox;
    }
}