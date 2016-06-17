using System.Drawing;
using System.Windows.Forms;

namespace Safiye.Controls
{
    class MyControl : IMyControl
    {
        private readonly Control _control;

        public MyControl(Control control)
        {
            _control = control;
        }

        public void SetColor(string color)
        {
            _control.BackColor = ColorTranslator.FromHtml(color);
        }

        public void SetTextColor(string color)
        {
            _control.ForeColor = ColorTranslator.FromHtml(color);            
        }
    }
}