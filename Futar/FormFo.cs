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
    public partial class FormFo : Form
    {
        Adatbazis adatbazis;
        Felhasznalo felhasznalo;

        public FormFo(Adatbazis adatbazis, Felhasznalo felhasznalo)
        {
            InitializeComponent();
            this.adatbazis = adatbazis;
            this.felhasznalo = felhasznalo;

            string userAccess = felhasznalo.Admin ? "Admin" : "User";

            Text = $"Főmenü - {felhasznalo.Teljesnev} ({userAccess})";
        }

        private void FormFo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
