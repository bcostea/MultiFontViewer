using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using NanoDI.Attributes;

namespace MultiFontViewer
{
    class FontPainter
    {
        private int selectedIndex = 0;
        private int numberOfFonts = 0;
        private int fontsPerPage = 0;
        
        private int maximumIndex = 0;
        private int minimumIndex = 0;

        private int lastRow = 0;

        private ListView fontListView;
        private Graphics graphics;
        RuntimeConfig runtimeConfig = (RuntimeConfig)NanoDI.ApplicationContext.GetComponent("runtimeConfig");

        public FontPainter(ListView fontListView, Graphics graphics){
            this.fontListView=fontListView;
            this.graphics = graphics;
        }

        public int paintFontSamples()
        {
            initializeVariables();
            iterateFontsAndPaint();
            return lastRow+100;
        }

        private void iterateFontsAndPaint()
        {
            string sampleText = runtimeConfig.SampleText;

            for (int i = minimumIndex; i < maximumIndex; i++)
            {
                string currentFontName = fontListView.Items[i].Text;

                paintSampleTextAt(sampleText, currentFontName, i);
            }
        }

        private void paintSampleTextAt(string sampleText, string fontName, int row)
        {

            FontFamily fontFamily = new FontFamily(fontName);
            Font font = new Font(fontFamily, runtimeConfig.SampleSize, FontUtil.getFirstSupportedStyle(fontFamily), GraphicsUnit.Pixel);
            

            int x = 200;
            int y = lastRow.Equals(0) ? 0 : lastRow;
            
            lastRow = lastRow + font.Height + 10;
            paintFontName(fontName, y);
            paintFontSample(sampleText, font, x, y);

            paintLine();
        }

        private void paintFontSample(string sampleText, Font font, int x, int y)
        {
            SolidBrush sampleBrush = new SolidBrush(Color.Black);
            graphics.DrawString(sampleText, font, sampleBrush, new Point(x, y + 10));
        }

        private void paintLine()
        {
            SolidBrush lineBrush = new SolidBrush(Color.SteelBlue);
            Pen pen = new Pen(lineBrush);
            graphics.DrawLine(pen, new Point(0, lastRow), new Point(1200, lastRow));
        }

        private void paintFontName(string fontName, int y)
        {
            FontStyle fs = FontStyle.Regular;
            SolidBrush fontNameBrush = new SolidBrush(Color.SlateGray);

            if (fontListView.SelectedItems.Count > 0 && fontListView.SelectedItems[0].Text.Equals(fontName))
                fs = FontStyle.Bold;

            graphics.DrawString(fontName, new Font("Tahoma", 8, fs), fontNameBrush, new Point(10, y + 2));
        }

        private void initializeVariables()
        {
            fontsPerPage = runtimeConfig.EntriesPerPage;
            numberOfFonts = fontListView.Items.Count;
            calculateSelectedIndex();
            calculateIndexes();
        }

        private void calculateSelectedIndex()
        {
            if (fontListView.SelectedIndices.Count > 0)
            {
                selectedIndex = fontListView.SelectedIndices[0];
            }
            else
            {
                selectedIndex = 0;
            }
        }

        private void calculateIndexes()
        {
            calculateMinimumIndex();
            calculateMaximumIndex();
        }

        private void calculateMinimumIndex()
        {
            minimumIndex = selectedIndex < fontsPerPage / 2 ? minimumIndex : selectedIndex - (fontsPerPage / 2);
        }

        private void calculateMaximumIndex()
        {
            if(minimumIndex <= fontsPerPage / 2)
                maximumIndex = fontsPerPage  > numberOfFonts ? numberOfFonts : fontsPerPage;
            else
                maximumIndex = selectedIndex + (fontsPerPage / 2) > numberOfFonts? numberOfFonts : selectedIndex + fontsPerPage / 2;
        }

    }
}
