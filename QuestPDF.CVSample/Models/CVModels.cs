using System;
using System.Collections.Generic;

namespace QuestPDF.CVSample.Models
{
    public class CVModel
    {
        public HeaderSection Header { get; set; }
        public TextSection About { get; set; }
        public IconedListSection Skills { get; set; }
        public ExperienceSection Experience { get; set; }
        public ExperienceSection Education { get; set; }
        public ListSection Hobbies { get; set; }
    }
}
