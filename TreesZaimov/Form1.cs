using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreesZaimov
{
    public partial class Form1 : Form
    {
        
        string connstr = "server=10.6.0.127;" +
            "port=3306;" +
            "user=PC1;" +
            "password=1111;" +
            "database=trees_zaimov";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MessageBox.Show("connection is open.");

            string insertSQL = "INSERT INTO trees_zaimov.family " +
                "(`name`,name_bg) VALUES (@name,@name_bg)";

            MySqlCommand query = new MySqlCommand(insertSQL, connect);
            query.Parameters.AddWithValue("@name", textBox1.Text);
            query.Parameters.AddWithValue("@name_bg", textBox2.Text);

            query.ExecuteNonQuery();
            MessageBox.Show("uspeshna registraciq");
            connect.Close();
        }
    }
}
