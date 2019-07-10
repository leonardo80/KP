namespace KP
{
    partial class ReportViewer
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
            this.crvTransaksi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvTransaksi
            // 
            this.crvTransaksi.ActiveViewIndex = -1;
            this.crvTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvTransaksi.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvTransaksi.Location = new System.Drawing.Point(0, 0);
            this.crvTransaksi.Name = "crvTransaksi";
            this.crvTransaksi.Size = new System.Drawing.Size(800, 575);
            this.crvTransaksi.TabIndex = 0;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.crvTransaksi);
            this.Name = "ReportViewer";
            this.Text = "ReportViewer";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvTransaksi;
    }
}