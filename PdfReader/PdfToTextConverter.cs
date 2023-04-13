using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadForMe
{
    public static class PdfToTextConverter
    {
        private static IDictionary<int, string> BookContent = new Dictionary<int, string>();
        private static int currentPage;
        public static IDictionary<int,string> ExtractTextFromPdf(string path)
        {
            if(path == null)
            {
                throw new ArgumentNullException (path,"Path does not have any file");
            }

            // If we want every page text in separate page 
            using (PdfReader reader = new PdfReader(path))
            {            
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    var strategy = new SimpleTextExtractionStrategy();
                    var textFromPage = PdfTextExtractor.GetTextFromPage(reader, page, strategy);
                    BookContent.Add(page, textFromPage);
                }
                return BookContent;
            }
        }

        public static void ReadFromStart()
        {
            for(int page = 5; page <= BookContent.Count(); page++)
            {
                Console.WriteLine(BookContent[page]);
                currentPage = page;
                TextToSpecchConverter.TextToSpeech(BookContent[page]);
            }
        }
        public static void ReadSpecificPage(int pageForReadding)
        {
            Console.WriteLine(BookContent[pageForReadding]);
            TextToSpecchConverter.TextToSpeech(BookContent[pageForReadding]);
        }

        public static void ReadNextPage()
        {
            int nextPage = currentPage;
            Console.WriteLine(BookContent[nextPage]);
            TextToSpecchConverter.TextToSpeech(BookContent[nextPage]);
        }
    }
}
