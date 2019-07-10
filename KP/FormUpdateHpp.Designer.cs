namespace KP
{
    partial class FormUpdateHpp
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
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHpp = new System.Windows.Forms.TextBox();
            this.tbKodeBarang = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cbBarang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 25);
            this.label13.TabIndex = 45;
            this.label13.Text = "Kode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(406, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "HPP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "Nama";
            // 
            // tbHpp
            // 
            this.tbHpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHpp.Location = new System.Drawing.Point(395, 43);
            this.tbHpp.Name = "tbHpp";
            this.tbHpp.Size = new System.Drawing.Size(86, 28);
            this.tbHpp.TabIndex = 3;
            this.tbHpp.Text = "0";
            this.tbHpp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbHpp.TextChanged += new System.EventHandler(this.tbHpp_TextChanged);
            this.tbHpp.Enter += new System.EventHandler(this.tbJumlah_Enter);
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKodeBarang.Location = new System.Drawing.Point(9, 43);
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.Size = new System.Drawing.Size(86, 28);
            this.tbKodeBarang.TabIndex = 1;
            this.tbKodeBarang.TextChanged += new System.EventHandler(this.tbKodeBarang_TextChanged);
            this.tbKodeBarang.Enter += new System.EventHandler(this.tbJumlah_Enter);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(501, 29);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(146, 50);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Update";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cbBarang
            // 
            this.cbBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBarang.FormattingEnabled = true;
            this.cbBarang.Location = new System.Drawing.Point(101, 42);
            this.cbBarang.Name = "cbBarang";
            this.cbBarang.Size = new System.Drawing.Size(288, 33);
            this.cbBarang.TabIndex = 2;
            this.cbBarang.TextChanged += new System.EventHandler(this.cbBarang_TextChanged);
            // 
            // FormUpdateHpp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 102);
            this.Controls.Add(this.cbBarang);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbHpp);
            this.Controls.Add(this.tbKodeBarang);
            this.Name = "FormUpdateHpp";
            this.Text = "FormUpdateHpp";
            this.Load += new System.EventHandler(this.FormUpdateHpp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbHpp;
        private System.Windows.Forms.TextBox tbKodeBarang;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cbBarang;
    }
}