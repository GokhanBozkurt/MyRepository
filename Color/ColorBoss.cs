using System.Windows.Forms;
using Safiye.Controls;

namespace Safiye.Color
{
    class ColorBoss
    {
        private static ColorBase _colorBase;

        public static void SetBaseColor(ColorBase colorBase)
        {
            _colorBase = colorBase;
        }
        public static void SetPrimaryColor(IMyControl control)
        {
            _colorBase.SetPrimaryColor(control);
        }
        public static void SetPrimaryDarkColor(IMyControl control)
        {
            _colorBase.SetPrimaryDarkColor(control);
        }
        public static void SetPrimaryLightColor(IMyControl control)
        {
            _colorBase.SetPrimaryLightColor(control);
        }
        public static void SetPrimaryMoreLightColor(IMyControl control)
        {
            _colorBase.SetPrimaryMoreLightColor(control);
        }
        public static void SetIconsColor(IMyControl control)
        {
            _colorBase.SetIconsColor(control);
        }

        public static void SetColors(Control form)
        {
            ColorBoss.SetPrimaryColor(new MyControl(form));
            foreach (Control control in form.Controls)
            {
                if (control is Button)
                {
                    ColorBoss.SetIconsColor(new MyControl(control));
                }

                if (control is GroupBox)
                {
                    SetColors(control);
                }
            }
        }
        public static ColorBase GetColorBase(string color)
        {
            switch (color)
            {
                case "Blue":
                    return new BlueColor();
                case "Green":
                    return new GreenColor();
                case "Cyan":
                    return new CyanColor();
                case "BlackAndRed":
                    return new BlackColor();
                case "Teal":
                    return new TealColor();
                default:
                    return new NullColor();
            }
        }
    }
}
