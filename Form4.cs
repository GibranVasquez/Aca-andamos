﻿using System;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form gcrear = new Form6();
            gcrear.ShowDialog();
        }
    }
}
