using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.DAO
{
    class Reset
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }
            }

        }
        public static void ResetFocus(Control textbox1, Control textbox2)
        {
            if (textbox1.Focus() == true)
            {
                textbox2.Focus();
            }
            else if (textbox2.Focus() == true)
            {
                textbox1.Focus();
            }
        }

        //public static void ResetData (Control f)
        //{
        //    foreach(Control item in f.Controls)
        //        if(item is TextBox)
        //        {
        //            TextBox txt = (TextBox)item;
        //            txt.Text = null;
        //        }
        //}
    }
}
