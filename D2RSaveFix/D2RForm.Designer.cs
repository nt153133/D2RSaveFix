namespace D2RSaveFix
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.rTxtLog = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(72, 31);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Save";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // rTxtLog
            // 
            this.rTxtLog.Location = new System.Drawing.Point(10, 49);
            this.rTxtLog.Name = "rTxtLog";
            this.rTxtLog.Size = new System.Drawing.Size(431, 161);
            this.rTxtLog.TabIndex = 1;
            this.rTxtLog.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(99, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 31);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Set Normal/CRC";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 225);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rTxtLog);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "D2R Saved Game Fix";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.RichTextBox rTxtLog;

        #endregion
    }
}