using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystem
{
    //Template that other forms can inherit from to keep basic form properties consistant across the application.
    public partial class FormTemplate : Form
    {
        public FormTemplate()
        {
            InitializeComponent();
        }
    }
}
