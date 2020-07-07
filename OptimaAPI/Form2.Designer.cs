namespace OptimaAPI
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cDN_SEDDataSet = new OptimaAPI.CDN_SEDDataSet();
            this.kontrahenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontrahenciTableAdapter = new OptimaAPI.CDN_SEDDataSetTableAdapters.KontrahenciTableAdapter();
            this.kntKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntNazwa1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntUlicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntNrDomuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntMiastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntKodPocztowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntTelefon1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDN_SEDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(844, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "wyloguj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Location = new System.Drawing.Point(983, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(180, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(848, 392);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.button4);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Controls.Add(this.button6);
            this.flowLayoutPanel2.Controls.Add(this.button7);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 46);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(161, 392);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 65);
            this.button3.TabIndex = 0;
            this.button3.Text = "Kontrachenci";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(3, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 65);
            this.button4.TabIndex = 1;
            this.button4.Text = "text1";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(3, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 65);
            this.button5.TabIndex = 2;
            this.button5.Text = "text1";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(3, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 65);
            this.button6.TabIndex = 3;
            this.button6.Text = "text1";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(3, 287);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 65);
            this.button7.TabIndex = 4;
            this.button7.Text = "text1";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kntKodDataGridViewTextBoxColumn,
            this.kntNazwa1DataGridViewTextBoxColumn,
            this.kntUlicaDataGridViewTextBoxColumn,
            this.kntNrDomuDataGridViewTextBoxColumn,
            this.kntMiastoDataGridViewTextBoxColumn,
            this.kntKodPocztowyDataGridViewTextBoxColumn,
            this.kntTelefon1DataGridViewTextBoxColumn,
            this.kntEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kontrahenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 136);
            this.dataGridView1.TabIndex = 0;
            // 
            // cDN_SEDDataSet
            // 
            this.cDN_SEDDataSet.DataSetName = "CDN_SEDDataSet";
            this.cDN_SEDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontrahenciBindingSource
            // 
            this.kontrahenciBindingSource.DataMember = "Kontrahenci";
            this.kontrahenciBindingSource.DataSource = this.cDN_SEDDataSet;
            // 
            // kontrahenciTableAdapter
            // 
            this.kontrahenciTableAdapter.ClearBeforeFill = true;
            // 
            // kntKodDataGridViewTextBoxColumn
            // 
            this.kntKodDataGridViewTextBoxColumn.DataPropertyName = "Knt_Kod";
            this.kntKodDataGridViewTextBoxColumn.HeaderText = "Knt_Kod";
            this.kntKodDataGridViewTextBoxColumn.Name = "kntKodDataGridViewTextBoxColumn";
            // 
            // kntNazwa1DataGridViewTextBoxColumn
            // 
            this.kntNazwa1DataGridViewTextBoxColumn.DataPropertyName = "Knt_Nazwa1";
            this.kntNazwa1DataGridViewTextBoxColumn.HeaderText = "Knt_Nazwa1";
            this.kntNazwa1DataGridViewTextBoxColumn.Name = "kntNazwa1DataGridViewTextBoxColumn";
            // 
            // kntUlicaDataGridViewTextBoxColumn
            // 
            this.kntUlicaDataGridViewTextBoxColumn.DataPropertyName = "Knt_Ulica";
            this.kntUlicaDataGridViewTextBoxColumn.HeaderText = "Knt_Ulica";
            this.kntUlicaDataGridViewTextBoxColumn.Name = "kntUlicaDataGridViewTextBoxColumn";
            // 
            // kntNrDomuDataGridViewTextBoxColumn
            // 
            this.kntNrDomuDataGridViewTextBoxColumn.DataPropertyName = "Knt_NrDomu";
            this.kntNrDomuDataGridViewTextBoxColumn.HeaderText = "Knt_NrDomu";
            this.kntNrDomuDataGridViewTextBoxColumn.Name = "kntNrDomuDataGridViewTextBoxColumn";
            // 
            // kntMiastoDataGridViewTextBoxColumn
            // 
            this.kntMiastoDataGridViewTextBoxColumn.DataPropertyName = "Knt_Miasto";
            this.kntMiastoDataGridViewTextBoxColumn.HeaderText = "Knt_Miasto";
            this.kntMiastoDataGridViewTextBoxColumn.Name = "kntMiastoDataGridViewTextBoxColumn";
            // 
            // kntKodPocztowyDataGridViewTextBoxColumn
            // 
            this.kntKodPocztowyDataGridViewTextBoxColumn.DataPropertyName = "Knt_KodPocztowy";
            this.kntKodPocztowyDataGridViewTextBoxColumn.HeaderText = "Knt_KodPocztowy";
            this.kntKodPocztowyDataGridViewTextBoxColumn.Name = "kntKodPocztowyDataGridViewTextBoxColumn";
            // 
            // kntTelefon1DataGridViewTextBoxColumn
            // 
            this.kntTelefon1DataGridViewTextBoxColumn.DataPropertyName = "Knt_Telefon1";
            this.kntTelefon1DataGridViewTextBoxColumn.HeaderText = "Knt_Telefon1";
            this.kntTelefon1DataGridViewTextBoxColumn.Name = "kntTelefon1DataGridViewTextBoxColumn";
            // 
            // kntEmailDataGridViewTextBoxColumn
            // 
            this.kntEmailDataGridViewTextBoxColumn.DataPropertyName = "Knt_Email";
            this.kntEmailDataGridViewTextBoxColumn.HeaderText = "Knt_Email";
            this.kntEmailDataGridViewTextBoxColumn.Name = "kntEmailDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1032, 447);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDN_SEDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CDN_SEDDataSet cDN_SEDDataSet;
        private System.Windows.Forms.BindingSource kontrahenciBindingSource;
        private CDN_SEDDataSetTableAdapters.KontrahenciTableAdapter kontrahenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntNazwa1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntUlicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntNrDomuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntMiastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntKodPocztowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntTelefon1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntEmailDataGridViewTextBoxColumn;
    }
}