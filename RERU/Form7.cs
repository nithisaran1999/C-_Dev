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
    public partial class Form7 : Form
    {
        
        public Form7()
        {
            InitializeComponent();
        }


        public static string connectorString = "server = localhost;Database=reru2;User ID=root;Password=;CharSet=UTF8";

        private void ลงทะเบยนกจกรรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form6()).Show();
        }

        private void load()
        {

            string member_ID = Form1.GlobalClass.myGlobalVar;
            string query = $"SELECT * FROM regis WHERE regis.member_ID = '{member_ID}'";
            MySqlConnection MyConn = new MySqlConnection(connectorString);
            MySqlCommand MyComm = new MySqlCommand(query, MyConn);
            MySqlDataAdapter MyAdap = new MySqlDataAdapter();
            try
            {
                MyAdap.SelectCommand = MyComm;
                DataTable dTable = new DataTable();
                MyAdap.Fill(dTable);
                dataGridView1.DataSource = dTable;
                dataGridView1.Columns["act_ID"].HeaderText = "ID กิจกรรม";
                dataGridView1.Columns["coupon_Code"].HeaderText = "Coupon Code";
                int count = dataGridView1.RowCount - 1;
                label1.Text = "ลงทะเบียนไปเเล้ว : " + count.ToString() + " กิจกรรม";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            string member_ID = Form1.GlobalClass.myGlobalVar;
            load();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
