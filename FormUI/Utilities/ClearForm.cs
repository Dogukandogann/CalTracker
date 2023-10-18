using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI.Utilities
{
    public static class FormHelpers
    {
        public static void Clear(Control.ControlCollection koleksiyon)
        {
            foreach (Control ctrl in koleksiyon)
            {
                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
                }
                else if (ctrl is ListBox)
                {
                    ((ListBox)ctrl).Items.Clear();
                }
                else if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl is KryptonNumericUpDown)
                {
                    ((KryptonNumericUpDown)ctrl).Value = 0;
                }
                else if (ctrl is KryptonComboBox)
                {
                    ((KryptonComboBox)ctrl).SelectedIndex = -1;
                }
                else if (ctrl is KryptonTextBox)
                {
                    ((KryptonTextBox)ctrl).Clear();
                }
            }
        }
    }
}
