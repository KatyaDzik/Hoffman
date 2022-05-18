using GemBox.Document;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
    
        static public HuffmanTree huffmanTree = new HuffmanTree();          
        static string message = "";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static public void CompressTextFile(string filePath, string binFilePath, string codingSchemePath)
        {
            string inputFile = File.ReadAllText(filePath);

            huffmanTree.Build_Tree(inputFile);

            BitArray bit_array = huffmanTree.Encode(inputFile);

            byte[] bytes = new byte[bit_array.Length / 8 + (bit_array.Length % 8 == 0 ? 0 : 1)];
            bit_array.CopyTo(bytes, 0);

            File.WriteAllBytes(binFilePath, bytes);
            message = "Text File Encoded Successfully";
            MessageBox.Show(message);
         

            var stringBuilder = new StringBuilder();

            for (int i = 0; i < bit_array.Count; i++)
            {
                char bitChar = bit_array[i] ? '1' : '0';
                stringBuilder.Append(bitChar);
            }
            var stringBuilder2 = stringBuilder.ToString();
            File.WriteAllText(codingSchemePath, stringBuilder2);
            message = "Coding Scheme File Created Successfully";
            MessageBox.Show(message);
        }

        static public void ExtractTextFile(string binFilePath, string extractFilePath)
        {
            byte[] bytes2 = File.ReadAllBytes(binFilePath);
            var bitarray = new BitArray(bytes2);

            string decoded = huffmanTree.Decode(bitarray);

            File.WriteAllText(extractFilePath, decoded);

            message = "Text File Decoded Successfuly";
            MessageBox.Show(message);

        }

        static public void CompressDocxFile(string filePath, string binFilePath, string codingSchemePath)
        {
            string docxString = GetTextFromWordFile(filePath);

            huffmanTree.Build_Tree(docxString);

            BitArray bit_array = huffmanTree.Encode(docxString);

            byte[] bytes = new byte[bit_array.Length / 8 + (bit_array.Length % 8 == 0 ? 0 : 1)];
            bit_array.CopyTo(bytes, 0);

            File.WriteAllBytes(binFilePath, bytes);

            message = "Docx File Encoded Successfully";
            MessageBox.Show(message);

            var stringBuilder = new StringBuilder();

            for (int i = 0; i < bit_array.Count; i++)
            {
                char bitChar = bit_array[i] ? '1' : '0';
                stringBuilder.Append(bitChar);
            }
            var stringBuilder2 = stringBuilder.ToString();
            File.WriteAllText(codingSchemePath, stringBuilder2);
            message = "Coding Scheme File Created Successfully";
            MessageBox.Show(message);
        }

        static public string GetTextFromWordFile(string filePath)
        {
            ComponentInfo.SetLicense("AKSJUY-9IUEY-2YUW7-HSGDT-6NHJY");

            
            var document = DocumentModel.Load(filePath);

            string text = document.Content.ToString();
            return text;
        }

        static public void ExtractDocxFile(string binFilePath, string extractFilePath)
        {

            ComponentInfo.SetLicense("AKSJUY-9IUEY-2YUW7-HSGDT-6NHJY");
            byte[] bytes2 = File.ReadAllBytes(binFilePath);
            var bitarray = new BitArray(bytes2);

            string decoded = huffmanTree.Decode(bitarray);

            var document = new DocumentModel();

            document.Sections.Add(
                new GemBox.Document.Section(document,
                    new GemBox.Document.Paragraph(document, decoded)));

            document.Save(extractFilePath);
            message = "Docx File Decoded Successfuly";
            MessageBox.Show(message);
        }

        static public void CompressPdfFile(string filePath, string binFilePath, string codingSchemePath)
        {

            string pdfString = GetTextFromPdfFile(filePath);
            huffmanTree.Build_Tree(pdfString);
            BitArray bit_array = huffmanTree.Encode(pdfString);

            byte[] bytes = new byte[bit_array.Length / 8 + (bit_array.Length % 8 == 0 ? 0 : 1)];
            bit_array.CopyTo(bytes, 0);

            File.WriteAllBytes(binFilePath, bytes);

            message = "Pdf File Encoded Successfully";
            MessageBox.Show(message);

            var stringBuilder = new StringBuilder();

            for (int i = 0; i < bit_array.Count; i++)
            {
                char bitChar = bit_array[i] ? '1' : '0';
                stringBuilder.Append(bitChar);
            }
            var stringBuilder2 = stringBuilder.ToString();
            File.WriteAllText(codingSchemePath, stringBuilder2);
            message = "Coding Scheme File Created Successfully";
            MessageBox.Show(message);

        }


        static public string GetTextFromPdfFile(string filePath)
        {
            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader(filePath))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            return text.ToString();
        }

        static public void ExtractPdfFile(string binFilePath, string extractFilePath)
        {
            byte[] bytes2 = File.ReadAllBytes(binFilePath);
            var bitarray = new BitArray(bytes2);

            string decoded = huffmanTree.Decode(bitarray);

            iTextSharp.text.Document oDoc = new iTextSharp.text.Document();
            PdfWriter.GetInstance(oDoc, new FileStream(extractFilePath, FileMode.Create));
            oDoc.Open();
            oDoc.Add(new iTextSharp.text.Paragraph(decoded));
            oDoc.Close();

            message = "Pdf File Decoded Successfuly";
            MessageBox.Show(message);
        }
    }
}
