using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace sss
{
    public partial class Запись_на_услугу : Form
    {
        static string conSTR = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=b1;Integrated Security=True";
        DataContext cont = new DataContext(conSTR);
        public Запись_на_услугу()
        {
            InitializeComponent();
        }

        private void Запись_на_услугу_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1DataSet.ClientService". При необходимости она может быть перемещена или удалена.
            this.clientServiceTableAdapter.Fill(this.b1DataSet.ClientService);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.b1DataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1DataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.b1DataSet.Client);

        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Добавить", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (res == DialogResult.Yes)
            {
                ClientServ clientServ = new ClientServ { ClientID = comboBox2.SelectedIndex, ServiceID = comboBox1.SelectedIndex, StartTime = dateTimePicker1.Value };
                cont.GetTable<ClientServ>().InsertOnSubmit(clientServ);
                cont.SubmitChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
