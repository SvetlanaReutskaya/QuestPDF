using System;
using System.Collections.Generic;
using System.Text;

namespace QuestPDF.CVSample.Models
{
    public class ListSection : TextSection
    {
        public List<string> Items { get; set; }
        public ListSymbol Symbol { get; set; }
    }
    public abstract class IconedListSection : ListSection
    {
        public CVImage Icon { get; set; }
    }
}
