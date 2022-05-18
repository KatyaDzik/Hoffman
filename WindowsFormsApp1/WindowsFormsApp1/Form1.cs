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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseFileEncoding_Click(object sender, EventArgs e)
        {
            openFileDialogEncoding.InitialDirectory = "C:";
            openFileDialogEncoding.Title = "Open File";
            openFileDialogEncoding.FileName = " ";
            openFileDialogEncoding.Filter = "All Files (*.*)|*.*";
            InputFileForEncoding.Text = openFileDialogEncoding.FileName;
            if (openFileDialogEncoding.ShowDialog() == DialogResult.Cancel)
            {

            }
            else
            {
                InputFileForEncoding.Text = openFileDialogEncoding.FileName;
            }
        }

        private void compressFile_Click(object sender, EventArgs e)
        {
            string filePath = openFileDialogEncoding.FileName;        
            string binPath = filePath;                          
            string codingSchemePath = filePath;                 

            int index = codingSchemePath.IndexOf(".");
            if (index > 0)
            {
                codingSchemePath = codingSchemePath.Substring(0, index);
            }
            codingSchemePath = codingSchemePath + "_codingScheme.txt";     

            index = binPath.IndexOf(".");
            if (index > 0)
            {
                binPath = binPath.Substring(0, index);
            }
            binPath = binPath + ".bin";
            OutputFileForEncoding.Text = binPath;
            
            string extension = Path.GetExtension(filePath);
       
            if (extension == ".txt")
            {
                Program.CompressTextFile(filePath, binPath, codingSchemePath);
            }
            else if (extension == ".docx")
            {
                 Program.CompressDocxFile(filePath, binPath, codingSchemePath);

            }
            else if (extension == ".pdf")
              {
                  Program.CompressPdfFile(filePath, binPath, codingSchemePath);
              }

        }

        private void btnBrowseTxtBin_Click(object sender, EventArgs e)
        {
            openFileDialogTextBin.InitialDirectory = "C:";       
            openFileDialogTextBin.Title = "Browse File";
            openFileDialogTextBin.FileName = " ";
            openFileDialogTextBin.DefaultExt = "bin";
            openFileDialogTextBin.Filter = "Only Binary File (*.bin*)|*.bin*";
            if (openFileDialogTextBin.ShowDialog() == DialogResult.Cancel)
            {

            }
            else
            {
                InputTxtBin.Text = openFileDialogTextBin.FileName;
            }
        }

        private void btnDecompressTxt_Click(object sender, EventArgs e)
        {
            string filePath = openFileDialogTextBin.FileName;
            string binPath = filePath;
            string ExtractPath = filePath;

            int index = ExtractPath.IndexOf(".");
            if (index > 0)
            {
                ExtractPath = ExtractPath.Substring(0, index);
            }
            ExtractPath = ExtractPath + "_extracted.txt";  
            outputTxtDecompress.Text = ExtractPath;
            outputTxtDecompress.Text = filePath;
            Program.ExtractTextFile(binPath, ExtractPath);

        }

        

        private void btnBrowseWordBin_Click(object sender, EventArgs e)
        {
            openFileDialogWordBin.InitialDirectory = "C:";      
            openFileDialogWordBin.Title = "Browse File";
            openFileDialogWordBin.FileName = " ";
            openFileDialogWordBin.DefaultExt = "bin";
            openFileDialogWordBin.Filter = "Only Binary File (*.bin*)|*.bin*";
            if (openFileDialogWordBin.ShowDialog() == DialogResult.Cancel)
            {

            }
            else
            {
                InputWordBin.Text = openFileDialogWordBin.FileName;
            }
        }

        private void btnDecompressWord_Click(object sender, EventArgs e)
        {
            string filePath = openFileDialogWordBin.FileName;          
            string binPath = filePath;
            string ExtractPath = filePath;
            int index = ExtractPath.IndexOf(".");           
                                                            
            if (index > 0)
            {
                ExtractPath = ExtractPath.Substring(0, index);
            }
            ExtractPath = ExtractPath + "_extracted.docx";
            InputWordBin.Text = ExtractPath;
            outputWordDecompress.Text = filePath;
            Program.ExtractDocxFile(binPath, ExtractPath);
        }

        private void btnBrowsePDFBin_Click(object sender, EventArgs e)
        {
            openFileDialogPDFBin.InitialDirectory = "C:";     
            openFileDialogPDFBin.Title = "Browse File";
            openFileDialogPDFBin.FileName = " ";
            openFileDialogPDFBin.DefaultExt = "bin";
            openFileDialogPDFBin.Filter = "Only Binary File (*.bin*)|*.bin*";
            if (openFileDialogPDFBin.ShowDialog() == DialogResult.Cancel)
            {

            }
            else
            {
                InputPDFBin.Text = openFileDialogPDFBin.FileName;
            }
        }

        private void btnDecompressPDF_Click(object sender, EventArgs e)
        {

            string filePath = openFileDialogPDFBin.FileName;         
            string binPath = filePath;
            string ExtractPath = filePath;

            int index = ExtractPath.IndexOf(".");
            if (index > 0)
            {
                ExtractPath = ExtractPath.Substring(0, index);
            }
            ExtractPath = ExtractPath + "_extracted.pdf";           
            outputPDFDecompress.Text = ExtractPath;
            InputPDFBin.Text = filePath;
            Program.ExtractPdfFile(binPath, ExtractPath);

        }
    }
}
