using Ndi.Attributes;
namespace MultiFontViewer
{

    partial class MultiFontViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiFontViewerForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSampleTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.setListSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikethroughMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.fontListAndPreviewContainer = new System.Windows.Forms.SplitContainer();
            this.fontListView = new System.Windows.Forms.ListView();
            this.fontViewRichTextBox = new System.Windows.Forms.RichTextBox();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.mainMenu.SuspendLayout();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.fontListAndPreviewContainer.Panel1.SuspendLayout();
            this.fontListAndPreviewContainer.Panel2.SuspendLayout();
            this.fontListAndPreviewContainer.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sampleOptionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(615, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSampleTextToolStripMenuItem,
            this.menuSeparator,
            this.setListSizeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // setSampleTextToolStripMenuItem
            // 
            this.setSampleTextToolStripMenuItem.Name = "setSampleTextToolStripMenuItem";
            this.setSampleTextToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.setSampleTextToolStripMenuItem.Text = "Configuration...";
            this.setSampleTextToolStripMenuItem.Click += new System.EventHandler(this.setSampleTextToolStripMenuItem_Click);
            // 
            // menuSeparator
            // 
            this.menuSeparator.Name = "menuSeparator";
            this.menuSeparator.Size = new System.Drawing.Size(159, 6);
            // 
            // setListSizeToolStripMenuItem
            // 
            this.setListSizeToolStripMenuItem.Name = "setListSizeToolStripMenuItem";
            this.setListSizeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.setListSizeToolStripMenuItem.Text = "Exit";
            this.setListSizeToolStripMenuItem.Click += new System.EventHandler(this.setListSizeToolStripMenuItem_Click);
            // 
            // sampleOptionsToolStripMenuItem
            // 
            this.sampleOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldMenuItem,
            this.italicMenuItem,
            this.underlineMenuItem,
            this.strikethroughMenuItem});
            this.sampleOptionsToolStripMenuItem.Name = "sampleOptionsToolStripMenuItem";
            this.sampleOptionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.sampleOptionsToolStripMenuItem.Text = "Sample styles";
            // 
            // boldMenuItem
            // 
            this.boldMenuItem.Name = "boldMenuItem";
            this.boldMenuItem.Size = new System.Drawing.Size(150, 22);
            this.boldMenuItem.Text = "Bold";
            this.boldMenuItem.Click += new System.EventHandler(this.boldMenuItem_Click);
            // 
            // italicMenuItem
            // 
            this.italicMenuItem.Name = "italicMenuItem";
            this.italicMenuItem.Size = new System.Drawing.Size(150, 22);
            this.italicMenuItem.Text = "Italic";
            this.italicMenuItem.Click += new System.EventHandler(this.italicMenuItem_Click);
            // 
            // underlineMenuItem
            // 
            this.underlineMenuItem.Name = "underlineMenuItem";
            this.underlineMenuItem.Size = new System.Drawing.Size(150, 22);
            this.underlineMenuItem.Text = "Underline";
            this.underlineMenuItem.Click += new System.EventHandler(this.underlineMenuItem_Click);
            // 
            // strikethroughMenuItem
            // 
            this.strikethroughMenuItem.Name = "strikethroughMenuItem";
            this.strikethroughMenuItem.Size = new System.Drawing.Size(150, 22);
            this.strikethroughMenuItem.Text = "Strikethrough";
            this.strikethroughMenuItem.Click += new System.EventHandler(this.strikethroughMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainContainer
            // 
            this.mainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 24);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.fontListAndPreviewContainer);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.AutoScroll = true;
            this.mainContainer.Panel2.Controls.Add(this.scrollPanel);
            this.mainContainer.Size = new System.Drawing.Size(615, 249);
            this.mainContainer.SplitterDistance = 204;
            this.mainContainer.TabIndex = 1;
            // 
            // fontListAndPreviewContainer
            // 
            this.fontListAndPreviewContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontListAndPreviewContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontListAndPreviewContainer.Location = new System.Drawing.Point(0, 0);
            this.fontListAndPreviewContainer.Name = "fontListAndPreviewContainer";
            this.fontListAndPreviewContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // fontListAndPreviewContainer.Panel1
            // 
            this.fontListAndPreviewContainer.Panel1.Controls.Add(this.fontListView);
            // 
            // fontListAndPreviewContainer.Panel2
            // 
            this.fontListAndPreviewContainer.Panel2.Controls.Add(this.fontViewRichTextBox);
            this.fontListAndPreviewContainer.Size = new System.Drawing.Size(204, 249);
            this.fontListAndPreviewContainer.SplitterDistance = 140;
            this.fontListAndPreviewContainer.TabIndex = 0;
            // 
            // fontListView
            // 
            this.fontListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontListView.FullRowSelect = true;
            this.fontListView.GridLines = true;
            this.fontListView.Location = new System.Drawing.Point(0, 0);
            this.fontListView.MultiSelect = false;
            this.fontListView.Name = "fontListView";
            this.fontListView.Size = new System.Drawing.Size(202, 138);
            this.fontListView.TabIndex = 0;
            this.fontListView.UseCompatibleStateImageBehavior = false;
            this.fontListView.SelectedIndexChanged += new System.EventHandler(this.fontListView_SelectedIndexChanged);
            // 
            // fontViewRichTextBox
            // 
            this.fontViewRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.fontViewRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontViewRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontViewRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.fontViewRichTextBox.Name = "fontViewRichTextBox";
            this.fontViewRichTextBox.ReadOnly = true;
            this.fontViewRichTextBox.Size = new System.Drawing.Size(202, 103);
            this.fontViewRichTextBox.TabIndex = 3;
            this.fontViewRichTextBox.Text = "";
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.canvas);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(405, 247);
            this.scrollPanel.TabIndex = 0;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(405, 247);
            this.canvas.TabIndex = 5;
            this.canvas.TabStop = false;
            // 
            // multiFontViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 273);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "multiFontViewerForm";
            this.Text = "Multi Font Viewer 0.1";
            this.Load += new System.EventHandler(this.multiFontViewerForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            this.mainContainer.ResumeLayout(false);
            this.fontListAndPreviewContainer.Panel1.ResumeLayout(false);
            this.fontListAndPreviewContainer.Panel2.ResumeLayout(false);
            this.fontListAndPreviewContainer.ResumeLayout(false);
            this.scrollPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSampleTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setListSizeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer fontListAndPreviewContainer;
        private System.Windows.Forms.ListView fontListView;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sampleOptionsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox fontViewRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem boldMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikethroughMenuItem;
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.PictureBox canvas;
    }
}