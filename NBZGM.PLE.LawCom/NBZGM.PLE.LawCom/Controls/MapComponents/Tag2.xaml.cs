﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Taizhou.PLE.LawCom.Controls.MapComponents
{
    public partial class Tag2 : UserControl
    {
        public string Text
        {
            get { return this.text.Text; }
            set { this.text.Text = value; }
        }

        public Tag2()
        {
            InitializeComponent();
        }
    }
}
