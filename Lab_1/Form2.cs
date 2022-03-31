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
    public partial class Form2 : Form
    {

        private SqlConnection sqlConnection = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.INDUSTRY". При необходимости она может быть перемещена или удалена.
            this.iNDUSTRYTableAdapter.Fill(this.database1DataSet.INDUSTRY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.HOLDINGS". При необходимости она может быть перемещена или удалена.
            this.hOLDINGSTableAdapter.Fill(this.database1DataSet.HOLDINGS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.MASTER". При необходимости она может быть перемещена или удалена.
            this.mASTERTableAdapter.Fill(this.database1DataSet.MASTER);
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            sqlConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainOk = new Form1();
            mainOk.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataadapter = new SqlDataAdapter(
                "SELECT * FROM HOLDINGS",
                sqlConnection);
                
            DataSet dataSet = new DataSet();

            dataadapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataadapter = new SqlDataAdapter(
                "SELECT * FROM MASTER",
                sqlConnection);

            DataSet dataSet = new DataSet();

            dataadapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataadapter = new SqlDataAdapter(
               "SELECT * FROM INDUSTRY",
               sqlConnection);

            DataSet dataSet = new DataSet();

            dataadapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
