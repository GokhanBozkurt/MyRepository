using Safiye.Controls;

namespace Safiye.Color
{
    abstract class ColorBase
    {
        public string Primary { get; set; }
        public string PrimaryDark { get; set; }
        public string PrimaryLight { get; set; }
        public string PrimaryText { get; set; }
        public string Icons { get; set; }
        public string IconsTextColor { get; set; }
        public string PrimaryMoreLightColor { get; set; }

        public virtual void SetPrimaryColor(IMyControl control)
        { 
            control.SetColor(Primary);
        }
        public virtual void SetPrimaryDarkColor(IMyControl control)
        {
            control.SetColor(PrimaryDark);
        }
        public virtual void SetPrimaryLightColor(IMyControl control)
        {
            control.SetColor(PrimaryLight);
        }
        public virtual void SetPrimaryMoreLightColor(IMyControl control)
        {
            control.SetColor(PrimaryMoreLightColor);
        }
        public virtual void SetIconsColor(IMyControl control)
        {
            control.SetColor(Icons);
            control.SetTextColor(IconsTextColor);
        }

        

    }
}