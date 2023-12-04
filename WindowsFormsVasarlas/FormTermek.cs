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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsAppLogin;

namespace WindowsFormsVasarlas
{
    public partial class FormTermek : Form
    {
        public FormTermek()
        {
            InitializeComponent();
        }

        private void FormTermek_Load(object sender, EventArgs e)
        {
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                    Program.connection.Open();
                Program.command.CommandText = "SELECT `termekid`,`termeknev`,`ar`,`db` FROM `termek` WHERE 1 ORDER BY termeknev";

                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Termek beolvasottTermek = new Termek(dr.GetInt32("termekid"), dr.GetString("termeknev"), dr.GetInt32("ar"), dr.GetInt32("db"));
                        comboBox1.Items.Add(beolvasottTermek);
                        comboBox1.SelectedIndex = 0;
                    }
                    dr.Close();
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Termek term = (Termek)comboBox1.SelectedItem;
            numericUpDown_crudid.Value = term.termekid;
            textBox_crudnev.Text = term.termeknev;
            numericUpDown_crudar.Value = term.ar;
            numericUpDown_cruddb.Value = term.db;       
        }
    }
}
