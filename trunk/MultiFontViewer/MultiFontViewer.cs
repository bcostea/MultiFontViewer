using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using NanoDI.Attributes;

namespace MultiFontViewer
{


    [Component("runtimeConfig")]
    class RuntimeConfig
    {
        private List<IRuntimeConfigUpdateAware> runtimeConfigUpdateAwareRegistrars = new List<IRuntimeConfigUpdateAware>();

        private string sampleText;
        private int sampleSize;
        private int fontEntriesPerPage;
        private FontStyle sampleFontStyle;


        public FontStyle SampleFontStyle
        {
            get
            {
                return sampleFontStyle;
            }
            set
            {
                sampleFontStyle = value;
                notifyRegistrars();
            }
        }
        

        public string SampleText
        { 
            get{
                return sampleText;
            }
            set{
                sampleText = value;
                notifyRegistrars();
            }
        }

        public int SampleSize
        {
            get {
                return sampleSize;
            }
            set {
                sampleSize = value;
                notifyRegistrars();
            }
        }

        public int EntriesPerPage
        {
            get { 
                return fontEntriesPerPage; 
            }

            set {
                fontEntriesPerPage = value;
                notifyRegistrars();
            }
        }

        private void notifyRegistrars()
        {
            foreach(IRuntimeConfigUpdateAware configAware in runtimeConfigUpdateAwareRegistrars)
            {
                configAware.runtimeConfigurationUpdated();
            }
        }

        public void registerForNotifications(IRuntimeConfigUpdateAware configAware)
        {
            runtimeConfigUpdateAwareRegistrars.Add(configAware);
        }
    }

    public interface IRuntimeConfigUpdateAware
    {
        void runtimeConfigurationUpdated();
    }
}
