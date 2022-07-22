using System;
using System.Collections.Generic;
using System.Text;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace QuestPDF
{
    public abstract class Theme
    {
        public abstract string MainFont { get;  }
        public abstract string FontColor { get;  }
        public abstract float FontSize { get;  }
        public abstract FontWeight FontWeight { get;  }

        public abstract string HeaderFont { get;  }
        public abstract string HeaderColor { get;  }
        public abstract float HeaderSize { get;  }
        public abstract FontWeight HeaderWeight { get;  }

        public abstract string FooterFont { get; }
        public abstract string FooterColor { get; }
        public abstract float FooterSize { get; }
        public abstract FontWeight FooterWeight { get; }

        public abstract PageSize PageSize { get;  }
        public abstract string PageColor { get;  }
    }

    public abstract class DefaultTheme : Theme
    {
        public override string MainFont => Fonts.Verdana;
        public override float FontSize => 12;
        public override FontWeight FontWeight => FontWeight.Medium;

        public override string HeaderFont => Fonts.TimesRoman;
        public override float HeaderSize => 16;
        public override FontWeight HeaderWeight => FontWeight.ExtraBold;

        public override string FooterFont => Fonts.Verdana;
        public override float FooterSize => 10;
        public override FontWeight FooterWeight => FontWeight.ExtraLight;

        public override PageSize PageSize => PageSizes.A4;
    }

    public class DarkTheme : DefaultTheme
    {
        public override string FontColor => Colors.White;
        public override string HeaderColor => Colors.LightBlue.Lighten1;
        public override string FooterColor => Colors.LightGreen.Lighten1;
        public override string PageColor => Colors.Blue.Darken4;
    }

    public class LightTheme : DefaultTheme
    {
        public override string FontColor => Colors.Blue.Darken4;
        public override string HeaderColor => Colors.LightBlue.Darken4;
        public override string FooterColor => Colors.LightGreen.Darken4;
        public override string PageColor => Colors.White;
    }
}
