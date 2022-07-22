using System;
using System.Collections.Generic;
using System.Linq;
using QuestPDF.Elements;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace QuestPDF.Drawing
{
    internal class DocumentContainer : IDocumentContainer
    {
        private Theme _theme;
        internal Theme MainTheme { 
            get
            {
                if (_theme != null)
                    return _theme;
                else 
                    return new LightTheme();
            }
            set
            {
                _theme = value;
            }
        }
        internal List<IComponent> Pages { get; set; } = new List<IComponent>();
        
        internal Container Compose()
        {
            var container = new Container();
            
            container
                .Column(column =>
                {
                    Pages
                        .SelectMany(x => new List<Action>()
                        {
                            () => column.Item().PageBreak(),
                            () => column.Item().Component(x)
                        })
                        .Skip(1)
                        .ToList()
                        .ForEach(x => x());
                });

            return container;
        }
    }
}