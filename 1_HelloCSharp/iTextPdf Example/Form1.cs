using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace iTextPdf_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Application.StartupPath, "test.pdf");

            // Document 객체 생성
            Document doc = new Document(iTextSharp.text.PageSize.LETTER);

            // PdfWriter가 doc 내용을 simple.pdf 파일에 쓰도록 설정
            PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.Open();

            doc.AddTitle("Simple PDF 생성 예제");
            doc.AddAuthor("Alex");
            doc.AddCreationDate();

            // 한글쓰기

            PdfPTable table = new PdfPTable(3);
            PdfPCell cellImage = new PdfPCell(new Phrase("4444")) { Colspan = 1, Rowspan = 3 };
            table.AddCell(cellImage);
            AddCellText(new string[] { "1111", "2222", "3333" }, ref table);




            doc.Add(table);

            doc.Add(new Paragraph("Hello"));
            doc.Close();
        }

        private void AddCellText(string[] text, ref PdfPTable table)
        {
            PdfPCell[] cells = new PdfPCell[text.Length];

            for (int i = 0; i < cells.Length; i++)
            {
                table.AddCell(new PdfPCell(new Phrase(text[i])) { Colspan = 2 });
            }

        }
    }
}
