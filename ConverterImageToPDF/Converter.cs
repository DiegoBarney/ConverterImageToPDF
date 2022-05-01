using System.Diagnostics;
using System.IO;
using Apitron.PDF.Kit;
using Apitron.PDF.Kit.FixedLayout.Resources;
using Apitron.PDF.Kit.FlowLayout.Content;
using Apitron.PDF.Kit.Styles;

namespace ConverterImageToPDF
{
    public class Converter
    {

        public void ConvertImageToPDF() {
            FlowDocument pdfDocument = new FlowDocument();

            ResourceManager resourceManager = new ResourceManager();

            var image = new Apitron.PDF.Kit.FixedLayout.Resources.XObjects.Image("teste" + 0, @"C:\Users\komyh\Desktop\converter\certidao_casamento.jpeg");

            var image1 = new Apitron.PDF.Kit.FixedLayout.Resources.XObjects.Image("teste" + 1, @"C:\Users\komyh\Desktop\converter\Carteira_motorista_Diego.jpeg");

            resourceManager.RegisterResource(image);
            resourceManager.RegisterResource(image1);


            pdfDocument.Add(new Image(image.ID) { Width = Length.FromPercentage(100), Height = Length.FromPercentage(100) });

            pdfDocument.Add(new Image(image1.ID) { Width = Length.FromPercentage(100), Height = Length.FromPercentage(100) });


            using (Stream stream = File.Create(@"C:\Users\komyh\Desktop\converter\out.pdf"))
            {
                pdfDocument.Write(stream, resourceManager, PDFALevels.A1);
            }
        }

        public void TransformPDFtoPDFA()
        {
            using (Stream stream = File.Open(@"C:\Users\komyh\Desktop\converter\Declaracao2022.pdf", FileMode.Open, FileAccess.Read))
            {
                // create document object and specify the output format
                FixedDocument doc = new FixedDocument(stream, PdfStandard.PDFA);

                // save document
                using (Stream outputStream = File.Create(@"C:\Users\komyh\Desktop\converter\pdfa_Declaracao2022.pdf"))
                {
                    // turn off cross reference stream usage
                    doc.IsCompressedStructure = false;
                    doc.Save(outputStream);
                }
            }
        }
    }
}
