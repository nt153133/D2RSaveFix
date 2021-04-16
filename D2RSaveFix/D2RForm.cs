using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2RSaveFix
{
    public partial class Form1 : Form
    {
        private static int ChecksumOffset => 0x0C;
        private static string FilePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.Personal)).FullName, "Saved Games\\Diablo II Resurrected Tech Alpha");
            
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files (*.d2s)|*.d2s";
            dlg.CheckFileExists = true;
            dlg.InitialDirectory = path;
            string filename = path;
            
            using (dlg)
            {
                DialogResult res = dlg.ShowDialog();
                if (res == DialogResult.OK)
                {
                    filename = dlg.FileName;
                }
            }
            
            if (File.Exists(filename))
            {
                rTxtLog.Text = $"Editing {Path.GetFileName(filename)}\n";
                FilePath = filename;
                btnSave.Enabled = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(FilePath))
            {
                rTxtLog.Text += $"Reading {Path.GetFileName(FilePath)}\n";
                
                var m_fileData = File.ReadAllBytes(FilePath);
                
                rTxtLog.Text += $"Setting byte 0x25 to 0x8\n";
                m_fileData[0x25] = 0x8;
                
                rTxtLog.Text += $"Calculating Checksum\n";
                Checksum.UpdateChecksum(m_fileData, ChecksumOffset);
                
                File.WriteAllBytes(FilePath, m_fileData);
                rTxtLog.Text += $"Done Writing {Path.GetFileName(FilePath)}\n";
            }
            
        }
    }
}