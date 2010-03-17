using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Ndi.Attributes;
using Ndi;

namespace MultiFontViewer
{
    [Component("mainForm", Scope.Singleton)]
    public partial class MultiFontViewerForm : Form, IRuntimeConfigUpdateAware
    {
        
        RuntimeConfig runtimeConfig;

        [Inject]
        RuntimeConfigurationForm runtimeConfigForm=null;

        [Inject]
        public MultiFontViewerForm(RuntimeConfig runtimeConfig)
        {
            this.runtimeConfig = runtimeConfig;
            InitializeComponent();
        }

        private void multiFontViewerForm_Load(object sender, EventArgs e)
        {
            setupRuntimeConfiguration();
            initializeControls();
        }

        private void setupRuntimeConfiguration()
        {
            runtimeConfig.SampleText = "Sample text";
            runtimeConfig.SampleSize = 40;
            runtimeConfig.EntriesPerPage = 10;
            runtimeConfig.registerForNotifications(this);
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
                font = new Font(fontFamily, runtimeConfig.SampleSize, runtimeConfig.SampleFontStyle);
            }
            catch (Exception exce)
            {
                font = new Font(fontFamily, runtimeConfig.SampleSize, FontUtil.getFirstSupportedStyle(fontFamily));    
            }

            fontViewRichTextBox.Font = font;
            fontViewRichTextBox.Text = runtimeConfig.SampleText;
        }

        private void setSampleTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runtimeConfigForm.Show();
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
                runtimeConfig.SampleFontStyle = runtimeConfig.SampleFontStyle | FontStyle.Bold;
            else
                runtimeConfig.SampleFontStyle = runtimeConfig.SampleFontStyle ^ FontStyle.Bold;
            
            boldMenuItem.Checked = !boldMenuItem.Checked;
        }

        private void italicMenuItem_Click(object sender, EventArgs e)
        {
            if (!italicMenuItem.Checked)
                runtimeConfig.SampleFontStyle = runtimeConfig.SampleFontStyle | FontStyle.Italic;
            else
                runtimeConfig.SampleFontStyle = runtimeConfig.SampleFontStyle ^ FontStyle.Italic;

            italicMenuItem.Checked = !italicMenuItem.Checked;
        }

        private void underlineMenuItem_Click(object sender, EventArgs e)
        {
            if (!underlineMenuItem.Checked)
                runtimeConfig.SampleFontStyle = runtimeConfig.SampleFontStyle | FontStyle.Underline;
            else
                runtimeConfig.SampleFontStyle = runtimeConfig.SampleFontStyle ^ FontStyle.Underline;
            
            underlineMenuItem.Checked = !underlineMenuItem.Checked;
        }

        private void strikethroughMenuItem_Click(object sender, EventArgs e)
        {
            if (!strikethroughMenuItem.Checked)
                runtimeConfig.SampleFontStyle = runtimeConfig.SampleFontStyle | FontStyle.Strikeout;
            else
                runtimeConfig.SampleFontStyle = runtimeConfig.SampleFontStyle ^ FontStyle.Strikeout;

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
