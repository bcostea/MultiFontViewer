using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace MultiFontViewer
{
    public partial class multiFontViewerForm : Form, RuntimeConfigUpdateAware
    {

        public multiFontViewerForm()
        {
            InitializeComponent();
        }

        private void multiFontViewerForm_Load(object sender, EventArgs e)
        {
            setupRuntimeConfiguration();
            initializeControls();
        }

        private void setupRuntimeConfiguration()
        {
            RuntimeConfig.SampleText = "Sample text";
            RuntimeConfig.SampleSize = 40;
            RuntimeConfig.EntriesPerPage = 10;
            RuntimeConfig.registerForNotifications(this);
        }

        private void initializeControls()
        {
            fontListView.View = System.Windows.Forms.View.Details;
            fontListView.Columns.Add("Font Name", 300, HorizontalAlignment.Left);
            
            foreach (Font font in FontUtil.getInstalledFonts())
            {
                FontItem fontItem = new FontItem(font.Name, font.ToString());
                fontListView.Items.Add(fontItem);
            }
        }

        private void fontListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontListView.SelectedItems.Count > 0)
            {
                refreshSingleFontView(fontListView.SelectedItems[0].Text);
                refreshFontSamples();
            }

        }

        public void refreshSingleFontView(string familyName)
        {
            FontFamily fontFamily = new FontFamily(familyName);
            Font font;
            try
            {
                font = new Font(fontFamily, RuntimeConfig.SampleSize, RuntimeConfig.SampleFontStyle);
            }
            catch (Exception exce)
            {
                font = new Font(fontFamily, RuntimeConfig.SampleSize, FontUtil.getFirstSupportedStyle(fontFamily));    
            }

            fontViewRichTextBox.Font = font;
            fontViewRichTextBox.Text = RuntimeConfig.SampleText;
        }

        private void setSampleTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RuntimeConfigurationForm sample = new RuntimeConfigurationForm();
            sample.Show();
        }

        public void runtimeConfigurationUpdated()
        {
            if (fontListView.SelectedItems.Count > 0)
            {
                refreshSingleFontView(fontListView.SelectedItems[0].Text);
                refreshFontSamples();
            }
        }

        private void setListSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            Application.Exit();
        }

        public void refreshFontSamples()
        {
            int height=1200;
            Bitmap bitmap = new Bitmap(1200, height, PixelFormat.Format32bppPArgb);
            using (Graphics gfx = Graphics.FromImage(bitmap))
            {
                gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                FontPainter fontPainter = new FontPainter(fontListView, gfx);
                height = fontPainter.paintFontSamples();
            }
            canvas.BackgroundImage = bitmap;
            canvas.Size = new Size(bitmap.Size.Width, height);
            canvas.Invalidate();
        }

        private void boldMenuItem_Click(object sender, EventArgs e)
        {
            if(!boldMenuItem.Checked)
                RuntimeConfig.SampleFontStyle = RuntimeConfig.SampleFontStyle | FontStyle.Bold;
            else
                RuntimeConfig.SampleFontStyle = RuntimeConfig.SampleFontStyle ^ FontStyle.Bold;
            
            boldMenuItem.Checked = !boldMenuItem.Checked;
        }

        private void italicMenuItem_Click(object sender, EventArgs e)
        {
            if (!italicMenuItem.Checked)
                RuntimeConfig.SampleFontStyle = RuntimeConfig.SampleFontStyle | FontStyle.Italic;
            else
                RuntimeConfig.SampleFontStyle = RuntimeConfig.SampleFontStyle ^ FontStyle.Italic;

            italicMenuItem.Checked = !italicMenuItem.Checked;
        }

        private void underlineMenuItem_Click(object sender, EventArgs e)
        {
            if (!underlineMenuItem.Checked)
                RuntimeConfig.SampleFontStyle = RuntimeConfig.SampleFontStyle | FontStyle.Underline;
            else
                RuntimeConfig.SampleFontStyle = RuntimeConfig.SampleFontStyle ^ FontStyle.Underline;
            
            underlineMenuItem.Checked = !underlineMenuItem.Checked;
        }

        private void strikethroughMenuItem_Click(object sender, EventArgs e)
        {
            if (!strikethroughMenuItem.Checked)
                RuntimeConfig.SampleFontStyle = RuntimeConfig.SampleFontStyle | FontStyle.Strikeout;
            else
                RuntimeConfig.SampleFontStyle = RuntimeConfig.SampleFontStyle ^ FontStyle.Strikeout;

            strikethroughMenuItem.Checked = !strikethroughMenuItem.Checked;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Multi Font Viewer\n Xander Tools\n http://xandertools.com/utilities\n http://www.gridpulse.com\n\nThis software is released under the GPL.\nVisit the support site for more info.", "About Multi Font Viewer");
        }

    }

    public class FontItem : System.Windows.Forms.ListViewItem
    {
        string fontName = "";
        string fontType= "";

        public FontItem(string fontName, string fontType)
    {
            this.fontName = fontName;
            this.fontType = fontType;
            base.Text = fontName;
    }

        public string FontName
        {
            get { return fontName; }
        }

        public string FontType
        {
            get { return fontType; }
        }
    }
}
