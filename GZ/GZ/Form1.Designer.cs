namespace GZ
{
    partial class Form1
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
            this.UnZIP = new System.Windows.Forms.Button();
            this.txtGZ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ofdGZFile = new System.Windows.Forms.OpenFileDialog();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.fbdTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.btnTarget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UnZIP
            // 
            this.UnZIP.Location = new System.Drawing.Point(168, 227);
            this.UnZIP.Name = "UnZIP";
            this.UnZIP.Size = new System.Drawing.Size(104, 23);
            this.UnZIP.TabIndex = 0;
            this.UnZIP.Text = "Unpack Files";
            this.UnZIP.UseVisualStyleBackColor = true;
            this.UnZIP.Click += new System.EventHandler(this.UnZIP_Click);
            // 
            // txtGZ
            // 
            this.txtGZ.Location = new System.Drawing.Point(12, 12);
            this.txtGZ.Name = "txtGZ";
            this.txtGZ.Size = new System.Drawing.Size(250, 20);
            this.txtGZ.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select GZ File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofdGZFile
            // 
            this.ofdGZFile.FileName = "openFileDialog1";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(12, 76);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(250, 20);
            this.txtTarget.TabIndex = 3;
            // 
            // btnTarget
            // 
            this.btnTarget.Location = new System.Drawing.Point(154, 102);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(108, 23);
            this.btnTarget.TabIndex = 4;
            this.btnTarget.Text = "Target Directory";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGZ);
            this.Controls.Add(this.UnZIP);
            this.Name = "Form1";
            this.Text = "GZ File Unpack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnZIP;
        private System.Windows.Forms.TextBox txtGZ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog ofdGZFile;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.FolderBrowserDialog fbdTarget;
        private System.Windows.Forms.Button btnTarget;
    }
}

