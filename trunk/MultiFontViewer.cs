using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MultiFontViewer
{



    public sealed class RuntimeConfig
    {
        private static RuntimeConfig instance = null;
        static readonly object padlock = new object();
        private static List<RuntimeConfigUpdateAware> runtimeConfigUpdateAwareRegistrars = new List<RuntimeConfigUpdateAware>();

        private static string sampleText;
        private static int sampleSize;
        private static int fontEntriesPerPage;
        private static FontStyle sampleFontStyle;


        public RuntimeConfig()
        {
        }

        public static RuntimeConfig Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new RuntimeConfig();
                    }
                    return instance;
                }
            }

        }

        public static FontStyle SampleFontStyle
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
        

        public static string SampleText
        { 
            get{
                return sampleText;
            }
            set{
                sampleText = value;
                notifyRegistrars();
            }
        }

        public static int SampleSize
        {
            get {
                return sampleSize;
            }
            set {
                sampleSize = value;
                notifyRegistrars();
            }
        }

        public static int EntriesPerPage
        {
            get { 
                return fontEntriesPerPage; 
            }

            set {
                fontEntriesPerPage = value;
                notifyRegistrars();
            }
        }

        private static void notifyRegistrars()
        {
            foreach(RuntimeConfigUpdateAware configAware in runtimeConfigUpdateAwareRegistrars)
            {
                configAware.runtimeConfigurationUpdated();
            }
        }

        public static void registerForNotifications(RuntimeConfigUpdateAware configAware)
        {
            runtimeConfigUpdateAwareRegistrars.Add(configAware);
        }
    }

    public interface RuntimeConfigUpdateAware
    {
        void runtimeConfigurationUpdated();
    }

}
