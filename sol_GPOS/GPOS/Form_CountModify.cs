﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPOS
{
    public partial class Form_CountModify : Form
    {
        public Form_CountModify()
        {
            InitializeComponent();
        }

        public Form_CountModify(string MenuCount)
        {
            txt_Count.Text = MenuCount;
            InitializeComponent();
        }
    }
}