using System;
using System.Windows.Forms;

namespace Safiye.Boss
{
    public static class ControlBoss
    {
        delegate void DelegateListBoxAddItem(ListBox listBox, string text);
        delegate void DelegateSetControlText(Control control, string text);
        delegate void DelegateEnabledControl(Control control, bool enabled);
        delegate int DelegateListBoxSelectedIndex(ListBox listBox);
        delegate void DelegateListBoxAction(ListBox listBox);
        delegate string DelegateListBoxGetSelectedIndex(ListBox listBox,int indexNumber);
        delegate string DelegateGetControlText(Control control);
        delegate DateTime DelegateGetDateTimePickerValue(DateTimePicker control);
        delegate void DelegateControl(Control control);
        delegate bool DelegateGetCheckBoxChecked(CheckBox listBox);

        private static  Control _ownerControl;

        private static string _text;
        private static int _selectedIndex = -1;
        private static bool _isChecked;
        private static DateTime _dateTime = DateTime.MinValue;

        public static void SetOwnerControl(Control ownerControl)
        {
            _ownerControl = ownerControl;
        }

        public static void ListBoxAddItem(ListBox listBox, string text)
        {
            try
            {
                if (listBox.InvokeRequired)
                {
                    DelegateListBoxAddItem d = ListBoxAddItem;
                    _ownerControl.Invoke(d, new object[] { listBox, text });
                }
                else
                {
                    listBox.Items.Add(text);
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static int ListBoxSelectedIndex(ListBox listBox)
        {
            try
            {
                if (listBox.InvokeRequired)
                {
                    DelegateListBoxSelectedIndex d = ListBoxSelectedIndex;
                    _ownerControl.Invoke(d, new object[] { listBox });
                }
                else
                {
                    _selectedIndex = listBox.SelectedIndex;
                }
            }
            catch (Exception)
            {
                // ignored
            }
            return _selectedIndex;
        }

        public static void ListBoxItemsClear(ListBox listBox)
        {
            try
            {
                if (listBox.InvokeRequired)
                {
                    DelegateListBoxAction d = ListBoxItemsClear;
                    _ownerControl.Invoke(d, new object[] { listBox });
                }
                else
                {
                    listBox.Items.Clear();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static string ListBoxGetSelectedIndex(ListBox listBox,int indexNumber)
        {
            try
            {
                if (listBox.InvokeRequired)
                {
                    DelegateListBoxGetSelectedIndex d = ListBoxGetSelectedIndex;
                    _ownerControl.Invoke(d, new object[] { listBox , indexNumber });
                }
                else
                {

                    _text = listBox.Items[indexNumber].ToString(); ;
                }
            }
            catch (Exception)
            {
                // ignored
            }
            return _text;
        }

        public static void FocusControl(Control control)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    DelegateControl d = FocusControl;
                    _ownerControl.Invoke(d, new object[] { control });
                }
                else
                {

                    control.Focus();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
        
        public static string GetControlText(Control control)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    DelegateGetControlText d = GetControlText;
                    _ownerControl.Invoke(d, new object[] { control});
                }
                else
                {

                    _text = control.Text;
                }
            }
            catch (Exception ex)
            {
                // ignored
            }
            return _text;
        }
        public static bool GetCheckBoxChecked(CheckBox control)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    DelegateGetCheckBoxChecked d = GetCheckBoxChecked;
                    _ownerControl.Invoke(d, new object[] { control });
                }
                else
                {

                    _isChecked = control.Checked;
                }
            }
            catch (Exception)
            {
                // ignored
            }
            return _isChecked;
        }
        public static DateTime GetDateTimePickerValue(DateTimePicker dateTimePicker)
        {
            try
            {
                if (dateTimePicker.InvokeRequired)
                {
                    DelegateGetDateTimePickerValue d = GetDateTimePickerValue;
                    _ownerControl.Invoke(d, new object[] { dateTimePicker });
                }
                else
                {

                    _dateTime = dateTimePicker.Value;
                }
            }
            catch (Exception)
            {
                // ignored
            }
            return _dateTime;
        }

        public static void SetControlText(Control control, String text)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    DelegateSetControlText d = SetControlText;
                    _ownerControl.Invoke(d, new object[] { control, text });
                }
                else
                {
                    control.Text=text;
                }
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        public static void EnabledControl(Control control, bool enabled)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    DelegateEnabledControl d = EnabledControl;
                    _ownerControl.Invoke(d, new object[] { control, enabled });
                }
                else
                {
                    control.Enabled = enabled;
                }
            }
            catch (Exception ex)
            {
                // ignored
            }
        }
        public static void VisibledControl(Control control, bool enabled)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    DelegateEnabledControl d = VisibledControl;
                    _ownerControl.Invoke(d, new object[] { control, enabled });
                }
                else
                {
                    control.Visible = enabled;
                }
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        public static void EnabledControls(Boolean enabled)
        {
            foreach (Control control in _ownerControl.Controls)
            {
                if (control is Button || control is TextBox || control is DateTimePicker || control is ComboBox || control is ListBox)
                {
                    ControlBoss.EnabledControl(control, enabled);
                }
            }
        }
    }



}
