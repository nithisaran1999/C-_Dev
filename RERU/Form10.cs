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

namespace RERU
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        public static string connectorString = "server = localhost;Database=reru2;User ID=root;Password=;CharSet=UTF8";

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(connectorString);
            string query = $"INSERT INTO admin (admin_Username,admin_Password) VALUES ('{textBox1.Text}','{textBox2.Text}')";
            try
            {
                Conn.Open();
                MySqlCommand myCommand = new MySqlCommand(query, Conn);
                myCommand.ExecuteNonQuery();
                Conn.Close();
                MessageBox.Show("เพิ่มเรียบร้อย");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
