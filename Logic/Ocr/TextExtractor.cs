using Tesseract;

namespace Logic.Ocr
{
    public interface ITextExtractor
    {
        string Extract(Pix img);
    }

    public class TextExtractor : ITextExtractor
    {
        public string Extract(Pix img)
        {
            var engine = new TesseractEngine("./tessdata", "pol", EngineMode.Default);
            var page = engine.Process(img, PageSegMode.Auto);
            var text = page.GetText();

            return text;
        }
    }
}
