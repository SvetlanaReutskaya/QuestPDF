using System;
using System.Collections.Generic;
using System.Text;

namespace QuestPDF.CVSample.Models
{
    public abstract class CVImage
    {
        public byte[] Content { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public abstract class PhotoBorder
    {
        public BorderType Type { get; set; }
        public string Color { get; set; }
    }

    public class CVPhoto : CVImage
    {
        public ImageShape Shape { get; set; }
        public PhotoBorder Border { get; set; }
    }
}
