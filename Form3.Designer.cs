namespace ThisNonsenseMustStop
{
    partial class Form3
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
            this.label = new System.Windows.Forms.Label();
            this.save_exception = new System.Windows.Forms.Button();
            this.add_exception_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(273, 75);
            this.label.TabIndex = 0;
            this.label.Text = "When you add an app as an exception, it will not\r\nbe closed automatically.\r\n\r\nTo " +
    "continue, select the app you wish to add as an\r\n exception and click submit.";
            // 
            // save_exception
            // 
            this.save_exception.Location = new System.Drawing.Point(85, 138);
            this.save_exception.Name = "save_exception";
            this.save_exception.Size = new System.Drawing.Size(121, 23);
            this.save_exception.TabIndex = 1;
            this.save_exception.Text = "Submit";
            this.save_exception.UseVisualStyleBackColor = true;
            this.save_exception.Click += new System.EventHandler(this.save_exception_Click);
            // 
            // add_exception_combo
            // 
            this.add_exception_combo.FormattingEnabled = true;
            this.add_exception_combo.Location = new System.Drawing.Point(85, 111);
            this.add_exception_combo.Name = "add_exception_combo";
            this.add_exception_combo.Size = new System.Drawing.Size(121, 21);
            this.add_exception_combo.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(293, 186);
            this.Controls.Add(this.add_exception_combo);
            this.Controls.Add(this.save_exception);
            this.Controls.Add(this.label);
            this.Name = "Form3";
            this.Text = "Add Exception";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button save_exception;
        private System.Windows.Forms.ComboBox add_exception_combo;
    }
}