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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        public static string connectorString = "server = localhost;Database=reru2;User ID=root;Password=;CharSet=UTF8";

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(connectorString);
            string query = $"DELETE FROM member WHERE member_RERU_ID = {maskedTextBox1.Text}";
            try
            {
                Conn.Open();
                MySqlCommand myCommand = new MySqlCommand(query, Conn);
                myCommand.ExecuteNonQuery();
                Conn.Close();
                MessageBox.Show("ลบเรียบร้อย");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
