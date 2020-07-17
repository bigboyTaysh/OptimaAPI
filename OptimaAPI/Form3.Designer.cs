namespace OptimaAPI
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trETrNIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trETwrIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trETwrNazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trETwrKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trEIloscJMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trEWartoscNettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trEWartoscBruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDN_SEDDataSet3 = new OptimaAPI.CDN_SEDDataSet3();
            this.zamowieniaTableAdapter = new OptimaAPI.CDN_SEDDataSet3TableAdapters.ZamowieniaTableAdapter();
            this.exitButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDN_SEDDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trETrNIdDataGridViewTextBoxColumn,
            this.trETwrIdDataGridViewTextBoxColumn,
            this.trETwrNazwaDataGridViewTextBoxColumn,
            this.trETwrKodDataGridViewTextBoxColumn,
            this.trEIloscJMDataGridViewTextBoxColumn,
            this.trEWartoscNettoDataGridViewTextBoxColumn,
            this.trEWartoscBruttoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zamowieniaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // trETrNIdDataGridViewTextBoxColumn
            // 
            this.trETrNIdDataGridViewTextBoxColumn.DataPropertyName = "TrE_TrNId";
            this.trETrNIdDataGridViewTextBoxColumn.HeaderText = "ID zamówienia";
            this.trETrNIdDataGridViewTextBoxColumn.Name = "trETrNIdDataGridViewTextBoxColumn";
            // 
            // trETwrIdDataGridViewTextBoxColumn
            // 
            this.trETwrIdDataGridViewTextBoxColumn.DataPropertyName = "TrE_TwrId";
            this.trETwrIdDataGridViewTextBoxColumn.HeaderText = "ID towaru";
            this.trETwrIdDataGridViewTextBoxColumn.Name = "trETwrIdDataGridViewTextBoxColumn";
            // 
            // trETwrNazwaDataGridViewTextBoxColumn
            // 
            this.trETwrNazwaDataGridViewTextBoxColumn.DataPropertyName = "TrE_TwrNazwa";
            this.trETwrNazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa towaru";
            this.trETwrNazwaDataGridViewTextBoxColumn.Name = "trETwrNazwaDataGridViewTextBoxColumn";
            // 
            // trETwrKodDataGridViewTextBoxColumn
            // 
            this.trETwrKodDataGridViewTextBoxColumn.DataPropertyName = "TrE_TwrKod";
            this.trETwrKodDataGridViewTextBoxColumn.HeaderText = "Kod towaru";
            this.trETwrKodDataGridViewTextBoxColumn.Name = "trETwrKodDataGridViewTextBoxColumn";
            // 
            // trEIloscJMDataGridViewTextBoxColumn
            // 
            this.trEIloscJMDataGridViewTextBoxColumn.DataPropertyName = "TrE_IloscJM";
            this.trEIloscJMDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.trEIloscJMDataGridViewTextBoxColumn.Name = "trEIloscJMDataGridViewTextBoxColumn";
            // 
            // trEWartoscNettoDataGridViewTextBoxColumn
            // 
            this.trEWartoscNettoDataGridViewTextBoxColumn.DataPropertyName = "TrE_WartoscNetto";
            this.trEWartoscNettoDataGridViewTextBoxColumn.HeaderText = "Wartość netto";
            this.trEWartoscNettoDataGridViewTextBoxColumn.Name = "trEWartoscNettoDataGridViewTextBoxColumn";
            // 
            // trEWartoscBruttoDataGridViewTextBoxColumn
            // 
            this.trEWartoscBruttoDataGridViewTextBoxColumn.DataPropertyName = "TrE_WartoscBrutto";
            this.trEWartoscBruttoDataGridViewTextBoxColumn.HeaderText = "Wartość brutto";
            this.trEWartoscBruttoDataGridViewTextBoxColumn.Name = "trEWartoscBruttoDataGridViewTextBoxColumn";
            // 
            // zamowieniaBindingSource
            // 
            this.zamowieniaBindingSource.DataMember = "Zamowienia";
            this.zamowieniaBindingSource.DataSource = this.cDN_SEDDataSet3;
            // 
            // cDN_SEDDataSet3
            // 
            this.cDN_SEDDataSet3.DataSetName = "CDN_SEDDataSet3";
            this.cDN_SEDDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamowieniaTableAdapter
            // 
            this.zamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.exitButton.Location = new System.Drawing.Point(714, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(45, 36);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okButton.ForeColor = System.Drawing.SystemColors.Window;
            this.okButton.Location = new System.Drawing.Point(328, 416);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(115, 37);
            this.okButton.TabIndex = 27;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(771, 474);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDN_SEDDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private CDN_SEDDataSet3 cDN_SEDDataSet3;
        private CDN_SEDDataSet3TableAdapters.ZamowieniaTableAdapter zamowieniaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trETrNIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trETwrIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trETwrNazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trETwrKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trEWartoscNettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trEWartoscBruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trEIloscJMDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button okButton;
    }
}