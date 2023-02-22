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
    public partial class frmBejelentkezes : Form
    {
        Adatbazis adatbazis;
        Felhasznalo felhasznalo;

        public frmBejelentkezes()
        {
            InitializeComponent();
            adatbazis = new Adatbazis();
            tbJelszo.PasswordChar = '\u2022';
        }

        private void btnMegsem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBejelentkezes_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbFelhasznalo.TextLength == 0 || tbJelszo.TextLength == 0)
                {
                    throw new Exception("A felhasználónév és a jelszó megadása kötelező!");
                }
                else
                {
                    string felhText = tbFelhasznalo.Text;
                    string jelszoText = tbJelszo.Text;
                    string lekredezes = $"SELECT id, teljes_nev, nev, jelszo, admin FROM `felhasznalok` WHERE `nev` = '{felhText}' AND `jelszo` = '{jelszoText}';";

                    adatbazis.Conn.Open();

                    MySqlCommand select = new MySqlCommand(lekredezes, adatbazis.Conn);

                    MySqlDataReader sorok = select.ExecuteReader();

                    if (sorok.HasRows)
                    {
                        sorok.Read();
                        int id = sorok.GetInt32(0);
                        string teljesnev = sorok.GetString(1);
                        string nev = sorok.GetString(2);
                        string jelszo = sorok.GetString(3);
                        bool admin = sorok.GetBoolean(4);

                        felhasznalo = new Felhasznalo(id, teljesnev, nev, jelszo, admin);

                        //MessageBox.Show($"Sikeres belépés!\nÜdv {felhasznalo.Teljesnev}!");
                    }
                    else
                    {
                        adatbazis.Conn.Close();
                        throw new Exception("Helytelen felhasználó vagy jelszó!");
                    }

                    adatbazis.Conn.Close();

                    Hide();
                    FormFo frmFo = new FormFo(adatbazis, felhasznalo);
                    frmFo.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
