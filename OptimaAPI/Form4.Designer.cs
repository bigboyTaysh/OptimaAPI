namespace OptimaAPI
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stawkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTowarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kontrahenciComboBox = new System.Windows.Forms.ComboBox();
            this.kontrahenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDN_SEDDataSet4 = new OptimaAPI.CDN_SEDDataSet4();
            this.kontrahenciTableAdapter = new OptimaAPI.CDN_SEDDataSet4TableAdapters.KontrahenciTableAdapter();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.platnosciComboBox = new System.Windows.Forms.ComboBox();
            this.formyPlatnosciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDN_SEDDataSet5 = new OptimaAPI.CDN_SEDDataSet5();
            this.formyPlatnosciTableAdapter = new OptimaAPI.CDN_SEDDataSet5TableAdapters.FormyPlatnosciTableAdapter();
            this.kontrahentLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTowarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDN_SEDDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formyPlatnosciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDN_SEDDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.stawkaDataGridViewTextBoxColumn,
            this.Ilosc,
            this.cenyDataGridViewTextBoxColumn,
            this.jMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iTowarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 219);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // stawkaDataGridViewTextBoxColumn
            // 
            this.stawkaDataGridViewTextBoxColumn.DataPropertyName = "Stawka";
            this.stawkaDataGridViewTextBoxColumn.HeaderText = "Stawka";
            this.stawkaDataGridViewTextBoxColumn.Name = "stawkaDataGridViewTextBoxColumn";
            // 
            // Ilosc
            // 
            this.Ilosc.HeaderText = "Ilosc";
            this.Ilosc.Name = "Ilosc";
            // 
            // cenyDataGridViewTextBoxColumn
            // 
            this.cenyDataGridViewTextBoxColumn.DataPropertyName = "Ceny";
            this.cenyDataGridViewTextBoxColumn.HeaderText = "Wartość";
            this.cenyDataGridViewTextBoxColumn.Name = "cenyDataGridViewTextBoxColumn";
            this.cenyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jMDataGridViewTextBoxColumn
            // 
            this.jMDataGridViewTextBoxColumn.DataPropertyName = "JM";
            this.jMDataGridViewTextBoxColumn.HeaderText = "Jednostka";
            this.jMDataGridViewTextBoxColumn.Name = "jMDataGridViewTextBoxColumn";
            // 
            // iTowarBindingSource
            // 
            this.iTowarBindingSource.DataSource = typeof(CDNTwrb1.ITowar);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Window;
            this.addButton.Location = new System.Drawing.Point(274, 442);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(115, 37);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(593, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 52);
            this.button3.TabIndex = 25;
            this.button3.Text = "+";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kontrahenciComboBox
            // 
            this.kontrahenciComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.kontrahenciComboBox.DataSource = this.kontrahenciBindingSource;
            this.kontrahenciComboBox.DisplayMember = "Knt_Nazwa1";
            this.kontrahenciComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kontrahenciComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontrahenciComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.kontrahenciComboBox.FormattingEnabled = true;
            this.kontrahenciComboBox.Location = new System.Drawing.Point(242, 355);
            this.kontrahenciComboBox.Name = "kontrahenciComboBox";
            this.kontrahenciComboBox.Size = new System.Drawing.Size(178, 24);
            this.kontrahenciComboBox.TabIndex = 37;
            // 
            // kontrahenciBindingSource
            // 
            this.kontrahenciBindingSource.DataMember = "Kontrahenci";
            this.kontrahenciBindingSource.DataSource = this.cDN_SEDDataSet4;
            // 
            // cDN_SEDDataSet4
            // 
            this.cDN_SEDDataSet4.DataSetName = "CDN_SEDDataSet4";
            this.cDN_SEDDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontrahenciTableAdapter
            // 
            this.kontrahenciTableAdapter.ClearBeforeFill = true;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.exitButton.Location = new System.Drawing.Point(606, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(45, 36);
            this.exitButton.TabIndex = 38;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(270, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Suma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(325, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 40;
            // 
            // platnosciComboBox
            // 
            this.platnosciComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.platnosciComboBox.DataSource = this.formyPlatnosciBindingSource;
            this.platnosciComboBox.DisplayMember = "FPl_Nazwa";
            this.platnosciComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.platnosciComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.platnosciComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.platnosciComboBox.FormattingEnabled = true;
            this.platnosciComboBox.Location = new System.Drawing.Point(242, 401);
            this.platnosciComboBox.Name = "platnosciComboBox";
            this.platnosciComboBox.Size = new System.Drawing.Size(178, 24);
            this.platnosciComboBox.TabIndex = 41;
            // 
            // formyPlatnosciBindingSource
            // 
            this.formyPlatnosciBindingSource.DataMember = "FormyPlatnosci";
            this.formyPlatnosciBindingSource.DataSource = this.cDN_SEDDataSet5;
            // 
            // cDN_SEDDataSet5
            // 
            this.cDN_SEDDataSet5.DataSetName = "CDN_SEDDataSet5";
            this.cDN_SEDDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formyPlatnosciTableAdapter
            // 
            this.formyPlatnosciTableAdapter.ClearBeforeFill = true;
            // 
            // kontrahentLabel
            // 
            this.kontrahentLabel.AutoSize = true;
            this.kontrahentLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrahenciBindingSource, "Knt_Kod", true));
            this.kontrahentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontrahentLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.kontrahentLabel.Location = new System.Drawing.Point(325, 323);
            this.kontrahentLabel.Name = "kontrahentLabel";
            this.kontrahentLabel.Size = new System.Drawing.Size(0, 20);
            this.kontrahentLabel.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(284, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Kod:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(663, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kontrahentLabel);
            this.Controls.Add(this.platnosciComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.kontrahenciComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form4_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTowarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDN_SEDDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formyPlatnosciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDN_SEDDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource iTowarBindingSource;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox kontrahenciComboBox;
        private CDN_SEDDataSet4 cDN_SEDDataSet4;
        private System.Windows.Forms.BindingSource kontrahenciBindingSource;
        private CDN_SEDDataSet4TableAdapters.KontrahenciTableAdapter kontrahenciTableAdapter;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stawkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jMDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox platnosciComboBox;
        private CDN_SEDDataSet5 cDN_SEDDataSet5;
        private System.Windows.Forms.BindingSource formyPlatnosciBindingSource;
        private CDN_SEDDataSet5TableAdapters.FormyPlatnosciTableAdapter formyPlatnosciTableAdapter;
        private System.Windows.Forms.Label kontrahentLabel;
        private System.Windows.Forms.Label label4;
    }
}