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
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Form1()
        {
            InitializeComponent();
            System.Environment.CurrentDirectory = @"C:\Program Files (x86)\Comarch ERP Optima";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string loginText = textBox1.Text;
            string password = textBox2.Text;
            string company = textBox3.Text;
            ILogin login;
            IApplication application = null;

            try
            {
                application = new CDNBase.Application();
                login = application.LockApp(256, 5000, null, null, null, null);
                login = application.Login(
                    loginText,
                    password,
                    company,
                    1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0);
                
                this.Visible = false;

                Form2 appForm = new Form2(application, login);
                appForm.Show();
                appForm.Activate();

            } catch (Exception ex) 
            {
                if(application != null)
                {
                    application.UnlockApp();
                }
                label4.Text = "Błąd logowania";
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Gray, 3),
                            this.DisplayRectangle);
        }
    }
}
