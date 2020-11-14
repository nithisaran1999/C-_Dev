﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string connectorString = "server = localhost;Database=reru2;User ID=root;Password=;CharSet=UTF8";
        private void เพมกจกรรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form4()).Show();
        }


        private void ลบกจกรรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DEl ACTIVE");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string query = "SELECT act_Name,act_Type,act_Year,act_Term FROM act";
            MySqlConnection MyConn = new MySqlConnection(connectorString);
            MySqlCommand MyComm = new MySqlCommand(query, MyConn);
            MySqlDataAdapter MyAdap = new MySqlDataAdapter();
            try 
            {
                MyAdap.SelectCommand = MyComm;
                DataTable dTable = new DataTable();
                MyAdap.Fill(dTable);
                dataGridView1.DataSource = dTable;
                dataGridView1.Columns["act_Name"].HeaderText = "ชื่อกิจกรรม";
                dataGridView1.Columns["act_Type"].HeaderText = "ประเภท";
                dataGridView1.Columns["act_Term"].HeaderText = "ปีการศึกษา";
                dataGridView1.Columns["act_Year"].HeaderText = "ชั้นปีที่เข้าร่วม";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }


    }
}