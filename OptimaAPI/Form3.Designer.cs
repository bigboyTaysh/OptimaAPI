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
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDN_SEDDataSet3 = new OptimaAPI.CDN_SEDDataSet3();
            this.zamowieniaTableAdapter = new OptimaAPI.CDN_SEDDataSet3TableAdapters.ZamowieniaTableAdapter();
            this.trETrNIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trETwrIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trETwrNazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trETwrKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trEWartoscNettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trEWartoscBruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trEIloscJMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView1.Location = new System.Drawing.Point(26, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 150);
            this.dataGridView1.TabIndex = 0;
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
            // trEWartoscBruttoDataGridViewTextBoxColumn
            // 
            this.trEIloscJMDataGridViewTextBoxColumn.DataPropertyName = "TrE_IloscJM";
            this.trEIloscJMDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.trEIloscJMDataGridViewTextBoxColumn.Name = "trEIloscJMDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
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
    }
}