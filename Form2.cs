using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThisNonsenseMustStop
{
    public partial class Form2 : Form
    {

        private static Form2 instance;
        private Form2()
        { 
            InitializeComponent();
            this.Text = "About";
        }

        public static Form2 getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Form2();

            }

            return instance;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void close_about_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
