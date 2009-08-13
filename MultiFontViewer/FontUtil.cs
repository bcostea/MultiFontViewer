using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Text;

namespace MultiFontViewer
{
    class FontUtil
    {

        public static List<FontFamily> getInstalledFontFamilies()
        {
            FontFamily[] fontFamilies;
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();

            fontFamilies = installedFontCollection.Families;
            List<FontFamily> fontFamilyList = new List<FontFamily>(fontFamilies.Length);
            fontFamilyList.AddRange(fontFamilies);

            return fontFamilyList;
        }

        public static List<Font> getInstalledFonts()
        {
            List<FontFamily> fontFamilies = getInstalledFontFamilies();
            List<Font> fonts = new List<Font>(fontFamilies.Count);

            foreach (FontFamily fontFamily in fontFamilies)
            {
                    fonts.Add(new Font(fontFamily, 12, getFirstSupportedStyle(fontFamily)));
            }

            return fonts;
        }

        public static FontStyle getFirstSupportedStyle(FontFamily fontFamily)
        {
            if (fontFamily.IsStyleAvailable(FontStyle.Regular))
            {
                return FontStyle.Regular;
            }
            else if (fontFamily.IsStyleAvailable(FontStyle.Bold))
            {
                return FontStyle.Bold;
            }
            else if (fontFamily.IsStyleAvailable(FontStyle.Italic))
            {
                return FontStyle.Italic;
            }
            else
                return FontStyle.Strikeout;

        }

    }
}
