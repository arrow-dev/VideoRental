﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystem.Forms
{
    public partial class FormStats : Form
    {
        public FormStats(DataTable dt)
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;
        }
    }
}
