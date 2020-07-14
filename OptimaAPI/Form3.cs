using CDNHlmn;
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
    public partial class Form3 : Form
    {
        private DokumentHaMag dokument; 
        public Form3(DokumentHaMag dokumentHaMag)
        {
            InitializeComponent();
            dokument = dokumentHaMag;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string phrase = $"TrE_TrNId = {dokument.ID}";

            zamowieniaBindingSource.Filter = phrase;

            this.zamowieniaTableAdapter.Fill(this.cDN_SEDDataSet3.Zamowienia);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Gray, 3),
                this.DisplayRectangle);
        }
    }
}
