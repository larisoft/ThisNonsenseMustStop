namespace ThisNonsenseMustStop
{
    partial class Form4
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
            this.remove_exception_combo = new System.Windows.Forms.ComboBox();
            this.save_exception = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // remove_exception_combo
            // 
            this.remove_exception_combo.FormattingEnabled = true;
            this.remove_exception_combo.Location = new System.Drawing.Point(79, 113);
            this.remove_exception_combo.Name = "remove_exception_combo";
            this.remove_exception_combo.Size = new System.Drawing.Size(121, 21);
            this.remove_exception_combo.TabIndex = 5;
            // 
            // save_exception
            // 
            this.save_exception.Location = new System.Drawing.Point(79, 140);
            this.save_exception.Name = "save_exception";
            this.save_exception.Size = new System.Drawing.Size(121, 23);
            this.save_exception.TabIndex = 4;
            this.save_exception.Text = "Submit";
            this.save_exception.UseVisualStyleBackColor = true;
            this.save_exception.Click += new System.EventHandler(this.save_exception_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(260, 90);
            this.label.TabIndex = 3;
            this.label.Text = "When you remove an app as an exception, it \r\nwill be closed automatically once it" +
    " guzzles \r\ndata subtly.\r\n\r\nTo continue, select the app you wish to remove\r\n as a" +
    "n exception and click submit.";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(289, 169);
            this.Controls.Add(this.remove_exception_combo);
            this.Controls.Add(this.save_exception);
            this.Controls.Add(this.label);
            this.Name = "Form4";
            this.Text = "Remove Exception";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox remove_exception_combo;
        private System.Windows.Forms.Button save_exception;
        private System.Windows.Forms.Label label;
    }
}