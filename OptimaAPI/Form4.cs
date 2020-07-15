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
        private IApplication Application;
        private List<ITowar> Towary = new List<ITowar>();
        public Form4(IApplication application, ILogin login)
        {
            Application = application;
            Login = login;
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
        }
    }
}
