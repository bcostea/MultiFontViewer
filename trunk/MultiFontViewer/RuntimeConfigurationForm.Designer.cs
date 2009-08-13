namespace MultiFontViewer
{
    partial class RuntimeConfigurationForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.sampleTextBox = new System.Windows.Forms.TextBox();
            this.sampleSize = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sampleTextLabel = new System.Windows.Forms.Label();
            this.fontEntriesPerPageTextBox = new System.Windows.Forms.TextBox();
            this.fontEntriesPerPageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(373, 201);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(292, 201);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 4;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // sampleTextBox
            // 
            this.sampleTextBox.Location = new System.Drawing.Point(14, 26);
            this.sampleTextBox.Multiline = true;
            this.sampleTextBox.Name = "sampleTextBox";
            this.sampleTextBox.Size = new System.Drawing.Size(434, 129);
            this.sampleTextBox.TabIndex = 3;
            // 
            // sampleSize
            // 
            this.sampleSize.Location = new System.Drawing.Point(69, 166);
            this.sampleSize.Name = "sampleSize";
            this.sampleSize.Size = new System.Drawing.Size(100, 20);
            this.sampleSize.TabIndex = 6;
            this.sampleSize.TextChanged += new System.EventHandler(this.sampleSize_TextChanged);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(14, 170);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(49, 13);
            this.sizeLabel.TabIndex = 7;
            this.sizeLabel.Text = "Font size";
            // 
            // sampleTextLabel
            // 
            this.sampleTextLabel.AutoSize = true;
            this.sampleTextLabel.Location = new System.Drawing.Point(13, 7);
            this.sampleTextLabel.Name = "sampleTextLabel";
            this.sampleTextLabel.Size = new System.Drawing.Size(62, 13);
            this.sampleTextLabel.TabIndex = 8;
            this.sampleTextLabel.Text = "Sample text";
            // 
            // fontEntriesPerPageTextBox
            // 
            this.fontEntriesPerPageTextBox.Location = new System.Drawing.Point(348, 166);
            this.fontEntriesPerPageTextBox.Name = "fontEntriesPerPageTextBox";
            this.fontEntriesPerPageTextBox.Size = new System.Drawing.Size(100, 20);
            this.fontEntriesPerPageTextBox.TabIndex = 9;
            this.fontEntriesPerPageTextBox.TextChanged += new System.EventHandler(this.fontEntriesPerPageTextBox_TextChanged);
            // 
            // fontEntriesPerPageLabel
            // 
            this.fontEntriesPerPageLabel.AutoSize = true;
            this.fontEntriesPerPageLabel.Location = new System.Drawing.Point(186, 170);
            this.fontEntriesPerPageLabel.Name = "fontEntriesPerPageLabel";
            this.fontEntriesPerPageLabel.Size = new System.Drawing.Size(156, 13);
            this.fontEntriesPerPageLabel.TabIndex = 10;
            this.fontEntriesPerPageLabel.Text = "Number of font entries per page";
            // 
            // RuntimeConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(460, 232);
            this.Controls.Add(this.fontEntriesPerPageLabel);
            this.Controls.Add(this.fontEntriesPerPageTextBox);
            this.Controls.Add(this.sampleTextLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.sampleSize);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.sampleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RuntimeConfigurationForm";
            this.Text = "Multi Font Viewer configuration";
            this.Load += new System.EventHandler(this.SampleTextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox sampleTextBox;
        private System.Windows.Forms.TextBox sampleSize;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label sampleTextLabel;
        private System.Windows.Forms.TextBox fontEntriesPerPageTextBox;
        private System.Windows.Forms.Label fontEntriesPerPageLabel;

    }
}