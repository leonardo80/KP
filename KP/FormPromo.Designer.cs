namespace KP
{
    partial class FormPromo
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
            this.tbNamaPromo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEnd = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKemasan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPoin = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbBarang = new System.Windows.Forms.ComboBox();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.tbKodeBarang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbIDPromo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.tbPeriodePromo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeletedPromo = new System.Windows.Forms.Button();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNamaPromo
            // 
            this.tbNamaPromo.Enabled = false;
            this.tbNamaPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaPromo.Location = new System.Drawing.Point(145, 21);
            this.tbNamaPromo.Name = "tbNamaPromo";
            this.tbNamaPromo.Size = new System.Drawing.Size(152, 28);
            this.tbNamaPromo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nama Promo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbYear);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbEnd);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbStart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbKemasan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNamaPromo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPoin);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cbBarang);
            this.groupBox1.Controls.Add(this.tbJumlah);
            this.groupBox1.Controls.Add(this.tbKodeBarang);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 558);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promo";
            // 
            // cbEnd
            // 
            this.cbEnd.Enabled = false;
            this.cbEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnd.FormattingEnabled = true;
            this.cbEnd.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbEnd.Location = new System.Drawing.Point(501, 18);
            this.cbEnd.Name = "cbEnd";
            this.cbEnd.Size = new System.Drawing.Size(64, 33);
            this.cbEnd.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(440, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 25);
            this.label10.TabIndex = 55;
            this.label10.Text = "End";
            // 
            // cbStart
            // 
            this.cbStart.Enabled = false;
            this.cbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbStart.Location = new System.Drawing.Point(363, 18);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(64, 33);
            this.cbStart.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "Kemasan";
            // 
            // tbKemasan
            // 
            this.tbKemasan.Enabled = false;
            this.tbKemasan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKemasan.Location = new System.Drawing.Point(549, 97);
            this.tbKemasan.Name = "tbKemasan";
            this.tbKemasan.Size = new System.Drawing.Size(101, 28);
            this.tbKemasan.TabIndex = 15;
            this.tbKemasan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(650, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Poin";
            // 
            // tbPoin
            // 
            this.tbPoin.Enabled = false;
            this.tbPoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPoin.Location = new System.Drawing.Point(653, 96);
            this.tbPoin.Name = "tbPoin";
            this.tbPoin.Size = new System.Drawing.Size(80, 28);
            this.tbPoin.TabIndex = 16;
            this.tbPoin.Text = "0";
            this.tbPoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPoin.Enter += new System.EventHandler(this.tbKodeBarang_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(555, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 65);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(648, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 65);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(437, 130);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 28);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 25);
            this.label13.TabIndex = 39;
            this.label13.Text = "Kode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Jumlah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(140, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nama";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(589, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 28);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbBarang
            // 
            this.cbBarang.AutoCompleteCustomSource.AddRange(new string[] {
            "Nama Barang 1",
            "Nama Barang 2",
            "Nama barang 3"});
            this.cbBarang.Enabled = false;
            this.cbBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBarang.FormattingEnabled = true;
            this.cbBarang.Location = new System.Drawing.Point(129, 96);
            this.cbBarang.Name = "cbBarang";
            this.cbBarang.Size = new System.Drawing.Size(313, 28);
            this.cbBarang.TabIndex = 13;
            this.cbBarang.TextChanged += new System.EventHandler(this.cbBarang_TextChanged);
            this.cbBarang.Enter += new System.EventHandler(this.cbBarang_Enter);
            // 
            // tbJumlah
            // 
            this.tbJumlah.Enabled = false;
            this.tbJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJumlah.Location = new System.Drawing.Point(449, 96);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(92, 28);
            this.tbJumlah.TabIndex = 14;
            this.tbJumlah.Text = "0";
            this.tbJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbJumlah.Enter += new System.EventHandler(this.tbKodeBarang_Enter);
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbKodeBarang.Enabled = false;
            this.tbKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKodeBarang.Location = new System.Drawing.Point(6, 96);
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.Size = new System.Drawing.Size(117, 28);
            this.tbKodeBarang.TabIndex = 12;
            this.tbKodeBarang.TextChanged += new System.EventHandler(this.tbKodeBarang_TextChanged);
            this.tbKodeBarang.Enter += new System.EventHandler(this.tbKodeBarang_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnPrev);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Location = new System.Drawing.Point(123, 471);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 77);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(49, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 56);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(6, 12);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(37, 56);
            this.btnPrev.TabIndex = 21;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(435, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 56);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(110, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(64, 56);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(370, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(64, 56);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(175, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 56);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(240, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 56);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(305, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(64, 56);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 230);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tbIDPromo
            // 
            this.tbIDPromo.Enabled = false;
            this.tbIDPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDPromo.Location = new System.Drawing.Point(52, 14);
            this.tbIDPromo.MaxLength = 4;
            this.tbIDPromo.Name = "tbIDPromo";
            this.tbIDPromo.Size = new System.Drawing.Size(42, 28);
            this.tbIDPromo.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Nama Promo";
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(245, 12);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(224, 33);
            this.cbSearch.TabIndex = 54;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            this.cbSearch.TextChanged += new System.EventHandler(this.cbSearch_TextChanged);
            // 
            // tbPeriodePromo
            // 
            this.tbPeriodePromo.Enabled = false;
            this.tbPeriodePromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPeriodePromo.Location = new System.Drawing.Point(245, 60);
            this.tbPeriodePromo.Name = "tbPeriodePromo";
            this.tbPeriodePromo.Size = new System.Drawing.Size(224, 28);
            this.tbPeriodePromo.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "Periode";
            // 
            // btnDeletedPromo
            // 
            this.btnDeletedPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletedPromo.Location = new System.Drawing.Point(600, 12);
            this.btnDeletedPromo.Name = "btnDeletedPromo";
            this.btnDeletedPromo.Size = new System.Drawing.Size(153, 47);
            this.btnDeletedPromo.TabIndex = 56;
            this.btnDeletedPromo.Text = "Deleted List";
            this.btnDeletedPromo.UseVisualStyleBackColor = true;
            this.btnDeletedPromo.Click += new System.EventHandler(this.btnDeletedPromo_Click);
            // 
            // cbYear
            // 
            this.cbYear.Enabled = false;
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021"});
            this.cbYear.Location = new System.Drawing.Point(634, 18);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(99, 33);
            this.cbYear.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(575, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 25);
            this.label11.TabIndex = 57;
            this.label11.Text = "Year";
            // 
            // FormPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 658);
            this.Controls.Add(this.btnDeletedPromo);
            this.Controls.Add(this.tbPeriodePromo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbIDPromo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPromo";
            this.Text = "FormPromo";
            this.Load += new System.EventHandler(this.FormPromo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNamaPromo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbBarang;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.TextBox tbKodeBarang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKemasan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPoin;
        private System.Windows.Forms.TextBox tbIDPromo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPeriodePromo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEnd;
        private System.Windows.Forms.Button btnDeletedPromo;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label11;
    }
}