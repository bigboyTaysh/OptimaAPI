﻿using CDNBase;
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
        private void exitButton_Paint(object sender, PaintEventArgs e)
        {
            
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

            kontrahenciComboBox.SelectedIndex = 1;

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Gray, 3),
                            this.DisplayRectangle);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[3].Value = "1.0000";
        }
    }
}
