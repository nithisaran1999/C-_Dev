using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LumenWorks.Framework.IO.Csv;
using MySql.Data.MySqlClient;
using System.IO;

namespace RERU
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static string connectorString = "server = localhost;Database=reru2;User ID=root;Password=;CharSet=UTF8";
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Browse Text Files";
            textBox1.Text = this.openFileDialog1.FileName;
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("กรุณาเลือกไฟล์ CSV ก่อน");
            }
            else
            {
                try
                {
                    MySqlConnection Conn = new MySqlConnection(connectorString);
                    var csvTable = new DataTable();
                    using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(textBox1.Text)), true))
                    {
                        csvTable.Load(csvReader);
                    }
                    for (int i = 0; i < csvTable.Rows.Count; i++)
                    {
                        string row1 = csvTable.Rows[i][0].ToString();
                        string row2 = csvTable.Rows[i][1].ToString();
                        string row3 = csvTable.Rows[i][2].ToString();
                        string query = $"INSERT INTO member (member_RERU_ID,member_Name,member_Password) VALUES ('{row1}','{row3.ToString()}','{row2}')";
                        Conn.Open();
                        MySqlCommand myCommand = new MySqlCommand(query, Conn);
                       myCommand.ExecuteNonQuery();
                        Conn.Close();

                    }
                    MessageBox.Show("เพิ่ม " + csvTable.Rows.Count + " คน เข้าสู่ระบบเรียบร้อย");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(connectorString);
            string query = $"INSERT INTO member (member_RERU_ID,member_Name,member_Password) VALUES('{maskedTextBox1.Text}','{textBox2.Text}','{textBox3.Text}')";
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
