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
    public partial class Form5 : Form
    {
        private ILogin Login;
        private Form4 Form4;
        private List<ITowar> Towary = new List<ITowar>();
        public Form5(ILogin login, Form4 form)
        {
            Login = login;
            Form4 = form;
            InitializeComponent();
            LoadTowary();
        }
        private void LoadTowary()
        {
            AdoSession session = Login.CreateSession();
            Towary towary = (Towary)session.CreateObject("CDN.Towary", null);
            
            foreach (ITowar item in towary)
            {
                Towary.Add(item);
            }

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
            List<string> docs = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)row.Cells[5];
                if (check.Value != null && (bool)check.Value) 
                {
                    docs.Add((string)row.Cells[0].Value);
                }
            }

            Form4.Towary = Towary.Where(t => docs.Any(d => d.Equals(t.Kod))).ToList();
            Form4.RefreshList();
            this.Close();
        }
        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Gray, 3),
                            this.DisplayRectangle);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
