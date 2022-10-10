using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TagBefizetes
{
    public partial class FormNyito : Form
    {
        public MySqlConnection con = null; //public-nak kell lennie, hogy elérjük a Befizetes osztályból is
        public MySqlCommand sqlCommand = null; //ennek is
        
        public FormNyito()
        {
            InitializeComponent();
        }

        private void FormNyito_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            sb.Port = 3306;

            con = new MySqlConnection(sb.ConnectionString);

            try
            {
                con.Open();

                sqlCommand = con.CreateCommand();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Az alábbi hiba lépett fel:\n{ex.Message}", "Hiba");
                Environment.Exit(0);
            }
            ugyfelListaUpdate();
        }

        private void ugyfelListaUpdate()
        {
            lbUGyfelek.Items.Clear(); //kiürítjük mielőtt feltöltjük
            sqlCommand.CommandText = "SELECT ugyfel.azon, ugyfel.nev FROM ugyfel;";

            using (MySqlDataReader dr = sqlCommand.ExecuteReader())
            {
                while (dr.Read()) //amíg tud olvasni
                {
                    lbUGyfelek.Items.Add(new Ugyfel(dr.GetInt32("azon"), dr.GetString("nev")));
                }
            }
        }

        private void befizetésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formBefizetes.ShowDialog(); //modális ablak, amíg a befizetést nem zárja be, addig nem csinálhat mást a programon belül
        }
    }
}
