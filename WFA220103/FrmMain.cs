using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220103
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            btnLekerdezes.MouseEnter += BtnLekerdezes_MouseEnter;
            btnLekerdezes.MouseLeave += BtnLekerdezes_MouseLeave;
        }

        private void BtnLekerdezes_MouseLeave(object sender, EventArgs e)
        {
            btnLekerdezes.UseVisualStyleBackColor = true;
        }

        private void BtnLekerdezes_MouseEnter(object sender, EventArgs e)
        {
            btnLekerdezes.BackColor = Color.Green;
        }

        private void BtnLekerdezes_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection(
                "Server = (localdb)\\MSSQLLocalDB;" +
                "Database = adatbazis;");

            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM tabla;", conn);

            var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                rtbAdatok.Text += $"{rdr["nev"]}\n";
            }
            conn.Close();
        }
    }
}
