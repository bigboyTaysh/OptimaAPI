using CDNBase;
using CDNHeal;
using CDNHlmn;
using CDNTwrb1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimaAPI
{
    public partial class Form4 : Form
    {
        private ILogin Login;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool dragging = false;
        public List<ITowar> Towary { get; set; }
        public Form4(IApplication application, ILogin login)
        {
            Login = login;
            Towary = new List<ITowar>();
            InitializeComponent();

            dataGridView1.DataSource = Towary.Select(t =>
                new {
                    t.Kod,
                    t.Nazwa,
                    t.Stawka,
                    t.JM,
                    Ceny = ((Cena)t.Ceny[0]).Wartosc
                }).ToList();

            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDN_SEDDataSet5.FormyPlatnosci' table. You can move, or remove it, as needed.
            this.formyPlatnosciTableAdapter.Fill(this.cDN_SEDDataSet5.FormyPlatnosci);
            // TODO: This line of code loads data into the 'cDN_SEDDataSet4.Kontrahenci' table. You can move, or remove it, as needed.
            this.kontrahenciTableAdapter.Fill(this.cDN_SEDDataSet4.Kontrahenci);

            kontrahenciComboBox.SelectedIndex = 1;
            platnosciComboBox.SelectedIndex = 1;

        }
        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                decimal sum = 0m;

                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells[3].Value != null)
                    {
                        sum += decimal.Parse(item.Cells[3].Value.ToString()) * decimal.Parse(item.Cells[4].Value.ToString());
                    }
                }

                NumberFormatInfo setPrecision = new NumberFormatInfo();
                setPrecision.NumberDecimalDigits = 4;

                label2.Text = sum.ToString("N", setPrecision);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(Login, this);
            form.Show();
            form.Activate();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AdoSession session = Login.CreateSession();

            DokumentyHaMag documents = (DokumentyHaMag)session.CreateObject("CDN.DokumentyHaMag",null);
            DokumentHaMag document = (DokumentHaMag)documents.AddNew(null);

            ICollection kontrahenci = (ICollection)(session.CreateObject("CDN.Kontrahenci", null));
            IKontrahent kontrahent = (IKontrahent)kontrahenci[$"Knt_Nazwa1='{kontrahenciComboBox.Text}'"];

            MessageBox.Show(kontrahent.Nazwa1);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Gray, 3),
                            this.DisplayRectangle);
        }
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if(e.StateChanged.ToString() == "Displayed")
            {
                e.Row.Cells[3].Value = "1,0000";
            }
        }
        public void RefreshList()
        {
            var towary = Towary.Select(t =>
                new {
                    t.Kod,
                    t.Nazwa,
                    t.Stawka,
                    t.JM,
                    Ceny = ((Cena)t.Ceny[0]).Wartosc
                }).ToList();

            dataGridView1.DataSource = towary;

            label2.Text = towary.Sum(t => t.Ceny).ToString();
        }
    }
}
