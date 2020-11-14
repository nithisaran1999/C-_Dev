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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public static string connectorString = "server = localhost;Database=reru2;User ID=root;Password=;CharSet=UTF8";



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ชื่อกิจกรรมไม่ถูกต้อง!!");
            }else if (comboBox1.Text == "")
            {
                MessageBox.Show("ชนิดกิจกรรมไม่ถูกต้อง");
            }
            MySqlConnection Conn = new MySqlConnection(connectorString);
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                try
                {
                    string act_Year = checkedListBox1.Items[indexChecked].ToString();
                    dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    string query = $"INSERT INTO act (act.act_Name,act.act_Date,act.act_Exp,act.act_Type,act.act_Term,act.act_Year) VALUES ('{textBox1.Text}','{dateTimePicker1.Text}','{dateTimePicker2.Text}','{comboBox1.Text}','{comboBox2.Text}/{maskedTextBox1.Text}','{act_Year}')";
                    Conn.Open();
                    MySqlCommand myCommand = new MySqlCommand(query, Conn);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("เพิ่มกิจกรรมเรียบร้อย");
                    Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            (new Form2()).Refresh();
        }

    }
}
