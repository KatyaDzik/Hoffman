
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialogEncoding = new System.Windows.Forms.OpenFileDialog();
            this.InputFileForEncoding = new System.Windows.Forms.TextBox();
            this.OutputFileForEncoding = new System.Windows.Forms.TextBox();
            this.InputFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseFileEncoding = new System.Windows.Forms.Button();
            this.compressFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDecompressTxt = new System.Windows.Forms.Button();
            this.btnBrowseTxtBin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.outputTxtDecompress = new System.Windows.Forms.TextBox();
            this.InputTxtBin = new System.Windows.Forms.TextBox();
            this.openFileDialogTextBin = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDecompressWord = new System.Windows.Forms.Button();
            this.btnBrowseWordBin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.outputWordDecompress = new System.Windows.Forms.TextBox();
            this.InputWordBin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialogWordBin = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDecompressPDF = new System.Windows.Forms.Button();
            this.btnBrowsePDFBin = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.outputPDFDecompress = new System.Windows.Forms.TextBox();
            this.InputPDFBin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialogPDFBin = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogEncoding
            // 
            this.openFileDialogEncoding.FileName = "openFileDialog1";
            // 
            // InputFileForEncoding
            // 
            this.InputFileForEncoding.Location = new System.Drawing.Point(101, 75);
            this.InputFileForEncoding.Name = "InputFileForEncoding";
            this.InputFileForEncoding.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InputFileForEncoding.Size = new System.Drawing.Size(476, 22);
            this.InputFileForEncoding.TabIndex = 0;
            // 
            // OutputFileForEncoding
            // 
            this.OutputFileForEncoding.Location = new System.Drawing.Point(101, 109);
            this.OutputFileForEncoding.Name = "OutputFileForEncoding";
            this.OutputFileForEncoding.Size = new System.Drawing.Size(476, 22);
            this.OutputFileForEncoding.TabIndex = 1;
            // 
            // InputFile
            // 
            this.InputFile.AutoSize = true;
            this.InputFile.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFile.Location = new System.Drawing.Point(14, 75);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(80, 20);
            this.InputFile.TabIndex = 2;
            this.InputFile.Text = "Input File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "OutputFile";
            // 
            // btnBrowseFileEncoding
            // 
            this.btnBrowseFileEncoding.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFileEncoding.Location = new System.Drawing.Point(583, 70);
            this.btnBrowseFileEncoding.Name = "btnBrowseFileEncoding";
            this.btnBrowseFileEncoding.Size = new System.Drawing.Size(95, 30);
            this.btnBrowseFileEncoding.TabIndex = 4;
            this.btnBrowseFileEncoding.Text = "browse file";
            this.btnBrowseFileEncoding.UseVisualStyleBackColor = true;
            this.btnBrowseFileEncoding.Click += new System.EventHandler(this.btnBrowseFileEncoding_Click);
            // 
            // compressFile
            // 
            this.compressFile.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressFile.Location = new System.Drawing.Point(684, 70);
            this.compressFile.Name = "compressFile";
            this.compressFile.Size = new System.Drawing.Size(95, 30);
            this.compressFile.TabIndex = 5;
            this.compressFile.Text = "compress";
            this.compressFile.UseVisualStyleBackColor = true;
            this.compressFile.Click += new System.EventHandler(this.compressFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Compress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decompress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Text File";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDecompressTxt);
            this.panel1.Controls.Add(this.btnBrowseTxtBin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.outputTxtDecompress);
            this.panel1.Controls.Add(this.InputTxtBin);
            this.panel1.Location = new System.Drawing.Point(12, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 84);
            this.panel1.TabIndex = 9;
            // 
            // btnDecompressTxt
            // 
            this.btnDecompressTxt.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecompressTxt.Location = new System.Drawing.Point(665, 8);
            this.btnDecompressTxt.Name = "btnDecompressTxt";
            this.btnDecompressTxt.Size = new System.Drawing.Size(108, 30);
            this.btnDecompressTxt.TabIndex = 11;
            this.btnDecompressTxt.Text = "decompress";
            this.btnDecompressTxt.UseVisualStyleBackColor = true;
            this.btnDecompressTxt.Click += new System.EventHandler(this.btnDecompressTxt_Click);
            // 
            // btnBrowseTxtBin
            // 
            this.btnBrowseTxtBin.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseTxtBin.Location = new System.Drawing.Point(564, 8);
            this.btnBrowseTxtBin.Name = "btnBrowseTxtBin";
            this.btnBrowseTxtBin.Size = new System.Drawing.Size(95, 30);
            this.btnBrowseTxtBin.TabIndex = 10;
            this.btnBrowseTxtBin.Text = "browse file";
            this.btnBrowseTxtBin.UseVisualStyleBackColor = true;
            this.btnBrowseTxtBin.Click += new System.EventHandler(this.btnBrowseTxtBin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "OutputFile";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-2, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Input File";
            // 
            // outputTxtDecompress
            // 
            this.outputTxtDecompress.Location = new System.Drawing.Point(82, 47);
            this.outputTxtDecompress.Name = "outputTxtDecompress";
            this.outputTxtDecompress.Size = new System.Drawing.Size(476, 22);
            this.outputTxtDecompress.TabIndex = 7;
            // 
            // InputTxtBin
            // 
            this.InputTxtBin.Location = new System.Drawing.Point(82, 8);
            this.InputTxtBin.Name = "InputTxtBin";
            this.InputTxtBin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InputTxtBin.Size = new System.Drawing.Size(476, 22);
            this.InputTxtBin.TabIndex = 6;
            // 
            // openFileDialogTextBin
            // 
            this.openFileDialogTextBin.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDecompressWord);
            this.panel2.Controls.Add(this.btnBrowseWordBin);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.outputWordDecompress);
            this.panel2.Controls.Add(this.InputWordBin);
            this.panel2.Location = new System.Drawing.Point(12, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 84);
            this.panel2.TabIndex = 11;
            // 
            // btnDecompressWord
            // 
            this.btnDecompressWord.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecompressWord.Location = new System.Drawing.Point(665, 8);
            this.btnDecompressWord.Name = "btnDecompressWord";
            this.btnDecompressWord.Size = new System.Drawing.Size(108, 30);
            this.btnDecompressWord.TabIndex = 11;
            this.btnDecompressWord.Text = "decompress";
            this.btnDecompressWord.UseVisualStyleBackColor = true;
            this.btnDecompressWord.Click += new System.EventHandler(this.btnDecompressWord_Click);
            // 
            // btnBrowseWordBin
            // 
            this.btnBrowseWordBin.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseWordBin.Location = new System.Drawing.Point(564, 8);
            this.btnBrowseWordBin.Name = "btnBrowseWordBin";
            this.btnBrowseWordBin.Size = new System.Drawing.Size(95, 30);
            this.btnBrowseWordBin.TabIndex = 10;
            this.btnBrowseWordBin.Text = "browse file";
            this.btnBrowseWordBin.UseVisualStyleBackColor = true;
            this.btnBrowseWordBin.Click += new System.EventHandler(this.btnBrowseWordBin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-2, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "OutputFile";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-2, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Input File";
            // 
            // outputWordDecompress
            // 
            this.outputWordDecompress.Location = new System.Drawing.Point(82, 47);
            this.outputWordDecompress.Name = "outputWordDecompress";
            this.outputWordDecompress.Size = new System.Drawing.Size(476, 22);
            this.outputWordDecompress.TabIndex = 7;
            // 
            // InputWordBin
            // 
            this.InputWordBin.Location = new System.Drawing.Point(82, 8);
            this.InputWordBin.Name = "InputWordBin";
            this.InputWordBin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InputWordBin.Size = new System.Drawing.Size(476, 22);
            this.InputWordBin.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "Word File";
            // 
            // openFileDialogWordBin
            // 
            this.openFileDialogWordBin.FileName = "openFileDialog1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDecompressPDF);
            this.panel3.Controls.Add(this.btnBrowsePDFBin);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.outputPDFDecompress);
            this.panel3.Controls.Add(this.InputPDFBin);
            this.panel3.Location = new System.Drawing.Point(11, 447);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 84);
            this.panel3.TabIndex = 13;
            // 
            // btnDecompressPDF
            // 
            this.btnDecompressPDF.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecompressPDF.Location = new System.Drawing.Point(665, 8);
            this.btnDecompressPDF.Name = "btnDecompressPDF";
            this.btnDecompressPDF.Size = new System.Drawing.Size(108, 30);
            this.btnDecompressPDF.TabIndex = 11;
            this.btnDecompressPDF.Text = "decompress";
            this.btnDecompressPDF.UseVisualStyleBackColor = true;
            this.btnDecompressPDF.Click += new System.EventHandler(this.btnDecompressPDF_Click);
            // 
            // btnBrowsePDFBin
            // 
            this.btnBrowsePDFBin.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsePDFBin.Location = new System.Drawing.Point(564, 8);
            this.btnBrowsePDFBin.Name = "btnBrowsePDFBin";
            this.btnBrowsePDFBin.Size = new System.Drawing.Size(95, 30);
            this.btnBrowsePDFBin.TabIndex = 10;
            this.btnBrowsePDFBin.Text = "browse file";
            this.btnBrowsePDFBin.UseVisualStyleBackColor = true;
            this.btnBrowsePDFBin.Click += new System.EventHandler(this.btnBrowsePDFBin_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-2, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "OutputFile";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-2, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Input File";
            // 
            // outputPDFDecompress
            // 
            this.outputPDFDecompress.Location = new System.Drawing.Point(82, 47);
            this.outputPDFDecompress.Name = "outputPDFDecompress";
            this.outputPDFDecompress.Size = new System.Drawing.Size(476, 22);
            this.outputPDFDecompress.TabIndex = 7;
            // 
            // InputPDFBin
            // 
            this.InputPDFBin.Location = new System.Drawing.Point(82, 8);
            this.InputPDFBin.Name = "InputPDFBin";
            this.InputPDFBin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InputPDFBin.Size = new System.Drawing.Size(476, 22);
            this.InputPDFBin.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 426);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "PDF File";
            // 
            // openFileDialogPDFBin
            // 
            this.openFileDialogPDFBin.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.compressFile);
            this.Controls.Add(this.btnBrowseFileEncoding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputFile);
            this.Controls.Add(this.OutputFileForEncoding);
            this.Controls.Add(this.InputFileForEncoding);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogEncoding;
        public System.Windows.Forms.TextBox InputFileForEncoding;
        private System.Windows.Forms.TextBox OutputFileForEncoding;
        private System.Windows.Forms.Label InputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseFileEncoding;
        private System.Windows.Forms.Button compressFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDecompressTxt;
        private System.Windows.Forms.Button btnBrowseTxtBin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox outputTxtDecompress;
        public System.Windows.Forms.TextBox InputTxtBin;
        private System.Windows.Forms.OpenFileDialog openFileDialogTextBin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDecompressWord;
        private System.Windows.Forms.Button btnBrowseWordBin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox outputWordDecompress;
        public System.Windows.Forms.TextBox InputWordBin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialogWordBin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDecompressPDF;
        private System.Windows.Forms.Button btnBrowsePDFBin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox outputPDFDecompress;
        public System.Windows.Forms.TextBox InputPDFBin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialogPDFBin;
    }
}

