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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string connectorString = "server = localhost;Database=reru2;User ID=root;Password=;CharSet=UTF8";
        private void เพมกจกรรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form4()).Show();
        }


        private void ลบกจกรรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DEl ACTIVE");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection MyConn = new MySqlConnection(connectorString);
                string query = "SELECT act_Term FROM act GROUP BY act_Term HAVING count(act_Term) > 1";
                MySqlDataAdapter da = new MySqlDataAdapter(query, MyConn);
                MyConn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "act");
                comboBox3.DisplayMember = "act_Term";
                comboBox3.ValueMember = "act_Term";
                comboBox3.DataSource = ds.Tables["act"];
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            loadData();
        }

        private void เำToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form5()).Show();
        }

        private void เพมนกศกษาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form3()).Show();
        }
        public void loadData()
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void refashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void findData()
        {
            if (comboBox1.Text == "" && comboBox2.Text == "" && comboBox3.Text == "")
            {
                loadData();
            }
            else
            {
                string member_Year_find = null;
                string act_Type_find = null;
                string act_Term_find = null;
                if (comboBox1.Text != "ทั้งหมด")
                {
                    member_Year_find = $"act_Year = {comboBox1.Text}";
                }

                if (comboBox2.Text != "ทั้งหมด")
                {
                    if (comboBox1.Text == "ทั้งหมด")
                    {
                        act_Type_find = $"act_Type = '{comboBox2.Text}'";
                    }
                    else
                    {
                        act_Type_find = $"AND act_Type = '{comboBox2.Text}'";
                    }
                        
                }

                if (comboBox3.Text != "ทั้งหมด")
                {
                    if (comboBox2.Text == "ทั้งหมด" && comboBox1.Text == "ทั้งหมด")
                    {
                        act_Term_find = $"act_Term = '{comboBox3.Text}'";
                    }
                    else
                    {
                        act_Term_find = $"AND act_Term = '{comboBox3.Text}'";
                    }
                        
                }

                string find_query = $"SELECT * FROM act WHERE {member_Year_find} {act_Type_find} {act_Term_find}";
                MessageBox.Show(find_query);
                MySqlConnection MyConn = new MySqlConnection(connectorString);
                MySqlCommand MyComm = new MySqlCommand(find_query, MyConn);
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataGridView1.Update();
                dataGridView1.Refresh();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                findData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form8()).Show();
        }

        private void ลบนกศกษาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form9()).Show();
        }

        private void เพมผดแลระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form10()).Show();
        }
    }
}
