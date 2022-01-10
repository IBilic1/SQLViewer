using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SQLVIewer.Extensions
{
    static class ValidationExtension
    {
        public static void Clear(this Control control) => control.Text = "";

        public static bool IsNotEmpty(this IDictionary<Control, Control> dictionary)
        {
            bool valid = true;
            foreach (KeyValuePair<Control, Control> pair in dictionary)
            {
                if (string.IsNullOrEmpty(pair.Key.Text))
                {
                    valid = false;
                    pair.Value.Visible = true;
                }
            }
            return valid;
        }
    }
}
