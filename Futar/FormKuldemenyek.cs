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
    public partial class frmKuldemenyek : Form
    {
        Adatbazis adatbazis;
        public frmKuldemenyek(Adatbazis adatbazis)
        {
            InitializeComponent();
            this.adatbazis = adatbazis;

            AdatLekeres();
        }

        private void AdatLekeres()
        {
            try
            {
                string sql = $"SELECT kuldemenyek.datum, partnerek.nev AS 'partner', partnerek.kerulet, partnerek.utca, partnerek.hszam AS 'hazszam', futarok.nev AS 'futar' FROM kuldemenyek INNER JOIN partnerek ON kuldemenyek.partner_id = partnerek.id INNER JOIN futarok ON kuldemenyek.futar_id = futarok.id;";

                adatbazis.Conn.Open();

                MySqlDataAdapter sorok = new MySqlDataAdapter(sql, adatbazis.Conn);

                DataTable adatok = new DataTable();
                sorok.Fill(adatok);
                dgvKuldemenyek.DataSource = adatok;


                dgvKuldemenyek.Sort(dgvKuldemenyek.Columns[0], ListSortDirection.Descending);
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
    }
}
