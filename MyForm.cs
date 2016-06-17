using System.Data;
using System.Windows.Forms;

namespace Safiye
{
    public abstract class MyForm : Form
    {
        public DataTable MyDataTable = new DataTable();

        public virtual void SetDataTable(DataTable pDt)
        {
            MyDataTable = pDt;

        }
    }
}