﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NanoDI;
using NanoDI.Attributes;

namespace MultiFontViewer
{
    public partial class RuntimeConfigurationForm : Form
    {
        private List<String> invalidFields = new List<String>();

        RuntimeConfig runtimeConfig = (RuntimeConfig)NanoDI.ApplicationContext.GetComponent("runtimeConfig");

        public RuntimeConfigurationForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            runtimeConfig.SampleText = sampleTextBox.Text;
            runtimeConfig.SampleSize = int.Parse(sampleSize.Text);
            runtimeConfig.EntriesPerPage = int.Parse(fontEntriesPerPageTextBox.Text);

            this.Hide();
            this.Dispose();
        }

        private void SampleTextForm_Load(object sender, EventArgs e)
        {
            sampleTextBox.Text = runtimeConfig.SampleText;
            sampleSize.Text = runtimeConfig.SampleSize + "";
            fontEntriesPerPageTextBox.Text = runtimeConfig.EntriesPerPage + "";
        }

        private void sampleSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(sampleSize.Text);
                validateField(sampleSize);
            }
            catch (Exception exce)
            {
                invalidateField(sampleSize);
            }
        }



        private void fontEntriesPerPageTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(fontEntriesPerPageTextBox.Text);
                validateField(fontEntriesPerPageTextBox);
            }
            catch (Exception exce)
            {

                invalidateField(fontEntriesPerPageTextBox);
            }
        }

        private void invalidateField(Control c)
        {
            c.BackColor = Color.Red;
            invalidFields.Add(c.Name);
            doneButton.Enabled = false;
        }

        private void validateField(Control c)
        {
            c.BackColor = Color.White;
            invalidFields.Remove(c.Name);
            enableDoneButtonIfValid();
        }

        private void enableDoneButtonIfValid()
        {
            if (invalidFields.Count < 1)
            {
                doneButton.Enabled = true;
            }
        }
    }
}