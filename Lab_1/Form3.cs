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
    public partial class Form3 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
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

        int i;

        private void button2_Click(object sender, EventArgs e)
        {
            string selectString =
        "Name Like '%" + textBox1.Text.Trim() + "%'";

            DataRowCollection allRows =
        ((DataTable)dataGridView1.DataSource).Rows;

            DataRow[] searchedRows =
                ((DataTable)dataGridView1.DataSource).
                    Select(selectString);

            int rowIndex = allRows.IndexOf(searchedRows[0]);

            dataGridView1.CurrentCell =
                dataGridView1[0, rowIndex];

            for (int i = 0; i < dataGridView1.RowCount; i++)
                if (dataGridView1[1, i].FormattedValue.ToString().
                    Contains(textBox1.Text.Trim()))
                {
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                    return;
                }

            for (; i < dataGridView1.RowCount;)
                if (dataGridView1[1, i].FormattedValue.ToString().
                    Contains(textBox1.Text.Trim()))
                {
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                    if (i < dataGridView1.RowCount - 1)
                        i++;
                    else
                        i = 0;
                    return;
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
    
}
