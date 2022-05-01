using System.Diagnostics;
using System.IO;
using Apitron.PDF.Kit;
using Apitron.PDF.Kit.FixedLayout.Resources;
using Apitron.PDF.Kit.FlowLayout.Content;
using Apitron.PDF.Kit.Styles;
using Apitron.PDF.Kit.Styles.Appearance;
using Apitron.PDF.Kit.Styles.Text;

namespace ConverterImageToPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter convert = new Converter();

            //convert.ConvertImageToPDF();
            convert.TransformPDFtoPDFA();
        }
    }
}
