using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDNBase;
using CDNHeal;
using CDNRVAT;
using CDNTwrb1;
using OP_KASBOLib;

namespace OptimaAPI
{
    public partial class Form2 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public IApplication Application { get; set; }
        public ILogin Login { get; set; }

        public Form2(IApplication application, ILogin login)
        {
            Application = application;
            Login = login;

            InitializeComponent();
            ChangeNameOfKontrachenciColumns();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.UnlockApp();
            this.Visible = false;
            
            Form1 loginForm = new Form1();
            loginForm.Show();
            loginForm.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.UnlockApp();
            System.Windows.Forms.Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDN_SEDDataSet.Kontrahenci' table. You can move, or remove it, as needed.
            this.kontrahenciTableAdapter.Fill(this.cDN_SEDDataSet.Kontrahenci);

            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            /*
            AdoSession session = Login.CreateSession();
            RejestryVAT rejestryVAT = (RejestryVAT)(session.CreateObject("CDN.RejestryVat", null));
            VAT rejestrVAT = (VAT)rejestryVAT[string.Format("VaN_VaNID='{0}'", "1")];

            MessageBox.Show($"{rejestrVAT.Podmiot.Nazwa1}");
            */
        }

        private void ChangeNameOfKontrachenciColumns()
        {
            /*
            this.dataGridView1.Columns[0].HeaderText = "Kod";
            this.dataGridView1.Columns[1].HeaderText = "Nazwa";
            this.dataGridView1.Columns[2].HeaderText = "Ulica";
            this.dataGridView1.Columns[3].HeaderText = "Nr domu";
            this.dataGridView1.Columns[4].HeaderText = "Miasto";
            this.dataGridView1.Columns[5].HeaderText = "Kod pocztowy";
            this.dataGridView1.Columns[6].HeaderText = "Telefon";
            this.dataGridView1.Columns[7].HeaderText = "Email";
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel_kontrachent.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_kontrachent.Visible = false;
            panel2.Visible = true;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Gray, 3),
                            this.DisplayRectangle);
        }

        private void add_kontrahent_Click(object sender, EventArgs e)
        {
            AdoSession session = Login.CreateSession();

            Kontrahenci kontrahenci = (Kontrahenci)session.CreateObject("CDN.Kontrahenci", null);
            IKontrahent kontrahent = (IKontrahent)kontrahenci.AddNew(null);

            IAdres adres = kontrahent.Adres;

            kontrahent.Akronim = textBox1.Text;
            kontrahent.Nazwa1 = textBox2.Text;
            adres.Ulica = textBox3.Text;
            adres.NrDomu = textBox4.Text;
            adres.Miasto = textBox5.Text;
            adres.KodPocztowy = textBox6.Text;
            kontrahent.Telefon = textBox7.Text;
            kontrahent.Email = textBox8.Text;

            try
            {
                session.Save();
                this.kontrahenciTableAdapter.Fill(this.cDN_SEDDataSet.Kontrahenci);
            }
            catch (Exception ex)
            {

            }
        }

        private void update_kontrahent_Click(object sender, EventArgs e)
        {
            AdoSession session = Login.CreateSession();

            Kontrahenci kontrahenci = (Kontrahenci)session.CreateObject("CDN.Kontrahenci", null);
            IKontrahent kontrahent = (IKontrahent)kontrahenci[$"Knt_Kod='{textBox1.Text}'"];

            IAdres adres = kontrahent.Adres;

            kontrahent.Akronim = textBox1.Text;
            kontrahent.Nazwa1 = textBox2.Text;
            adres.Ulica = textBox3.Text;
            adres.NrDomu = textBox4.Text;
            adres.Miasto = textBox5.Text;
            adres.KodPocztowy = textBox6.Text;
            kontrahent.Telefon = textBox7.Text;
            kontrahent.Email = textBox8.Text;

            try
            {
                session.Save();

                this.kontrahenciTableAdapter.Fill(this.cDN_SEDDataSet.Kontrahenci);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void delete_kontrahent_Click(object sender, EventArgs e)
        {
            AdoSession session = Login.CreateSession();

            Kontrahenci kontrahenci = (Kontrahenci)session.CreateObject("CDN.Kontrahenci", null);

            /*
            Towary towary = (Towary)session.CreateObject("CDN.Towary", null);
            towary.Delete("Twr_Kod='KOD1'");
            */

            try
            {
                kontrahenci.Delete((IKontrahent)kontrahenci[$"Knt_Kod='{textBox1.Text}'"]);
                session.Save();

                this.kontrahenciTableAdapter.Fill(this.cDN_SEDDataSet.Kontrahenci);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            var changedValue = (string)row.Cells[e.ColumnIndex].Value;

            AdoSession session = Login.CreateSession();

            Kontrahenci kontrahenci = (Kontrahenci)session.CreateObject("CDN.Kontrahenci", null);
            IKontrahent kontrahent = (IKontrahent)kontrahenci[$"Knt_Kod='{(string)row.Cells[0].Value}'"];

            IAdres adres = kontrahent.Adres;

            kontrahent.Akronim = (string)row.Cells[0].Value;
            kontrahent.Nazwa1 = (string)row.Cells[1].Value;
            adres.Ulica = (string)row.Cells[2].Value;
            adres.NrDomu = (string)row.Cells[3].Value;
            adres.Miasto = (string)row.Cells[4].Value;
            adres.KodPocztowy = (string)row.Cells[5].Value;
            kontrahent.Telefon = (string)row.Cells[6].Value;
            kontrahent.Email = (string)row.Cells[7].Value;

            try
            {
                session.Save();
                
                this.kontrahenciTableAdapter.Fill(this.cDN_SEDDataSet.Kontrahenci);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
