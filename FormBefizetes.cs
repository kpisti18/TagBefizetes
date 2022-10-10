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

namespace TagBefizetes
{
    public partial class FormBefizetes : Form
    {
        Ugyfel kivlasztottUgyfel = null;

        public FormBefizetes()
        {
            InitializeComponent();
        }

        private void FormBefizetes_Load(object sender, EventArgs e)
        {
            if (Program.formNyito.lbUGyfelek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott ügyfél!", "Hiba");
            }

            kivlasztottUgyfel = (Ugyfel)Program.formNyito.lbUGyfelek.SelectedItem; //ügyfél osztályú, a Program osztály formNyito form-jának listboxának kiválasztott eleme
            tbNev.Text = kivlasztottUgyfel.Name;
        }

        private void btBefizet_Click(object sender, EventArgs e)
        {
            Program.formNyito.sqlCommand.CommandText = $"INSERT INTO `befiz`(`azon`, `datum`, `osszeg`) VALUES ('{kivlasztottUgyfel.Id}', '{DateTime.Now.ToString("u")}', '{nudBefizet.Value}')"; //vagy DateTime.Now.ToString("yyyyy-MM-d H:m:s")

            try
            {
                if (Program.formNyito.sqlCommand.ExecuteNonQuery() == 1) //az executenonqeury a select kivételével tudja a parancsokat (insert, delete, update)
                {
                    MessageBox.Show("Sikeres rögzítés");
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzítés");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}
