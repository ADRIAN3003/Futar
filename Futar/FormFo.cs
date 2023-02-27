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
    public partial class frmFo : Form
    {
        Adatbazis adatbazis;
        Felhasznalo felhasznalo;

        public frmFo(Adatbazis adatbazis, Felhasznalo felhasznalo)
        {
            InitializeComponent();
            this.adatbazis = adatbazis;
            this.felhasznalo = felhasznalo;

            string userAccess = felhasznalo.Admin ? "Admin" : "User";

            Text = $"Főmenü - {felhasznalo.Teljesnev} ({userAccess})";

            if (!felhasznalo.Admin)
            {
                btnAdmin.Enabled = false;
                btnPartnerek.Enabled = false;
                btnFutarok.Enabled = false;
            }
        }

        private void FormFo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKuldemenyek_Click(object sender, EventArgs e)
        {
            frmKuldemenyek frmKuldemenyek = new frmKuldemenyek(adatbazis);
            frmKuldemenyek.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin(adatbazis);
            frmAdmin.ShowDialog();
        }
    }
}
