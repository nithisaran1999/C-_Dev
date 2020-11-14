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
using System.IO;

namespace RERU
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public static string connectorString = "server = localhost;Database=reru2;User ID=root;Password=";

        public void csvToDB()
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file =  new System.IO.StreamReader(textBox1.Text);
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedValue;

            string cou_Exp = dateTimePicker1.Text;
            MessageBox.Show(selectedItem.ToString());
            MessageBox.Show(cou_Exp);
            MySqlConnection Conn = new MySqlConnection(connectorString);
            try
            {
                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    string query = $"INSERT INTO coupon (coupon_Code,act_ID,coupon_Exp) VALUES ('{line}',{selectedItem},'{cou_Exp}')";
                    Conn.Open();
                    MySqlCommand myCommand = new MySqlCommand(query, Conn);
                    myCommand.ExecuteNonQuery();
                    
                    Conn.Close();
                    counter++;
                }
                MessageBox.Show("Added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            file.Close();
            System.Console.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string foldername = this.folderBrowserDialog1.SelectedPath;
            textBox1.Text = foldername + "\\Coupon.csv";
            int vlenght = Int16.Parse(maskedTextBox1.Text);
            var rand = new Random();
            string result1 = null;
            string result2 = null;
            string result = null;
            var words = new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T" };
            var number = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            try
            {
                for (int k = 0; k != vlenght; k++)
                {
                    result1 = null;
                    result2 = null;
                    result1 = string.Concat(result1, words[rand.Next(words.Length)]);
                    result1 = string.Concat(result1, words[rand.Next(words.Length)]);
                    result2 = string.Concat(result2, number[rand.Next(number.Length)]);
                    result2 = string.Concat(result2, number[rand.Next(number.Length)]);
                    result2 = string.Concat(result2, number[rand.Next(number.Length)]);
                    result = result1 + result2;

                    using (TextWriter tw = new StreamWriter(textBox1.Text, true))
                    {
                        tw.WriteLine(result);
                    }
                    result = null;
                }
                MessageBox.Show("Successed!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            csvToDB();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            MySqlConnection Conn = new MySqlConnection(connectorString);
            string query = "select act_ID,act_Name FROM act";
            MySqlDataAdapter da = new MySqlDataAdapter(query, Conn);
            Conn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "ACT");
            comboBox1.ValueMember = "act_ID";
            comboBox1.DisplayMember = "act_Name";
            comboBox1.DataSource = ds.Tables["ACT"];
        }

    }
}
