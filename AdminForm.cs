﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleK
{
    public partial class AdminForm : MaterialForm
    {
        public AdminForm(Dictionary<string, List<MenuItem>> itemsCategory)
        {
            InitializeComponent();
        }
    }
}
