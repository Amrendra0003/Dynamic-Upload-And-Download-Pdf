using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string destinationFilePath = Path.Combine(Path.GetTempPath(), "SelectedFolderPath.txt");
            string sourceFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"file-sample.pdf");
            string fileContent = File.ReadAllText(destinationFilePath) + @"\file-sample.pdf";
            try
            {
                System.IO.File.Copy(sourceFilePath, fileContent);
                MessageBox.Show("PDF file downloaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF file Already exists");
            }

        }
    }
}
