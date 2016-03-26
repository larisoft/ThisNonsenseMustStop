using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThisNonsenseMustStop
{
    public partial class Form3 : Form
    {
        private static Form3 instance;
        private Form3()
        {
            InitializeComponent();
            this.Text = "Add Exception";
            var dataSource = Settings.getInstance().getAppNames(); 
            add_exception_combo.DataSource = dataSource;
        }


        public static Form3 getInstance()
        {
            if (instance == null || instance.IsDisposed) instance = new Form3();

            return instance;
        }


        
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void save_exception_Click(object sender, EventArgs e)
        {
            String Name = add_exception_combo.SelectedValue.ToString().Trim();

            if (Name == null || Name.Length < 1) return;

            Exclude.getInstance().addName(Name);
            this.Close();
        }
    }
}
