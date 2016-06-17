using System;
using System.Windows.Forms;

namespace Safiye
{
    public partial class Report :  MyForm
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            gridPosTrnx.DataSource = MyDataTable;
        }

        
    }
}
