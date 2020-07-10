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
            this.logoutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel_kontrachent = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filterKontrahenci = new System.Windows.Forms.ComboBox();
            this.delete_kontrachent = new System.Windows.Forms.Button();
            this.update_kontrachent = new System.Windows.Forms.Button();
            this.add_kontrahent = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.phraseKontrahenci = new System.Windows.Forms.TextBox();
            this.kntKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntNazwa1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntUlicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntNrDomuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntMiastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntKodPocztowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntTelefon1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontrahenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDN_SEDDataSet = new OptimaAPI.CDN_SEDDataSet2();
            this.kontrahenciTableAdapter = new OptimaAPI.CDN_SEDDataSet2TableAdapters.KontrahenciTableAdapter();
            this.customerCheckBox = new System.Windows.Forms.CheckBox();
            this.providerCheckBox = new System.Windows.Forms.CheckBox();
            this.CompetitionCheckBox = new System.Windows.Forms.CheckBox();
            this.partnerCheckBox = new System.Windows.Forms.CheckBox();
            this.potentialCheckBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel_kontrachent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDN_SEDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logoutButton.Location = new System.Drawing.Point(833, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(133, 36);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "wyloguj";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.exitButton.Location = new System.Drawing.Point(993, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(45, 36);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            this.exitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.exitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.exitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.button4);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Controls.Add(this.button6);
            this.flowLayoutPanel2.Controls.Add(this.button7);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(14, 56);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(161, 355);
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
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // panel_kontrachent
            // 
            this.panel_kontrachent.Controls.Add(this.potentialCheckBox);
            this.panel_kontrachent.Controls.Add(this.partnerCheckBox);
            this.panel_kontrachent.Controls.Add(this.CompetitionCheckBox);
            this.panel_kontrachent.Controls.Add(this.providerCheckBox);
            this.panel_kontrachent.Controls.Add(this.customerCheckBox);
            this.panel_kontrachent.Controls.Add(this.phraseKontrahenci);
            this.panel_kontrachent.Controls.Add(this.dataGridView1);
            this.panel_kontrachent.Controls.Add(this.filterKontrahenci);
            this.panel_kontrachent.Controls.Add(this.delete_kontrachent);
            this.panel_kontrachent.Controls.Add(this.update_kontrachent);
            this.panel_kontrachent.Controls.Add(this.add_kontrahent);
            this.panel_kontrachent.Controls.Add(this.label8);
            this.panel_kontrachent.Controls.Add(this.label7);
            this.panel_kontrachent.Controls.Add(this.label6);
            this.panel_kontrachent.Controls.Add(this.label5);
            this.panel_kontrachent.Controls.Add(this.label4);
            this.panel_kontrachent.Controls.Add(this.label3);
            this.panel_kontrachent.Controls.Add(this.label2);
            this.panel_kontrachent.Controls.Add(this.label1);
            this.panel_kontrachent.Controls.Add(this.textBox8);
            this.panel_kontrachent.Controls.Add(this.textBox7);
            this.panel_kontrachent.Controls.Add(this.textBox6);
            this.panel_kontrachent.Controls.Add(this.textBox5);
            this.panel_kontrachent.Controls.Add(this.textBox4);
            this.panel_kontrachent.Controls.Add(this.textBox3);
            this.panel_kontrachent.Controls.Add(this.textBox2);
            this.panel_kontrachent.Controls.Add(this.textBox1);
            this.panel_kontrachent.Location = new System.Drawing.Point(181, 56);
            this.panel_kontrachent.Name = "panel_kontrachent";
            this.panel_kontrachent.Size = new System.Drawing.Size(866, 587);
            this.panel_kontrachent.TabIndex = 5;
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 195);
            this.dataGridView1.TabIndex = 20;
            // 
            // filterKontrahenci
            // 
            this.filterKontrahenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterKontrahenci.FormattingEnabled = true;
            this.filterKontrahenci.Items.AddRange(new object[] {
            "-każdy-",
            "odbiorca",
            "dostawca",
            "konkurencja",
            "partner",
            "potencjalny"});
            this.filterKontrahenci.Location = new System.Drawing.Point(491, 216);
            this.filterKontrahenci.Name = "filterKontrahenci";
            this.filterKontrahenci.Size = new System.Drawing.Size(153, 24);
            this.filterKontrahenci.TabIndex = 19;
            // 
            // delete_kontrachent
            // 
            this.delete_kontrachent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_kontrachent.Location = new System.Drawing.Point(685, 502);
            this.delete_kontrachent.Name = "delete_kontrachent";
            this.delete_kontrachent.Size = new System.Drawing.Size(115, 37);
            this.delete_kontrachent.TabIndex = 18;
            this.delete_kontrachent.Text = "Usuń";
            this.delete_kontrachent.UseVisualStyleBackColor = true;
            this.delete_kontrachent.Click += new System.EventHandler(this.delete_kontrahent_Click);
            // 
            // update_kontrachent
            // 
            this.update_kontrachent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.update_kontrachent.Location = new System.Drawing.Point(685, 434);
            this.update_kontrachent.Name = "update_kontrachent";
            this.update_kontrachent.Size = new System.Drawing.Size(115, 37);
            this.update_kontrachent.TabIndex = 17;
            this.update_kontrachent.Text = "Edytuj";
            this.update_kontrachent.UseVisualStyleBackColor = true;
            this.update_kontrachent.Click += new System.EventHandler(this.update_kontrahent_Click);
            // 
            // add_kontrahent
            // 
            this.add_kontrahent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_kontrahent.Location = new System.Drawing.Point(685, 371);
            this.add_kontrahent.Name = "add_kontrahent";
            this.add_kontrahent.Size = new System.Drawing.Size(115, 37);
            this.add_kontrahent.TabIndex = 16;
            this.add_kontrahent.Text = "Dodaj";
            this.add_kontrahent.UseVisualStyleBackColor = true;
            this.add_kontrahent.Click += new System.EventHandler(this.add_kontrahent_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(352, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(352, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(352, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kod pocztowy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(352, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Miasto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(49, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nr domu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(49, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ulica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(49, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nazwa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(49, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kod";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrahenciBindingSource, "Knt_Email", true));
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox8.Location = new System.Drawing.Point(474, 533);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(145, 22);
            this.textBox8.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrahenciBindingSource, "Knt_Telefon1", true));
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.Location = new System.Drawing.Point(474, 462);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(145, 22);
            this.textBox7.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrahenciBindingSource, "Knt_KodPocztowy", true));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(474, 391);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(145, 22);
            this.textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrahenciBindingSource, "Knt_Miasto", true));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(474, 330);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(145, 22);
            this.textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrahenciBindingSource, "Knt_NrDomu", true));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(133, 533);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 22);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrahenciBindingSource, "Knt_Ulica", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(133, 463);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrahenciBindingSource, "Knt_Nazwa1", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(133, 392);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrahenciBindingSource, "Knt_Kod", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(133, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // phraseKontrahenci
            // 
            this.phraseKontrahenci.Location = new System.Drawing.Point(169, 216);
            this.phraseKontrahenci.Name = "phraseKontrahenci";
            this.phraseKontrahenci.Size = new System.Drawing.Size(212, 20);
            this.phraseKontrahenci.TabIndex = 21;
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
            // kontrahenciBindingSource
            // 
            this.kontrahenciBindingSource.DataMember = "Kontrahenci";
            this.kontrahenciBindingSource.DataSource = this.cDN_SEDDataSet;
            // 
            // cDN_SEDDataSet
            // 
            this.cDN_SEDDataSet.DataSetName = "CDN_SEDDataSet";
            this.cDN_SEDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontrahenciTableAdapter
            // 
            this.kontrahenciTableAdapter.ClearBeforeFill = true;
            // 
            // customerCheckBox
            // 
            this.customerCheckBox.AutoSize = true;
            this.customerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.kontrahenciBindingSource, "Knt_Rodzaj_Odbiorca", true));
            this.customerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customerCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerCheckBox.Location = new System.Drawing.Point(87, 268);
            this.customerCheckBox.Name = "customerCheckBox";
            this.customerCheckBox.Size = new System.Drawing.Size(89, 24);
            this.customerCheckBox.TabIndex = 22;
            this.customerCheckBox.Text = "odbiorca";
            this.customerCheckBox.UseVisualStyleBackColor = true;
            // 
            // providerCheckBox
            // 
            this.providerCheckBox.AutoSize = true;
            this.providerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.kontrahenciBindingSource, "Knt_Rodzaj_Dostawca", true));
            this.providerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.providerCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.providerCheckBox.Location = new System.Drawing.Point(240, 268);
            this.providerCheckBox.Name = "providerCheckBox";
            this.providerCheckBox.Size = new System.Drawing.Size(96, 24);
            this.providerCheckBox.TabIndex = 23;
            this.providerCheckBox.Text = "dostawca";
            this.providerCheckBox.UseVisualStyleBackColor = true;
            // 
            // CompetitionCheckBox
            // 
            this.CompetitionCheckBox.AutoSize = true;
            this.CompetitionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.kontrahenciBindingSource, "Knt_Rodzaj_Konkurencja", true));
            this.CompetitionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CompetitionCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CompetitionCheckBox.Location = new System.Drawing.Point(394, 268);
            this.CompetitionCheckBox.Name = "CompetitionCheckBox";
            this.CompetitionCheckBox.Size = new System.Drawing.Size(114, 24);
            this.CompetitionCheckBox.TabIndex = 24;
            this.CompetitionCheckBox.Text = "konkurencja";
            this.CompetitionCheckBox.UseVisualStyleBackColor = true;
            // 
            // partnerCheckBox
            // 
            this.partnerCheckBox.AutoSize = true;
            this.partnerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.kontrahenciBindingSource, "Knt_Rodzaj_Partner", true));
            this.partnerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.partnerCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.partnerCheckBox.Location = new System.Drawing.Point(556, 268);
            this.partnerCheckBox.Name = "partnerCheckBox";
            this.partnerCheckBox.Size = new System.Drawing.Size(79, 24);
            this.partnerCheckBox.TabIndex = 25;
            this.partnerCheckBox.Text = "partner";
            this.partnerCheckBox.UseVisualStyleBackColor = true;
            // 
            // potentialCheckBox
            // 
            this.potentialCheckBox.AutoSize = true;
            this.potentialCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.kontrahenciBindingSource, "Knt_Rodzaj_Potencjalny", true));
            this.potentialCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.potentialCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.potentialCheckBox.Location = new System.Drawing.Point(687, 268);
            this.potentialCheckBox.Name = "potentialCheckBox";
            this.potentialCheckBox.Size = new System.Drawing.Size(108, 24);
            this.potentialCheckBox.TabIndex = 26;
            this.potentialCheckBox.Text = "potencjalny";
            this.potentialCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1052, 655);
            this.Controls.Add(this.panel_kontrachent);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logoutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel_kontrachent.ResumeLayout(false);
            this.panel_kontrachent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDN_SEDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel_kontrachent;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add_kontrahent;
        private System.Windows.Forms.Button update_kontrachent;
        private System.Windows.Forms.Button delete_kontrachent;
        private System.Windows.Forms.ComboBox filterKontrahenci;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CDN_SEDDataSet2 cDN_SEDDataSet;
        private System.Windows.Forms.BindingSource kontrahenciBindingSource;
        private CDN_SEDDataSet2TableAdapters.KontrahenciTableAdapter kontrahenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntNazwa1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntUlicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntNrDomuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntMiastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntKodPocztowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntTelefon1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kntEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox phraseKontrahenci;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox customerCheckBox;
        private System.Windows.Forms.CheckBox providerCheckBox;
        private System.Windows.Forms.CheckBox potentialCheckBox;
        private System.Windows.Forms.CheckBox partnerCheckBox;
        private System.Windows.Forms.CheckBox CompetitionCheckBox;
    }
}