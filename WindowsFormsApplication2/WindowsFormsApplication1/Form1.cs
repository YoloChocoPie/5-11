﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            this.Load += Form1_Load;
            this.button1.Click += button1_Click;
        }

        void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aaaaaa");
        }

        void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("helloooo");
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true; ko xoa
            MessageBox.Show("dont go :( ");

        }
    }
}
