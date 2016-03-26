namespace ThisNonsenseMustStop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportBox = new System.Windows.Forms.RichTextBox();
            this.add_exception = new System.Windows.Forms.Button();
            this.remove_exception = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.control_switch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.control_switch)).BeginInit();
            this.SuspendLayout();
            // 
            // stat
            // 
            this.stat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stat.AutoSize = true;
            this.stat.Font = new System.Drawing.Font("Courier New", 10F);
            this.stat.Location = new System.Drawing.Point(35, 95);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(168, 17);
            this.stat.TabIndex = 0;
            this.stat.Text = "Background Data Apps";
            this.stat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "larisoft Nig. (larypetero@gmail.com)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reportBox
            // 
            this.reportBox.Location = new System.Drawing.Point(12, 115);
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(208, 114);
            this.reportBox.TabIndex = 6;
            this.reportBox.Text = "";
            // 
            // add_exception
            // 
            this.add_exception.Location = new System.Drawing.Point(239, 132);
            this.add_exception.Name = "add_exception";
            this.add_exception.Size = new System.Drawing.Size(101, 23);
            this.add_exception.TabIndex = 7;
            this.add_exception.Text = "Add Exception";
            this.add_exception.UseVisualStyleBackColor = true;
            this.add_exception.Click += new System.EventHandler(this.add_exception_Click);
            // 
            // remove_exception
            // 
            this.remove_exception.Location = new System.Drawing.Point(239, 161);
            this.remove_exception.Name = "remove_exception";
            this.remove_exception.Size = new System.Drawing.Size(101, 23);
            this.remove_exception.TabIndex = 8;
            this.remove_exception.Text = "Rem Exception";
            this.remove_exception.UseVisualStyleBackColor = true;
            this.remove_exception.Click += new System.EventHandler(this.remove_exception_Click);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(239, 190);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(101, 23);
            this.about.TabIndex = 9;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(226, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 114);
            this.panel1.TabIndex = 10;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // control_switch
            // 
            this.control_switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.control_switch.Image = global::ThisNonsenseMustStop.Properties.Resources.on_switch;
            this.control_switch.Location = new System.Drawing.Point(80, 24);
            this.control_switch.Name = "control_switch";
            this.control_switch.Size = new System.Drawing.Size(194, 48);
            this.control_switch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.control_switch.TabIndex = 1;
            this.control_switch.TabStop = false;
            this.control_switch.Click += new System.EventHandler(this.control_switch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(355, 261);
            this.Controls.Add(this.about);
            this.Controls.Add(this.remove_exception);
            this.Controls.Add(this.add_exception);
            this.Controls.Add(this.reportBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.control_switch);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "This Nonsense Must Stop";
            ((System.ComponentModel.ISupportInitialize)(this.control_switch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stat;
        private System.Windows.Forms.PictureBox control_switch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox reportBox;
        private System.Windows.Forms.Button add_exception;
        private System.Windows.Forms.Button remove_exception;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

