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
    public partial class Form_Process : Form
    {
        public Form_Process()
        {
            InitializeComponent();
        }

        private void Form_Process_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
