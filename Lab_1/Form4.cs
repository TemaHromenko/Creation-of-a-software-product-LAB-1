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
using System.Configuration;
using Microsoft.OData.Edm;

namespace Lab_1
{
    public partial class Form4 : Form
    {

        private SqlConnection sqlConnection = null;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.MASTER". При необходимости она может быть перемещена или удалена.
            this.mASTERTableAdapter.Fill(this.database1DataSet.MASTER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.INDUSTRY". При необходимости она может быть перемещена или удалена.
            this.iNDUSTRYTableAdapter.Fill(this.database1DataSet.INDUSTRY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.HOLDINGS". При необходимости она может быть перемещена или удалена.
            this.hOLDINGSTableAdapter.Fill(this.database1DataSet.HOLDINGS);
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение установлено");
            }
            else
            {   
                MessageBox.Show("Произошла ошибка");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 showDate = new Form1();
            showDate.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            iNDUSTRYTableAdapter.Update(database1DataSet.INDUSTRY);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            hOLDINGSTableAdapter.Update(database1DataSet.HOLDINGS);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            mASTERTableAdapter.Update(database1DataSet.MASTER);
        }
    }
}