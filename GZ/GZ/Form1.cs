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
            // Use a 4K buffer. Any larger is a waste.    
            byte[] dataBuffer = new byte[4096];

            try
            {
                if (txtGZ.Text.Length > 0 && txtTarget.Text.Length > 0)
                {
                    using (System.IO.Stream fs = new FileStream(txtGZ.Text, FileMode.Open, FileAccess.Read))
                    {
                        using (GZipInputStream gzipStream = new GZipInputStream(fs))
                        {
                            // Change this to your needs
                            string fnOut = Path.Combine(txtTarget.Text, Path.GetFileNameWithoutExtension(txtGZ.Text));

                            using (FileStream fsOut = File.Create(fnOut))
                            {
                                StreamUtils.Copy(gzipStream, fsOut, dataBuffer);
                            }

                            Process.Start(txtTarget.Text);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please specify both the source GZ file and the target directory.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdGZFile.ShowDialog() == DialogResult.OK)
            {
                txtGZ.Text = ofdGZFile.FileName;
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
