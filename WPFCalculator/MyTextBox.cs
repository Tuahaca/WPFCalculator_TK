﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//  Developed by: Tuaha Mohammad
namespace WPFCalculator
{
    class MyTextBox : System.Windows.Controls.TextBox
    {
        protected override void OnPreviewGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            e.Handled = true;
            base.OnPreviewGotKeyboardFocus(e);
        }
 
    }
}
