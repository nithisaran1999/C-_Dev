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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public static string connectorString = "server = localhost;Database=reru2;User ID=root;Password=;CharSet=UTF8";

        private void Form8_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection MyConn = new MySqlConnection(connectorString);
                string query = "SELECT act_Name,act_ID FROM act";
                MySqlDataAdapter da = new MySqlDataAdapter(query, MyConn);
                MyConn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "act");
                comboBox1.DisplayMember = "act_Name";
                comboBox1.ValueMember = "act_ID";
                comboBox1.DataSource = ds.Tables["act"];
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            couponData();

        }

        private void couponData()
        {
            string query = "SELECT * FROM coupon";
            MySqlConnection MyConn = new MySqlConnection(connectorString);
            MySqlCommand MyComm = new MySqlCommand(query, MyConn);
            MySqlDataAdapter MyAdap = new MySqlDataAdapter();
            try
            {
                MyAdap.SelectCommand = MyComm;
                DataTable dTable = new DataTable();
                MyAdap.Fill(dTable);
                dataGridView1.DataSource = dTable;
                dataGridView1.Columns["coupon_ID"].HeaderText = "ID";
                dataGridView1.Columns["coupon_Code"].HeaderText = "Code";
                dataGridView1.Columns["act_ID"].HeaderText = "ID กิจกรรม";
                dataGridView1.Columns["coupon_Exp"].HeaderText = "วันหมดอายุ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM coupon WHERE act_id ={comboBox1.SelectedValue}";
            MySqlConnection MyConn = new MySqlConnection(connectorString);
            MySqlCommand MyComm = new MySqlCommand(query, MyConn);
            MySqlDataAdapter MyAdap = new MySqlDataAdapter();
            try
            {
                MyAdap.SelectCommand = MyComm;
                DataTable dTable = new DataTable();
                MyAdap.Fill(dTable);
                dataGridView1.DataSource = dTable;
                dataGridView1.Columns["coupon_ID"].HeaderText = "ID";
                dataGridView1.Columns["coupon_Code"].HeaderText = "Code";
                dataGridView1.Columns["act_ID"].HeaderText = "ID กิจกรรม";
                dataGridView1.Columns["coupon_Exp"].HeaderText = "วันหมดอายุ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
