using CDNBase;
using CDNTwrb1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimaAPI
{
    public partial class Form4 : Form
    {
        private ILogin Login;
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
        }

        public void RefreshList()
        {
            dataGridView1.DataSource = Towary.Select(t =>
                new {
                    t.Kod,
                    t.Nazwa,
                    t.Stawka,
                    t.JM,
                    Ceny = ((Cena)t.Ceny[0]).Wartosc
                }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(Login, this);
            form.Show();
            form.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDN_SEDDataSet4.Kontrahenci' table. You can move, or remove it, as needed.
            this.kontrahenciTableAdapter.Fill(this.cDN_SEDDataSet4.Kontrahenci);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
