namespace sortowanie
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
            this.btn_sb = new System.Windows.Forms.Button();
            this.btn_si = new System.Windows.Forms.Button();
            this.btn_ss = new System.Windows.Forms.Button();
            this.btn_cs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sb
            // 
            this.btn_sb.Location = new System.Drawing.Point(192, 34);
            this.btn_sb.Name = "btn_sb";
            this.btn_sb.Size = new System.Drawing.Size(142, 56);
            this.btn_sb.TabIndex = 0;
            this.btn_sb.Text = "Sortowanie_B";
            this.btn_sb.UseVisualStyleBackColor = true;
            this.btn_sb.Click += new System.EventHandler(this.btn_sb_Click);
            // 
            // btn_si
            // 
            this.btn_si.Location = new System.Drawing.Point(437, 34);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(142, 55);
            this.btn_si.TabIndex = 1;
            this.btn_si.Text = "Sortowanie_I";
            this.btn_si.UseVisualStyleBackColor = true;
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click);
            // 
            // btn_ss
            // 
            this.btn_ss.Location = new System.Drawing.Point(192, 147);
            this.btn_ss.Name = "btn_ss";
            this.btn_ss.Size = new System.Drawing.Size(142, 55);
            this.btn_ss.TabIndex = 2;
            this.btn_ss.Text = "Sortowanie_S";
            this.btn_ss.UseVisualStyleBackColor = true;
            this.btn_ss.Click += new System.EventHandler(this.btn_ss_Click);
            // 
            // btn_cs
            // 
            this.btn_cs.Location = new System.Drawing.Point(437, 147);
            this.btn_cs.Name = "btn_cs";
            this.btn_cs.Size = new System.Drawing.Size(142, 54);
            this.btn_cs.TabIndex = 3;
            this.btn_cs.Text = "Sortowanie_C";
            this.btn_cs.UseVisualStyleBackColor = true;
            this.btn_cs.Click += new System.EventHandler(this.btn_cs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cs);
            this.Controls.Add(this.btn_ss);
            this.Controls.Add(this.btn_si);
            this.Controls.Add(this.btn_sb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sb;
        private System.Windows.Forms.Button btn_si;
        private System.Windows.Forms.Button btn_ss;
        private System.Windows.Forms.Button btn_cs;
    }
}

