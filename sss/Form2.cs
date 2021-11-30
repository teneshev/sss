using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sss
{
    public partial class Form2 : Form
    {
        string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=b1;Integrated Security=True";
        SqlConnection cod = new SqlConnection();
        SqlCommand cmt = new SqlCommand();
        int ID;
        public Form2(int service)
        {
            InitializeComponent();
            ID = service;
            cod.ConnectionString = constr;
            cmt.Connection = cod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cod.Open();
            cmt.CommandText = "update [Service] set Title = '" + textBox1.Text + "', Cost = '" + textBox2.Text + "', DurationInSeconds = '" + textBox3.Text + "', Description = '" + textBox4.Text + "', Discount = '" + textBox5.Text + "', MainImagePath = '" + textBox6.Text + "' where [ID]= " + ID;
            cmt.ExecuteNonQuery();
            cod.Close();
            MessageBox.Show("Измененно");
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
