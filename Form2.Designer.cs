namespace ThisNonsenseMustStop
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.about_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.about_panel = new System.Windows.Forms.Panel();
            this.about_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // about_title
            // 
            this.about_title.AutoSize = true;
            this.about_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_title.Location = new System.Drawing.Point(44, 0);
            this.about_title.Name = "about_title";
            this.about_title.Size = new System.Drawing.Size(238, 20);
            this.about_title.TabIndex = 0;
            this.about_title.Text = "About This Nonsense Must Stop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 144);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // about_panel
            // 
            this.about_panel.Controls.Add(this.label1);
            this.about_panel.Controls.Add(this.about_title);
            this.about_panel.Location = new System.Drawing.Point(12, 12);
            this.about_panel.Name = "about_panel";
            this.about_panel.Size = new System.Drawing.Size(318, 182);
            this.about_panel.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(345, 206);
            this.Controls.Add(this.about_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.about_panel.ResumeLayout(false);
            this.about_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label about_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel about_panel;
    }
}