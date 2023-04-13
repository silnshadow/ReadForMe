using System;
using System.Globalization;

namespace ReadForMe
{
    class Program
    {
        private static readonly string StdDateTimeFormatForUrl = "dd MMM yyyy";
        private static readonly  CultureInfo StdCultureForUrl = new CultureInfo("de-DE");
        static void Main(string[] args)
        {
            //TextToSpecchConverter.GetSpeechSynthesizerConfiguration();
            //file path for real book : C:\Users\prashantsingh.vinayk\Downloads\Who will cry when you die.pdf
            //string readIt = PdfToTextConverter.ExtractTextFromPdf(@"C:\Users\prashantsingh.vinayk\Downloads\Who will cry when you die.pdf");
            //Console.WriteLine(readIt);
            //if(readIt == null)
            //{
            ////    throw new ArgumentNullException(readIt, "Nothing is there to read");
            //}
            //TextToSpecchConverter.TextToSpeech(readIt);
            //Console.ReadKey();
            //PdfToTextConverter.ExtractTextFromPdf(@"C:\Users\prashantsingh.vinayk\Downloads\Who will cry when you die.pdf");
            //PdfToTextConverter.ReadFromStart();
            Console.WriteLine("*********************");
            //PdfToTextConverter.ReadNextPage();
            //Console.WriteLine("*********************");
            //PdfToTextConverter.ReadSpecificPage(5);
            //DateConverterTest();
            FormatDateTimeForUrl(DateTime.Now.Date);
            Console.WriteLine("*********************");
            Console.ReadKey();           
        }

        private static void DateConverterTest()
        {
            Console.WriteLine(DateTime.Now.Date.ToString("dd MMM yyyy")); // let's say this is March 15th, 2019
            var culture = new System.Globalization.CultureInfo("en-US"); // setting the culture to Brazilian Portuguese
            Console.WriteLine(DateTime.Now.Date.ToString("D", culture)); // prints 'sexta-feira, 15 de mar?o de 2019'
            Console.WriteLine(DateTime.Now.Date.ToString("d", culture)); // prints 'Friday, March 15th, 2019' 
            Console.WriteLine(DateTime.Now.Date.ToString("dd MMM yyyy")); // prints 'Friday, March 15th, 2019' 
        }

        private static string FormatDateTimeByCulture(string format, IFormatProvider cultureInfo, DateTime dateTime)
        {
            if (format != StdDateTimeFormatForUrl && !cultureInfo.Equals(StdCultureForUrl) && dateTime != DateTime.Now.Date)
            {
                return dateTime.ToString(format, cultureInfo);
            }
            return DateTime.Now.Date.ToString(StdDateTimeFormatForUrl, StdCultureForUrl);
        }
        public static void FormatDateTimeForUrl(DateTime dateTime)
        {
            Console.WriteLine(DateTime.Now.Date.ToString(StdDateTimeFormatForUrl));
            Console.WriteLine(FormatDateTimeByCulture(StdDateTimeFormatForUrl, StdCultureForUrl, dateTime));
        }
    }
}
