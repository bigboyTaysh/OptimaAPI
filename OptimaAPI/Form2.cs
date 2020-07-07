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

namespace OptimaAPI
{
    public partial class Form2 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private IApplication Application { get; set; }
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
            loginForm.TopMost = true;
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
        }

        private void ChangeNameOfKontrachenciColumns()
        {
            this.dataGridView1.Columns[0].HeaderText = "Kod";
            this.dataGridView1.Columns[1].HeaderText = "Nazwa";
            this.dataGridView1.Columns[2].HeaderText = "Ulica";
            this.dataGridView1.Columns[3].HeaderText = "Nr domu";
            this.dataGridView1.Columns[4].HeaderText = "Miasto";
            this.dataGridView1.Columns[5].HeaderText = "Kod pocztowy";
            this.dataGridView1.Columns[6].HeaderText = "Telefon";
            this.dataGridView1.Columns[7].HeaderText = "Email";
        }
    }
}
