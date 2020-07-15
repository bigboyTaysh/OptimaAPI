using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDNBase;
using CDNHeal;
using CDNRVAT;
using CDNTwrb1;
using CDNHlmn;
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
        }

        #region okno
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
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Gray, 3),
                            this.DisplayRectangle);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDN_SEDDataSet2.TraNag' table. You can move, or remove it, as needed.
            filterKontrahenciComboBox.SelectedIndex = 0;
            this.kontrahenciTableAdapter.Fill(this.cDN_SEDDataSet.Kontrahenci);
            this.towaryTableAdapter.Fill(this.cDN_SEDDataSet1.Towary);

            traNagBindingSource.Filter = "TrN_TypDokumentu='309'";
            this.traNagTableAdapter.Fill(this.cDN_SEDDataSet2.TraNag);
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
        private void ChangeMenuButtonsColor(string name)
        {
            foreach (Control control in GetAllControl(name))
            {
                if (control.GetType() == typeof(Button))
                {
                    control.BackColor = Color.FromArgb(54, 57, 63);
                    (control as Button).FlatAppearance.BorderColor = Color.FromArgb(54, 57, 63);
                }
            }
        }
        private List<Control> GetAllControl(string name)
        {
            List<Control> controls = new List<Control>();

            foreach (var control in this.Controls)
            {
                if (control.GetType() == typeof(Panel))
                {
                    var panel = control as Panel;
                    if (panel.Name.Contains(name))
                    {
                        foreach (var button in panel.Controls)
                        {
                            if (button.GetType() == typeof(Button))
                            {
                                controls.Add((Control)button);
                            }
                        }
                    }
                }
            }

            return controls;
        }
        #endregion

        #region menu
        private void kontrahenciButton_Click(object sender, EventArgs e)
        {
            ChangeMenuButtonsColor("menuPanel");
            kontrahenciButton.BackColor = Color.FromArgb(114, 137, 218);
            kontrahenciPanel.Visible = true;
            towaryPanel.Visible = false;
            zamowieniaPanel.Visible = false;
        }
        private void towaryButton_Click(object sender, EventArgs e)
        {
            ChangeMenuButtonsColor("menuPanel");
            towaryButton.BackColor = Color.FromArgb(114, 137, 218);
            kontrahenciPanel.Visible = false;
            towaryPanel.Visible = true;
            zamowieniaPanel.Visible = false;
        }
        private void zamowieniaButton_Click(object sender, EventArgs e)
        {
            ChangeMenuButtonsColor("menuPanel");
            zamowieniaButton.BackColor = Color.FromArgb(114, 137, 218);
            kontrahenciPanel.Visible = false;
            towaryPanel.Visible = false;
            zamowieniaPanel.Visible = true;
        }
        #endregion

        #region kontrahenciPanel
        private void kontrahenciPanel_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.Columns[0].ReadOnly = true;
        }
        #endregion

        #region towaryPanel
        private void towaryPanel_Paint(object sender, PaintEventArgs e)
        {
            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.RowHeadersWidth = 25;
            dataGridView2.Columns[0].ReadOnly = true;
        }
        #endregion

        #region kontrahent
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
            kontrahent.Rodzaj_Odbiorca = customerCheckBox.Checked ? 1 : 0;
            kontrahent.Rodzaj_Dostawca = providerCheckBox.Checked ? 1 : 0;
            kontrahent.Rodzaj_Konkurencja = competitionCheckBox.Checked ? 1 : 0;
            kontrahent.Rodzaj_Partner = partnerCheckBox.Checked ? 1 : 0;
            kontrahent.Rodzaj_Potencjalny = potentialCheckBox.Checked ? 1 : 0;

            try
            {
                session.Save();
                this.kontrahenciTableAdapter.Fill(this.cDN_SEDDataSet.Kontrahenci);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            kontrahent.Rodzaj_Odbiorca = customerCheckBox.Checked ? 1 : 0;
            kontrahent.Rodzaj_Dostawca = providerCheckBox.Checked ? 1 : 0;
            kontrahent.Rodzaj_Konkurencja = competitionCheckBox.Checked ? 1 : 0;
            kontrahent.Rodzaj_Partner = partnerCheckBox.Checked ? 1 : 0;
            kontrahent.Rodzaj_Potencjalny = potentialCheckBox.Checked ? 1 : 0;

            try
            {
                session.Save();
                this.kontrahenciTableAdapter.Fill(this.cDN_SEDDataSet.Kontrahenci);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];

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
                MessageBox.Show(ex.Message);
            }
        }
        private void filterKontrahenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchKontrahenci();
        }
        private void phraseKontrahenci_TextChanged(object sender, EventArgs e)
        {
            searchKontrahenci();
        }
        private void searchKontrahenci()
        {
            string phrase = $"(Knt_Kod like '%{phraseKontrahenci.Text}%' or" +
                        $" Knt_Nazwa1 like '%{phraseKontrahenci.Text}%' or" +
                        $" Knt_Ulica like '%{phraseKontrahenci.Text}%' or" +
                        $" Knt_Miasto like '%{phraseKontrahenci.Text}%' or" +
                        $" Knt_Telefon1 like '%{phraseKontrahenci.Text}%' or" +
                        $" Knt_Email like '%{phraseKontrahenci.Text}%')";

            switch (filterKontrahenciComboBox.Text)
            {
                
                case "odbiorca":
                    kontrahenciBindingSource.Filter = phrase + " and Knt_Rodzaj_Odbiorca='1'";
                    break;

                case "dostawca":
                    kontrahenciBindingSource.Filter = phrase + " and Knt_Rodzaj_Dostawca='1'";
                    break;

                case "konkurencja":
                    kontrahenciBindingSource.Filter = phrase + " and Knt_Rodzaj_Konkurencja='1'";
                    break;

                case "partner":
                    kontrahenciBindingSource.Filter = phrase + " and Knt_Rodzaj_Partner='1'";
                    break;

                case "potencjalny":
                    kontrahenciBindingSource.Filter = phrase + " and Knt_Rodzaj_Potencjalny='1'";
                    break;

                case "-każdy-":
                    kontrahenciBindingSource.Filter = phrase;
                    break;
            }

            this.kontrahenciTableAdapter.Fill(this.cDN_SEDDataSet.Kontrahenci);
        }
        #endregion

        #region towar
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView2.Rows[e.RowIndex];

            AdoSession session = Login.CreateSession();
            Towary towary = (Towary)session.CreateObject("CDN.Towary", null);
            Towar towar = (Towar)towary[$"Twr_Kod='{(string)row.Cells[0].Value}'"];
            Cena cena = (Cena)(towar.Ceny[$"Twc_TwcNumer='1'"]);

            towar.Nazwa = (string)row.Cells[1].Value;
            towar.JM = (string)row.Cells[2].Value;
            towar.Stawka = (decimal)row.Cells[3].Value;
            cena.Wartosc = (decimal)row.Cells[4].Value;

            try
            {
                session.Save();
                this.towaryTableAdapter.Fill(this.cDN_SEDDataSet1.Towary);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addTowar_Click(object sender, EventArgs e)
        {
            AdoSession session = Login.CreateSession();
            Towary towary = (Towary)session.CreateObject("CDN.Towary", null);
            Towar towar = (Towar)towary.AddNew(null);
            Cena cena = (Cena)(towar.Ceny[$"Twc_TwcNumer='1'"]);

            towar.Kod = textBox11.Text;
            towar.Nazwa = textBox10.Text;
            towar.JM = towaryComboBox.Text;
            towar.Stawka = decimal.Parse(textBox15.Text);
            cena.Wartosc = decimal.Parse(textBox14.Text);
            
            try
            {
                session.Save();
                this.towaryTableAdapter.Fill(this.cDN_SEDDataSet1.Towary);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateTowar_Click(object sender, EventArgs e)
        {
            AdoSession session = Login.CreateSession();
            Towary towary = (Towary)session.CreateObject("CDN.Towary", null);
            Towar towar = (Towar)towary[$"Twr_Kod='{textBox11.Text}'"];
            Cena cena = (Cena)(towar.Ceny[$"Twc_TwcNumer='1'"]);

            towar.Nazwa = textBox10.Text;
            towar.JM = towaryComboBox.Text;
            towar.Stawka = decimal.Parse(textBox15.Text);
            cena.Wartosc = decimal.Parse(textBox14.Text);

            try
            {
                session.Save();
                this.towaryTableAdapter.Fill(this.cDN_SEDDataSet1.Towary);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void deleteTowar_Click(object sender, EventArgs e)
        {
            AdoSession session = Login.CreateSession();
            Towary towary = (Towary)session.CreateObject("CDN.Towary", null);
            try
            {
                towary.Delete($"Twr_Kod='{textBox11.Text}'");
                session.Save();
                this.towaryTableAdapter.Fill(this.cDN_SEDDataSet1.Towary);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void phraseTowary_TextChanged(object sender, EventArgs e)
        {
            searchTowary();
        }
        private void searchTowary()
        {
            string phrase = $"Twr_Kod like '%{phraseTowary.Text}%' or" +
                        $" Twr_Nazwa like '%{phraseTowary.Text}%'";

            cDNSEDDataSet1BindingSource.Filter = phrase;

            this.towaryTableAdapter.Fill(this.cDN_SEDDataSet1.Towary);
        }
        #endregion

        #region zamówienia
        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dataGridView3.Rows[e.RowIndex];

            AdoSession session = Login.CreateSession();
            DokumentyHaMag dokumenty = (DokumentyHaMag)session.CreateObject("CDN.DokumentyHaMag", null);
            DokumentHaMag dokument = (DokumentHaMag)dokumenty[$"TrN_NumerPelny='{(string)row.Cells[0].Value}'"];

            Form3 form = new Form3(dokument);
            form.Show();
            form.Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(Application, Login);
            form.Show();
            form.Activate();
        }
        #endregion
    }
}
