using System.Drawing;
using System.Windows.Forms;

namespace Safiye.Controls
{
    class MyGridControl : IMyControl
    {
        private readonly DataGridView _control;

        public MyGridControl(DataGridView control)
        {
            _control = control;
        }

        public void SetColor(string color)
        {
            _control.BackgroundColor = ColorTranslator.FromHtml(color);
        }

        public void SetTextColor(string color)
        {
        }
    }
}