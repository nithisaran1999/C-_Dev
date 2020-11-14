using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace RERU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string connectorString = "server = localhost;Database=reru2;User ID=root;Password=";

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        public static class GlobalClass
        {
            private static string globalVar ;

            public static string myGlobalVar
            {
                get
                {
                    return globalVar;
                }
                set
                {
                    globalVar = value;
                }
            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool IsServerConnected()
        {
            try
            {
                using (var l_oConnection = new MySqlConnection(connectorString))
                {
                    try
                    {
                        l_oConnection.Open();
                        return true;
                    }
                    catch (SqlException)
                    {
                        
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("โปรดกรอกรหัสนักศึกษา");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("โปรดกรอกรหัสผ่าน");
            }
            else if (textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("โปรดกรอกรหัสนักศึกษา รหัสผ่าน");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("โปรดเลือกสถานะ");
            }
            else
            {
                if (comboBox1.Text == "นักศึกษา")
                {
                    string password = textBox2.Text.Trim();
                    string query = $"SELECT * FROM member WHERE member.member_RERU_ID LIKE '{textBox1.Text.Trim()}' AND member.member_Password LIKE '{password}'";
                    MySqlConnection Conn = new MySqlConnection(connectorString);
                    MySqlDataAdapter Adap = new MySqlDataAdapter(query, Conn);
                    DataTable dTable = new DataTable();
                    Adap.Fill(dTable);
                    if (dTable.Rows.Count == 1)
                    {
                        GlobalClass.myGlobalVar = dTable.Rows[0].Field<string>(1);
                        
                        MessageBox.Show(GlobalClass.myGlobalVar.ToString());
                        this.Hide();
                        (new Form7()).Show();
                    }
                    else
                    {
                        MessageBox.Show("ขื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง!!");
                    }

                }
                else if(comboBox1.Text== "ผู้ดูแลระบบ")
                {
                    string password = textBox2.Text.Trim();
                    string query = $"SELECT * FROM admin WHERE admin.admin_Username LIKE '{textBox1.Text.Trim()}' AND admin.admin_Password LIKE '{password}'";
                    MySqlConnection Conn = new MySqlConnection(connectorString);
                    MySqlDataAdapter Adap = new MySqlDataAdapter(query, Conn);
                    DataTable dTable = new DataTable();
                    Adap.Fill(dTable);
                    if (dTable.Rows.Count == 1)
                    {
                        this.Hide();
                        (new Form2()).Show();
                    }
                    else
                    {
                        MessageBox.Show("ขื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง!!");
                    }
                }
            }


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(connectorString);
            if (CheckForInternetConnection() == true)
            {
                label1.Text = "Internet Connection : Pass!";
            }
            else
            {
                label1.Text = "Internet Connection : Fail!";
            }

            if (IsServerConnected() == true)
            {
                label2.Text = "Database Connection : Connected!";
            }
            else
            {
                label2.Text = "Database Connection : Fail!";
            }
            DateTime today = DateTime.Today;
            string now = today.ToString("yyyy-MM-dd");
            string query = $"DELETE FROM coupon WHERE coupon_Exp = '{now}'";
            try
            {
                Conn.Open();
                MySqlCommand myCommand = new MySqlCommand(query, Conn);
                myCommand.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
