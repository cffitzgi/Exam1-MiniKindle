﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1_MiniKindle
{
    public partial class LibraryView : Form
    {
        private Library library;

        private BookView bookView;

        BookHandler bookHand;

        public LibraryView()
        {
            InitializeComponent();
        }
    }
}
