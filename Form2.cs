using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Safiye.Data;
using Safiye.Properties;

namespace Safiye
{
    public partial class Form2 : MyForm
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            gridPosTrnx.DataSource = MyDataTable;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridPosTrnx_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = (DataGridView)sender;
            var rowIndex = e.RowIndex;
            RecordDetail.ShowGridDetail(grid, rowIndex);
        }
    }
}
