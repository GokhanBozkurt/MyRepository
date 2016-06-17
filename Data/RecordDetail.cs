using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Safiye.Data
{
    public class RecordDetail
    {

        public static void ShowGridDetail(DataGridView gridView, int rowIndex)
        {
            var gridDictionary =
                gridView.SelectedRows[rowIndex].Cells.Cast<DataGridViewCell>()
                    .ToDictionary(item => item.OwningColumn.DataPropertyName, item => item.Value.ToString());
            int y = 15;
            int x = 15;
            int nextControlY = 40;
            int controlShiftX = 50;
            int labelWidth = 200;
            var formDetail = new Form()
            {
                AutoScroll = true,
                Text = String.Format("{0} grid single record", gridView.Name)
            };
            foreach (var item in gridDictionary.OrderBy(a => a.Key))
            {
                AddControl2From(x, y, item, labelWidth, formDetail, controlShiftX);
                y += nextControlY;
            }
            formDetail.WindowState = FormWindowState.Maximized;
            formDetail.ShowDialog();
        }
        private static void AddControl2From(int x, int y, KeyValuePair<string, string> item, int labelWidth, Form formDetail, int controlShiftX)
        {
            var point = new Point() {X = x, Y = y};
            var label = new Label()
            {
                Text = String.Format("{0} : ", item.Key),
                Location = point,
                Visible = true,
                Width = labelWidth
            };
            formDetail.Controls.Add(label);
            point.X = point.X + label.Width + controlShiftX;
            var text = new TextBox()
            {
                Text = item.Value,
                Visible = true,
                Location = point,
                Width = item.Value.Length*10 + 25
            };
            formDetail.Controls.Add(text);
        }
    }
}
