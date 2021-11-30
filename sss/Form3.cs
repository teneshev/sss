using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sss
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1DataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.b1DataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.b1DataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1DataSet.ProductSale". При необходимости она может быть перемещена или удалена.
            this.productSaleTableAdapter.Fill(this.b1DataSet.ProductSale);

        }

        private void Выход_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Запись_на_услугу zap = new Запись_на_услугу();
            zap.ShowDialog(); ;
        }
    }
}
