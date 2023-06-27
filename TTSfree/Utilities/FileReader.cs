using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Office.Interop.Word;
using System.Text;

namespace TTSfree.Utilities
{
    public static class FileReader
    {
        public static string ReadDocxFile(WordprocessingDocument document)
        {
            StringBuilder sb = new StringBuilder();

            Body body = document.MainDocumentPart.Document.Body;

            foreach (var element in body.Elements())
            {
                if (element is DocumentFormat.OpenXml.Wordprocessing.Paragraph)
                {
                    DocumentFormat.OpenXml.Wordprocessing.Paragraph paragraph = (DocumentFormat.OpenXml.Wordprocessing.Paragraph)element;

                    foreach (var run in paragraph.Elements<Run>())
                    {
                        foreach (var text in run.Elements<Text>())
                        {
                            sb.Append(text.Text);
                        }
                    }

                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }

        public static string ReadDocFile(string filePath)
        {
            Application wordApp = new Application();
            Microsoft.Office.Interop.Word.Document document = wordApp.Documents.Open(filePath);

            string text = document.Content.Text;

            document.Close();
            wordApp.Quit();

            return text;
        }
    }
}
