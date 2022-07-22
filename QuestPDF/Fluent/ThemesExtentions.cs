using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Drawing;
using QuestPDF.Infrastructure;

namespace QuestPDF.Fluent
{
    public static class ThemesExtentions
    {
        public static IDocumentContainer SetTheme(this IDocumentContainer document, Theme defaultTheme)
        {
            (document as DocumentContainer).MainTheme = defaultTheme;

            return document;
        }
    }
}
