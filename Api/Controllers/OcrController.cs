using System;
using Api.Dto;
using Logic.Ocr;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using Tesseract;

namespace Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class OcrController : ControllerBase
    {
        private readonly ITextExtractor _textExtractor;

        public OcrController(ITextExtractor textExtractor)
        {
            _textExtractor = textExtractor;
        }

        [HttpPost]
        [Route("ocr/img")]
        public IActionResult GetTextFromImage(TextFromImageDto dto)
        {
            var pix = Pix.LoadTiffFromMemory(Convert.FromBase64String(dto.Base64Image));
            var resp = _textExtractor.Extract(pix);

            return Ok(resp);
        }
    }
}
