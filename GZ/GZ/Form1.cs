using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.GZip;

namespace GZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UnZIP_Click(object sender, EventArgs e)
        {
            byte[] dataBuffer = new byte[16184];

            try
            {
                // Verify file and target directory have been selected.
                if (txtGZ.Text.Length > 0 && txtTarget.Text.Length > 0)
                {
                    UnZIP.Enabled = false;  // Disable button and clear progress label.
                    lblProgress.Text = "";

                    using (System.IO.Stream fs = new FileStream(txtGZ.Text, FileMode.Open, FileAccess.Read))
                    {
                        using (GZipInputStream gzipStream = new GZipInputStream(fs))
                        {
                            string fnOut = Path.Combine(txtTarget.Text, Path.GetFileNameWithoutExtension(txtGZ.Text));

                            using (FileStream fsOut = File.Create(fnOut))
                            {
                                // Send stream to file and call progress routine every 2 seconds.
                                StreamUtils.Copy(gzipStream, fsOut, dataBuffer, gzProgress, TimeSpan.FromSeconds(2), fs, "UnZip");
                            }

                            // Re-enable button, notify the user and reset progress indicators.
                            UnZIP.Enabled = true;
                            MessageBox.Show("Unpacking complete.");
                            lblProgress.Text = "";
                            pbUnzip.Value = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please specify both the source GZ file and the target directory.");
                    UnZIP.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
                UnZIP.Enabled = true;
            }
        
        }

        private void gzProgress(object sender, ProgressEventArgs e)
        {
            //Calculate the progress based on file size and current position within the 
            // input stream being written.
            Stream zipStream = (Stream)sender;
            float pctComplete = (zipStream.Position / (float)zipStream.Length) * 100;
            lblProgress.Text = ((int)pctComplete).ToString() + "% complete.";
            pbUnzip.Value = (int)pctComplete;
            Application.DoEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdGZFile.ShowDialog() == DialogResult.OK)
            {
                txtGZ.Text = ofdGZFile.FileName;
                lblProgress.Text = "";
            }
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            if(fbdTarget.ShowDialog() == DialogResult.OK)
            {
                txtTarget.Text = fbdTarget.SelectedPath;
            }
        }
    }
}
