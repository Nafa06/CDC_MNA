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

namespace AkademikADOApp
{
    public partial class Form1 : Form
    {
        static string connectionString = string.Format("Server = localhost; database = DBAkademikADO; UID = root; " +
            "Password = 21914113");
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();

                lblStatus.Text = "Status: Database Connected";

                MessageBox.Show("Koneksi ke Database Berhasil", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal", "WARNING" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}