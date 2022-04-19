namespace ImageEnigma
{
    partial class ImageEnigmaForm
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
            this.ImageHideTabControl = new System.Windows.Forms.TabControl();
            this.PixelHideTabPage = new System.Windows.Forms.TabPage();
            this.PixelHideHelpLabel = new System.Windows.Forms.LinkLabel();
            this.PixelHideCreateButton = new System.Windows.Forms.Button();
            this.PixelHideMessageTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PixelHideBlueValueCheckBox = new System.Windows.Forms.CheckBox();
            this.PixelHideGreenValueCheckBox = new System.Windows.Forms.CheckBox();
            this.PixelHideRedValueCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChaseHideTabPage = new System.Windows.Forms.TabPage();
            this.ChaseHideBlueValueRadioButton = new System.Windows.Forms.RadioButton();
            this.ChaseHideGreenValueRadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ChaseHideRedValueRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ChaseHideCreateButton = new System.Windows.Forms.Button();
            this.ChaseHideMessageTextBox = new System.Windows.Forms.TextBox();
            this.TextHideTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TextHideHelpLabel = new System.Windows.Forms.LinkLabel();
            this.TextHideAddHiddenTextButton = new System.Windows.Forms.Button();
            this.TextHideToAddTextBox = new System.Windows.Forms.TextBox();
            this.TextHideBrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextHideImageFileTextBox = new System.Windows.Forms.TextBox();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.ImageHideTabControl.SuspendLayout();
            this.PixelHideTabPage.SuspendLayout();
            this.ChaseHideTabPage.SuspendLayout();
            this.TextHideTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageHideTabControl
            // 
            this.ImageHideTabControl.Controls.Add(this.PixelHideTabPage);
            this.ImageHideTabControl.Controls.Add(this.ChaseHideTabPage);
            this.ImageHideTabControl.Controls.Add(this.TextHideTabPage);
            this.ImageHideTabControl.Location = new System.Drawing.Point(0, 0);
            this.ImageHideTabControl.Name = "ImageHideTabControl";
            this.ImageHideTabControl.SelectedIndex = 0;
            this.ImageHideTabControl.Size = new System.Drawing.Size(374, 216);
            this.ImageHideTabControl.TabIndex = 0;
            // 
            // PixelHideTabPage
            // 
            this.PixelHideTabPage.Controls.Add(this.PixelHideHelpLabel);
            this.PixelHideTabPage.Controls.Add(this.PixelHideCreateButton);
            this.PixelHideTabPage.Controls.Add(this.PixelHideMessageTextBox);
            this.PixelHideTabPage.Controls.Add(this.label5);
            this.PixelHideTabPage.Controls.Add(this.PixelHideBlueValueCheckBox);
            this.PixelHideTabPage.Controls.Add(this.PixelHideGreenValueCheckBox);
            this.PixelHideTabPage.Controls.Add(this.PixelHideRedValueCheckBox);
            this.PixelHideTabPage.Controls.Add(this.label3);
            this.PixelHideTabPage.Location = new System.Drawing.Point(4, 22);
            this.PixelHideTabPage.Name = "PixelHideTabPage";
            this.PixelHideTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PixelHideTabPage.Size = new System.Drawing.Size(366, 190);
            this.PixelHideTabPage.TabIndex = 0;
            this.PixelHideTabPage.Text = "Pixel Hide";
            this.PixelHideTabPage.UseVisualStyleBackColor = true;
            // 
            // PixelHideHelpLabel
            // 
            this.PixelHideHelpLabel.AutoSize = true;
            this.PixelHideHelpLabel.Location = new System.Drawing.Point(8, 166);
            this.PixelHideHelpLabel.Name = "PixelHideHelpLabel";
            this.PixelHideHelpLabel.Size = new System.Drawing.Size(62, 13);
            this.PixelHideHelpLabel.TabIndex = 25;
            this.PixelHideHelpLabel.TabStop = true;
            this.PixelHideHelpLabel.Text = "Help/About";
            this.PixelHideHelpLabel.Click += new System.EventHandler(this.LinkLabelClicked);
            // 
            // PixelHideCreateButton
            // 
            this.PixelHideCreateButton.Location = new System.Drawing.Point(283, 161);
            this.PixelHideCreateButton.Name = "PixelHideCreateButton";
            this.PixelHideCreateButton.Size = new System.Drawing.Size(75, 23);
            this.PixelHideCreateButton.TabIndex = 13;
            this.PixelHideCreateButton.Text = "Create";
            this.PixelHideCreateButton.UseVisualStyleBackColor = true;
            this.PixelHideCreateButton.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // PixelHideMessageTextBox
            // 
            this.PixelHideMessageTextBox.Location = new System.Drawing.Point(8, 55);
            this.PixelHideMessageTextBox.Multiline = true;
            this.PixelHideMessageTextBox.Name = "PixelHideMessageTextBox";
            this.PixelHideMessageTextBox.Size = new System.Drawing.Size(350, 100);
            this.PixelHideMessageTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Message:";
            // 
            // PixelHideBlueValueCheckBox
            // 
            this.PixelHideBlueValueCheckBox.AutoSize = true;
            this.PixelHideBlueValueCheckBox.Checked = true;
            this.PixelHideBlueValueCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PixelHideBlueValueCheckBox.Location = new System.Drawing.Point(181, 19);
            this.PixelHideBlueValueCheckBox.Name = "PixelHideBlueValueCheckBox";
            this.PixelHideBlueValueCheckBox.Size = new System.Drawing.Size(77, 17);
            this.PixelHideBlueValueCheckBox.TabIndex = 16;
            this.PixelHideBlueValueCheckBox.Text = "Blue Value";
            this.PixelHideBlueValueCheckBox.UseVisualStyleBackColor = true;
            // 
            // PixelHideGreenValueCheckBox
            // 
            this.PixelHideGreenValueCheckBox.AutoSize = true;
            this.PixelHideGreenValueCheckBox.Checked = true;
            this.PixelHideGreenValueCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PixelHideGreenValueCheckBox.Location = new System.Drawing.Point(90, 19);
            this.PixelHideGreenValueCheckBox.Name = "PixelHideGreenValueCheckBox";
            this.PixelHideGreenValueCheckBox.Size = new System.Drawing.Size(85, 17);
            this.PixelHideGreenValueCheckBox.TabIndex = 15;
            this.PixelHideGreenValueCheckBox.Text = "Green Value";
            this.PixelHideGreenValueCheckBox.UseVisualStyleBackColor = true;
            // 
            // PixelHideRedValueCheckBox
            // 
            this.PixelHideRedValueCheckBox.AutoSize = true;
            this.PixelHideRedValueCheckBox.Checked = true;
            this.PixelHideRedValueCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PixelHideRedValueCheckBox.Location = new System.Drawing.Point(8, 19);
            this.PixelHideRedValueCheckBox.Name = "PixelHideRedValueCheckBox";
            this.PixelHideRedValueCheckBox.Size = new System.Drawing.Size(76, 17);
            this.PixelHideRedValueCheckBox.TabIndex = 14;
            this.PixelHideRedValueCheckBox.Text = "Red Value";
            this.PixelHideRedValueCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Values you want filled with your message:";
            // 
            // ChaseHideTabPage
            // 
            this.ChaseHideTabPage.Controls.Add(this.ChaseHideBlueValueRadioButton);
            this.ChaseHideTabPage.Controls.Add(this.ChaseHideGreenValueRadioButton);
            this.ChaseHideTabPage.Controls.Add(this.label6);
            this.ChaseHideTabPage.Controls.Add(this.ChaseHideRedValueRadioButton);
            this.ChaseHideTabPage.Controls.Add(this.label4);
            this.ChaseHideTabPage.Controls.Add(this.ChaseHideCreateButton);
            this.ChaseHideTabPage.Controls.Add(this.ChaseHideMessageTextBox);
            this.ChaseHideTabPage.Location = new System.Drawing.Point(4, 22);
            this.ChaseHideTabPage.Name = "ChaseHideTabPage";
            this.ChaseHideTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChaseHideTabPage.Size = new System.Drawing.Size(366, 190);
            this.ChaseHideTabPage.TabIndex = 2;
            this.ChaseHideTabPage.Text = "Chase Hide";
            this.ChaseHideTabPage.UseVisualStyleBackColor = true;
            // 
            // ChaseHideBlueValueRadioButton
            // 
            this.ChaseHideBlueValueRadioButton.AutoSize = true;
            this.ChaseHideBlueValueRadioButton.Enabled = false;
            this.ChaseHideBlueValueRadioButton.Location = new System.Drawing.Point(179, 19);
            this.ChaseHideBlueValueRadioButton.Name = "ChaseHideBlueValueRadioButton";
            this.ChaseHideBlueValueRadioButton.Size = new System.Drawing.Size(76, 17);
            this.ChaseHideBlueValueRadioButton.TabIndex = 27;
            this.ChaseHideBlueValueRadioButton.Text = "Blue Value";
            this.ChaseHideBlueValueRadioButton.UseVisualStyleBackColor = true;
            // 
            // ChaseHideGreenValueRadioButton
            // 
            this.ChaseHideGreenValueRadioButton.AutoSize = true;
            this.ChaseHideGreenValueRadioButton.Enabled = false;
            this.ChaseHideGreenValueRadioButton.Location = new System.Drawing.Point(89, 19);
            this.ChaseHideGreenValueRadioButton.Name = "ChaseHideGreenValueRadioButton";
            this.ChaseHideGreenValueRadioButton.Size = new System.Drawing.Size(84, 17);
            this.ChaseHideGreenValueRadioButton.TabIndex = 26;
            this.ChaseHideGreenValueRadioButton.Text = "Green Value";
            this.ChaseHideGreenValueRadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Message:";
            // 
            // ChaseHideRedValueRadioButton
            // 
            this.ChaseHideRedValueRadioButton.AutoSize = true;
            this.ChaseHideRedValueRadioButton.Checked = true;
            this.ChaseHideRedValueRadioButton.Enabled = false;
            this.ChaseHideRedValueRadioButton.Location = new System.Drawing.Point(8, 19);
            this.ChaseHideRedValueRadioButton.Name = "ChaseHideRedValueRadioButton";
            this.ChaseHideRedValueRadioButton.Size = new System.Drawing.Size(75, 17);
            this.ChaseHideRedValueRadioButton.TabIndex = 16;
            this.ChaseHideRedValueRadioButton.TabStop = true;
            this.ChaseHideRedValueRadioButton.Text = "Red Value";
            this.ChaseHideRedValueRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Values you want filled with your message:";
            // 
            // ChaseHideCreateButton
            // 
            this.ChaseHideCreateButton.Enabled = false;
            this.ChaseHideCreateButton.Location = new System.Drawing.Point(283, 161);
            this.ChaseHideCreateButton.Name = "ChaseHideCreateButton";
            this.ChaseHideCreateButton.Size = new System.Drawing.Size(75, 23);
            this.ChaseHideCreateButton.TabIndex = 14;
            this.ChaseHideCreateButton.Text = "Create";
            this.ChaseHideCreateButton.UseVisualStyleBackColor = true;
            this.ChaseHideCreateButton.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // ChaseHideMessageTextBox
            // 
            this.ChaseHideMessageTextBox.Enabled = false;
            this.ChaseHideMessageTextBox.Location = new System.Drawing.Point(8, 55);
            this.ChaseHideMessageTextBox.Multiline = true;
            this.ChaseHideMessageTextBox.Name = "ChaseHideMessageTextBox";
            this.ChaseHideMessageTextBox.Size = new System.Drawing.Size(350, 100);
            this.ChaseHideMessageTextBox.TabIndex = 13;
            // 
            // TextHideTabPage
            // 
            this.TextHideTabPage.Controls.Add(this.label2);
            this.TextHideTabPage.Controls.Add(this.TextHideHelpLabel);
            this.TextHideTabPage.Controls.Add(this.TextHideAddHiddenTextButton);
            this.TextHideTabPage.Controls.Add(this.TextHideToAddTextBox);
            this.TextHideTabPage.Controls.Add(this.TextHideBrowseButton);
            this.TextHideTabPage.Controls.Add(this.label1);
            this.TextHideTabPage.Controls.Add(this.TextHideImageFileTextBox);
            this.TextHideTabPage.Location = new System.Drawing.Point(4, 22);
            this.TextHideTabPage.Name = "TextHideTabPage";
            this.TextHideTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TextHideTabPage.Size = new System.Drawing.Size(366, 190);
            this.TextHideTabPage.TabIndex = 1;
            this.TextHideTabPage.Text = "Text Hide";
            this.TextHideTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Text To Hide:";
            // 
            // TextHideHelpLabel
            // 
            this.TextHideHelpLabel.AutoSize = true;
            this.TextHideHelpLabel.Location = new System.Drawing.Point(8, 133);
            this.TextHideHelpLabel.Name = "TextHideHelpLabel";
            this.TextHideHelpLabel.Size = new System.Drawing.Size(62, 13);
            this.TextHideHelpLabel.TabIndex = 8;
            this.TextHideHelpLabel.TabStop = true;
            this.TextHideHelpLabel.Text = "Help/About";
            this.TextHideHelpLabel.Click += new System.EventHandler(this.LinkLabelClicked);
            // 
            // TextHideAddHiddenTextButton
            // 
            this.TextHideAddHiddenTextButton.Location = new System.Drawing.Point(241, 128);
            this.TextHideAddHiddenTextButton.Name = "TextHideAddHiddenTextButton";
            this.TextHideAddHiddenTextButton.Size = new System.Drawing.Size(120, 23);
            this.TextHideAddHiddenTextButton.TabIndex = 7;
            this.TextHideAddHiddenTextButton.Text = "Add Hidden Text";
            this.TextHideAddHiddenTextButton.UseVisualStyleBackColor = true;
            this.TextHideAddHiddenTextButton.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // TextHideToAddTextBox
            // 
            this.TextHideToAddTextBox.Location = new System.Drawing.Point(6, 62);
            this.TextHideToAddTextBox.Multiline = true;
            this.TextHideToAddTextBox.Name = "TextHideToAddTextBox";
            this.TextHideToAddTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextHideToAddTextBox.Size = new System.Drawing.Size(356, 60);
            this.TextHideToAddTextBox.TabIndex = 6;
            // 
            // TextHideBrowseButton
            // 
            this.TextHideBrowseButton.Location = new System.Drawing.Point(287, 17);
            this.TextHideBrowseButton.Name = "TextHideBrowseButton";
            this.TextHideBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.TextHideBrowseButton.TabIndex = 2;
            this.TextHideBrowseButton.Text = "Browse";
            this.TextHideBrowseButton.UseVisualStyleBackColor = true;
            this.TextHideBrowseButton.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image File Location:";
            // 
            // TextHideImageFileTextBox
            // 
            this.TextHideImageFileTextBox.Location = new System.Drawing.Point(6, 19);
            this.TextHideImageFileTextBox.Name = "TextHideImageFileTextBox";
            this.TextHideImageFileTextBox.ReadOnly = true;
            this.TextHideImageFileTextBox.Size = new System.Drawing.Size(275, 20);
            this.TextHideImageFileTextBox.TabIndex = 0;
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "JPEG Image files|*.jpg|PNG Image files|*.png";
            // 
            // OpenFile
            // 
            this.OpenFile.Filter = "Image files|*.jpg; *.png";
            // 
            // ImageEnigmaForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 216);
            this.Controls.Add(this.ImageHideTabControl);
            this.MaximizeBox = false;
            this.Name = "ImageEnigmaForm";
            this.Text = "Hide Messages In Pictures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            this.ImageHideTabControl.ResumeLayout(false);
            this.PixelHideTabPage.ResumeLayout(false);
            this.PixelHideTabPage.PerformLayout();
            this.ChaseHideTabPage.ResumeLayout(false);
            this.ChaseHideTabPage.PerformLayout();
            this.TextHideTabPage.ResumeLayout(false);
            this.TextHideTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ImageHideTabControl;
        private System.Windows.Forms.TabPage PixelHideTabPage;
        private System.Windows.Forms.TabPage TextHideTabPage;
        private System.Windows.Forms.Button TextHideBrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextHideImageFileTextBox;
        private System.Windows.Forms.TextBox TextHideToAddTextBox;
        private System.Windows.Forms.Button TextHideAddHiddenTextButton;
        private System.Windows.Forms.LinkLabel TextHideHelpLabel;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PixelHideCreateButton;
        private System.Windows.Forms.TextBox PixelHideMessageTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox PixelHideBlueValueCheckBox;
        private System.Windows.Forms.CheckBox PixelHideGreenValueCheckBox;
        private System.Windows.Forms.CheckBox PixelHideRedValueCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel PixelHideHelpLabel;
        private System.Windows.Forms.TabPage ChaseHideTabPage;
        private System.Windows.Forms.Button ChaseHideCreateButton;
        private System.Windows.Forms.TextBox ChaseHideMessageTextBox;
        private System.Windows.Forms.RadioButton ChaseHideRedValueRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton ChaseHideBlueValueRadioButton;
        private System.Windows.Forms.RadioButton ChaseHideGreenValueRadioButton;
    }
}

