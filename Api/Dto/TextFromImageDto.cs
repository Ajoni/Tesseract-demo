using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Api.Dto
{
    public class TextFromImageDto
    {
        public string Base64Image { get; set; }
    }
}
