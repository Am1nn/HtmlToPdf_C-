using System;
using System.IO;
using NReco.PdfGenerator;

class Program
{
    static void Main(string[] args)
    {
        var htmlFilePath = @"C:\Users\Amin\Desktop\twstt\index.html";

        var htmlContent = File.ReadAllText(htmlFilePath);

        var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
        var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

        var pdfFilePath = @"output.pdf";
        File.WriteAllBytes(pdfFilePath, pdfBytes);

    }
}
