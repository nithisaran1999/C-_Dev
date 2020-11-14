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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public static string connectorString = "server = localhost;Database=reru2;User ID=root;Password=;CharSet=UTF8";
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }
            else
            {
                MySqlConnection Conn = new MySqlConnection(connectorString);


                string coupon_Code = textBox1.Text;
                string act_ID = textBox2.Text;
                string query = $"SELECT coupon_Code,act_ID FROM coupon WHERE coupon_Code = '{coupon_Code}' AND act_ID = '{act_ID}'";
                MySqlDataAdapter da = new MySqlDataAdapter(query, Conn);
                DataTable dTable = new DataTable();
                da.Fill(dTable);
                if (dTable.Rows.Count == 1)
                {
                    string member_ID = Form1.GlobalClass.myGlobalVar;
                    DateTime now = DateTime.Now;

                    try
                    {
                        string s = now.ToString("yyyy/MM/dd HH:mm:ss");
                        string regis_query = $"INSERT INTO regis (regis_Time,act_ID,coupon_Code,member_ID) VALUES ('{s}',{act_ID},'{coupon_Code}','{member_ID}')";
                        string delete_coupon = $"DELETE FROM coupon WHERE coupon_Code='{coupon_Code}'";
                        Conn.Open();
                        MySqlCommand myCommand = new MySqlCommand(regis_query, Conn);
                        MySqlCommand myCommand2 = new MySqlCommand(delete_coupon, Conn);
                        myCommand.ExecuteNonQuery();
                        myCommand2.ExecuteNonQuery();
                        MessageBox.Show("ลงทะเบียนเรียบร้อย");
                        Conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Code ถูกใช้ไปแล้วหรือ Code ไม่ถูกต้อง");
                }
            }
        }
    }
}
