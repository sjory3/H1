﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Thread t = new Thread(sleep);
            t.Name = "Sleep";
            t.Priority = ThreadPriority.Lowest;
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello";
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sleep()
        {
            Thread.Sleep(5000);
        }
    }
}
