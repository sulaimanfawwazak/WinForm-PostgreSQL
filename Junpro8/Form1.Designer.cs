namespace Junpro8
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNo_handphone = new System.Windows.Forms.TextBox();
            this.blb_Nama = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblNo_handphone = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._no_handphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoaddata = new System.Windows.Forms.Button();
            this.btnGenerateQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(156, 89);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(100, 20);
            this.txtAlamat.TabIndex = 1;
            // 
            // txtNo_handphone
            // 
            this.txtNo_handphone.Location = new System.Drawing.Point(156, 128);
            this.txtNo_handphone.Name = "txtNo_handphone";
            this.txtNo_handphone.Size = new System.Drawing.Size(100, 20);
            this.txtNo_handphone.TabIndex = 2;
            this.txtNo_handphone.TextChanged += new System.EventHandler(this.txtNo_handphone_TextChanged);
            // 
            // blb_Nama
            // 
            this.blb_Nama.AutoSize = true;
            this.blb_Nama.Location = new System.Drawing.Point(64, 51);
            this.blb_Nama.Name = "blb_Nama";
            this.blb_Nama.Size = new System.Drawing.Size(35, 13);
            this.blb_Nama.TabIndex = 3;
            this.blb_Nama.Text = "Nama";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(64, 92);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(39, 13);
            this.lblAlamat.TabIndex = 4;
            this.lblAlamat.Text = "Alamat";
            // 
            // lblNo_handphone
            // 
            this.lblNo_handphone.AutoSize = true;
            this.lblNo_handphone.Location = new System.Drawing.Point(64, 135);
            this.lblNo_handphone.Name = "lblNo_handphone";
            this.lblNo_handphone.Size = new System.Drawing.Size(80, 13);
            this.lblNo_handphone.TabIndex = 5;
            this.lblNo_handphone.Text = "No Handphone";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(293, 44);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(91, 74);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(390, 46);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 72);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(498, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 74);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this._name,
            this._alamat,
            this._no_handphone});
            this.dgvData.Location = new System.Drawing.Point(67, 179);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(636, 204);
            this.dgvData.TabIndex = 9;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // _id
            // 
            this._id.HeaderText = "_id";
            this._id.Name = "_id";
            // 
            // _name
            // 
            this._name.HeaderText = "_name";
            this._name.Name = "_name";
            // 
            // _alamat
            // 
            this._alamat.HeaderText = "_alamat";
            this._alamat.Name = "_alamat";
            // 
            // _no_handphone
            // 
            this._no_handphone.HeaderText = "_no_handphone";
            this._no_handphone.Name = "_no_handphone";
            // 
            // btnLoaddata
            // 
            this.btnLoaddata.Location = new System.Drawing.Point(520, 401);
            this.btnLoaddata.Name = "btnLoaddata";
            this.btnLoaddata.Size = new System.Drawing.Size(75, 23);
            this.btnLoaddata.TabIndex = 10;
            this.btnLoaddata.Text = "Load Data";
            this.btnLoaddata.UseVisualStyleBackColor = true;
            this.btnLoaddata.Click += new System.EventHandler(this.btnLoaddata_Click);
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.Location = new System.Drawing.Point(610, 46);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(93, 63);
            this.btnGenerateQR.TabIndex = 11;
            this.btnGenerateQR.Text = "Generate QR";
            this.btnGenerateQR.UseVisualStyleBackColor = true;
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateQR);
            this.Controls.Add(this.btnLoaddata);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblNo_handphone);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.blb_Nama);
            this.Controls.Add(this.txtNo_handphone);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label blb_Nama;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblNo_handphone;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn _no_handphone;
        private System.Windows.Forms.Button btnLoaddata;
        private System.Windows.Forms.Button btnGenerateQR;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtAlamat;
        public System.Windows.Forms.TextBox txtNo_handphone;
    }
}

