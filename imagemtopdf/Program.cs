using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;

namespace imagemtopdf
{
    class Program
    {
        static void Main(string[] args)
        {
            criapdf();
        }
        public static void criapdf() {
            PdfDocument doc = new PdfDocument();
            doc.Info.Title = "Renato lindo";
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            gfx.DrawString("Renato é Lindo", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
            string path = @"C:\Users\renatolacerda\Desktop\tesseract\lol.pdf";
            doc.Save(path);
        }
        public static void imgTopdf()
        {
                
        }
    }
}
