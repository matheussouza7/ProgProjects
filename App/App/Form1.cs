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
namespace App
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=app;Uid=root;Pwd=sous12345;");
        MySqlCommand query;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string STRSQL = "INSERT INTO usuario (name) VALUES(@NOME)";
                query = new MySqlCommand(STRSQL, conn);
                query.Parameters.AddWithValue("@NOME", txtNome.Text);
                conn.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("User added!");
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro: "+ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                
                string STRSQL = "select name from usuario";
                MySqlDataAdapter da = new MySqlDataAdapter(STRSQL,conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDados.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
