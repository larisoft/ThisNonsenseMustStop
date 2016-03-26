using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThisNonsenseMustStop
{
    public partial class Form4 : Form
    {
        private static Form4 instance;

        public Form4()
        {
            InitializeComponent();
            this.Text = "Remove Exception";
            var dataSource = Exclude.getInstance().getNames(); 
            remove_exception_combo.DataSource = dataSource;
            
        }


        public static Form4 getInstance()
        {

            if (instance == null || instance.IsDisposed) instance = new Form4();

            return instance;
        } 

        private void label_Click(object sender, EventArgs e)
        {
            
        }

        private void save_exception_Click(object sender, EventArgs e)
        {
            String Name = remove_exception_combo.SelectedValue.ToString().Trim();

            if (Name == null || Name.Length < 1) return;

            Exclude.getInstance().removeName(Name);
            this.Close();
        }

    }
}
