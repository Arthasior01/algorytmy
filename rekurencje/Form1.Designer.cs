namespace rekurencje
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
            this.btn_ms = new System.Windows.Forms.Button();
            this.btn_cf = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ms
            // 
            this.btn_ms.Location = new System.Drawing.Point(294, 26);
            this.btn_ms.Name = "btn_ms";
            this.btn_ms.Size = new System.Drawing.Size(176, 84);
            this.btn_ms.TabIndex = 0;
            this.btn_ms.Text = "SortowanieM";
            this.btn_ms.UseVisualStyleBackColor = true;
            this.btn_ms.Click += new System.EventHandler(this.btn_ms_Click);
            // 
            // btn_cf
            // 
            this.btn_cf.Location = new System.Drawing.Point(294, 145);
            this.btn_cf.Name = "btn_cf";
            this.btn_cf.Size = new System.Drawing.Size(176, 83);
            this.btn_cf.TabIndex = 1;
            this.btn_cf.Text = "Fibonacci";
            this.btn_cf.UseVisualStyleBackColor = true;
            this.btn_cf.Click += new System.EventHandler(this.btn_cf_Click);
            // 
            // btn_ce
            // 
            this.btn_ce.Location = new System.Drawing.Point(294, 260);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(176, 82);
            this.btn_ce.TabIndex = 2;
            this.btn_ce.Text = "Euklides";
            this.btn_ce.UseVisualStyleBackColor = true;
            this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.btn_cf);
            this.Controls.Add(this.btn_ms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ms;
        private System.Windows.Forms.Button btn_cf;
        private System.Windows.Forms.Button btn_ce;
    }
}

