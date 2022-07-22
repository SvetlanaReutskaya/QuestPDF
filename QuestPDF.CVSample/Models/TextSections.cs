using System;
using System.Collections.Generic;
using System.Text;

namespace QuestPDF.CVSample.Models
{
    public abstract class TextSection
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class HeaderSection
    {
        public string FIO { get; set; }
        public CVPhoto Photo { get; set; }
    }

    public class WorkSection 
    {
        public string Company { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public ListSection Responsibilities { get; set; }
    }

    public class ExperienceSection : TextSection
    {
        public List<WorkSection> Works{ get; set; }
    }
}
