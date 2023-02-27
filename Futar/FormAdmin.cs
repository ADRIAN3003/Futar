using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futar
{
    public partial class frmAdmin : Form
    {
        Adatbazis adatbazis;

        List<Futarok> futaroks = new List<Futarok>();
        List<Partnerek> partnereks = new List<Partnerek>();

        public frmAdmin(Adatbazis adatbazis)
        {
            InitializeComponent();
            this.adatbazis = adatbazis;

            cbPartner.Enabled = false;
            cbFutar.Enabled = false;
            btnMentes.Enabled = false;
            btnMegsem.Enabled = false;

            AdatLekeres();

            cbFutar.DataSource = futaroks;
            cbFutar.DisplayMember = "Text";
            cbFutar.ValueMember = "Id";
            cbFutar.SelectedIndex = 0;

            cbPartner.DataSource = partnereks;
            cbPartner.DisplayMember = "Text";
            cbPartner.ValueMember = "Id";
            cbPartner.SelectedIndex = 0;
        }

        private void AdatLekeres()
        {
            try
            {
                futaroks.Clear();
                partnereks.Clear();
                string sql1 = $"SELECT kuldemenyek.id, kuldemenyek.datum, partnerek.nev AS 'partner', futarok.nev AS 'futar', kuldemenyek.partner_id, kuldemenyek.futar_id FROM kuldemenyek INNER JOIN partnerek ON kuldemenyek.partner_id = partnerek.id INNER JOIN futarok ON kuldemenyek.futar_id = futarok.id;";

                string sql2 = $"SELECT id, nev, tel FROM futarok;";

                string sql3 = $"SELECT id, nev, telefon, kerulet, utca, hszam FROM partnerek;";

                adatbazis.Conn.Open();

                MySqlDataAdapter sorok1 = new MySqlDataAdapter(sql1, adatbazis.Conn);

                DataTable adatok = new DataTable();
                sorok1.Fill(adatok);
                dgvAdmin.DataSource = adatok;

                dgvAdmin.Sort(dgvAdmin.Columns[0], ListSortDirection.Descending);


                MySqlCommand select2 = new MySqlCommand(sql2, adatbazis.Conn);

                MySqlDataReader sorok2 = select2.ExecuteReader();

                if (sorok2.HasRows)
                {
                    while (sorok2.Read())
                    {
                        futaroks.Add(new Futarok(sorok2.GetInt32(0), sorok2.GetString(1), sorok2.GetString(2)));
                    }
                }

                sorok2.Close();


                MySqlCommand select3 = new MySqlCommand(sql3, adatbazis.Conn);

                MySqlDataReader sorok3 = select3.ExecuteReader();

                if (sorok3.HasRows)
                {
                    while (sorok3.Read())
                    {
                        partnereks.Add(new Partnerek(sorok3.GetInt32(0), sorok3.GetString(1), sorok3.GetString(2), sorok3.GetString(3), sorok3.GetString(4), sorok3.GetString(5)));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adatbazis.Conn.Close();
            }
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            dgvAdmin.Enabled = false;
            btnUj.Enabled = false;
            btnModositas.Enabled = false;
            btnTorles.Enabled = false;

            btnMegsem.Enabled = true;
            btnMentes.Enabled = true;
            cbFutar.Enabled = true;
            cbPartner.Enabled = true;
        }

        private void btnMegsem_Click(object sender, EventArgs e)
        {
            dgvAdmin.Enabled = true;
            btnUj.Enabled = true;
            btnModositas.Enabled = true;
            btnTorles.Enabled = true;

            btnMegsem.Enabled = false;
            btnMentes.Enabled = false;
            cbFutar.Enabled = false;
            cbPartner.Enabled = false;
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            dgvAdmin.Enabled = true;
            btnUj.Enabled = true;
            btnModositas.Enabled = true;
            btnTorles.Enabled = true;

            btnMegsem.Enabled = false;
            btnMentes.Enabled = false;
            cbFutar.Enabled = false;
            cbPartner.Enabled = false;

            Felvitel(cbPartner.SelectedValue.ToString(), cbFutar.SelectedValue.ToString());
        }

        private void btnModositas_Click(object sender, EventArgs e)
        {
            dgvAdmin.Enabled = false;
            btnUj.Enabled = false;
            btnModositas.Enabled = false;
            btnTorles.Enabled = false;

            btnMegsem.Enabled = true;
            btnMentes.Enabled = true;
            cbFutar.Enabled = true;
            cbPartner.Enabled = true;

            if (Convert.ToDateTime(dgvAdmin.CurrentRow.Cells["datum"].Value).ToShortDateString() == DateTime.Now.ToShortDateString())
            {

            }
            else
            {
                MessageBox.Show("Csak mai dátumot lehet módosítani!");
                dgvAdmin.Enabled = true;
                btnUj.Enabled = true;
                btnModositas.Enabled = true;
                btnTorles.Enabled = true;

                btnMegsem.Enabled = false;
                btnMentes.Enabled = false;
                cbFutar.Enabled = false;
                cbPartner.Enabled = false;
            }
        }

        private void Felvitel(string partner_id, string futar_id)
        {
            string sql = $"INSERT INTO kuldemenyek (datum, partner_id, futar_id) VALUES ('{DateTime.Now.ToString("yyyy-MM-dd")}', '{partner_id}', '{futar_id}');";

            try
            {
                adatbazis.Conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, adatbazis.Conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adatbazis.Conn.Close();

                AdatLekeres();
            }
        }

        private void dgvAdmin_SelectionChanged(object sender, EventArgs e)
        {
            // Console.WriteLine(cbPartner.Items.IndexOf((int) dgvAdmin.CurrentRow.Cells["partner_id"].Value).ToString());
        }
    }
}
