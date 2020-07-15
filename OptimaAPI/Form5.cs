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
        private IApplication Application;
        private List<ITowar> Towary;
        public Form5(IApplication application, ILogin login, List<ITowar> towary)
        {
            Application = application;
            Login = login;
            Towary = towary;
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
    }
}
