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
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                $"INSERT INTO INDUSTRY (IND_CODE, IND_NAME, LONG_NAME) VALUES (N'{textBox1.Text}', N'{textBox2.Text}', N'{textBox3.Text}')",
                sqlConnection);

            command.ExecuteNonQuery().ToString();
            MessageBox.Show("Успешно");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand(
                $"INSERT INTO HOLDINGS (ACCT_NBR, SYMBOL, SHARES, PUR_PRICE, PUR_DATE) VALUES (@ACCT_NBR, @SYMBOL, @SHARES, @PUR_PRICE, @PUR_DATE)",
                sqlConnection);

            DateTime date = DateTime.Parse(textBox8.Text);
            
            command2.Parameters.AddWithValue("ACCT_NBR", textBox4.Text);
            command2.Parameters.AddWithValue("SYMBOL", textBox5.Text);
            command2.Parameters.AddWithValue("SHARES", textBox6.Text);
            command2.Parameters.AddWithValue("PUR_PRICE", textBox7.Text);
            command2.Parameters.AddWithValue("PUR_DATE", $"{date.Month}/{date.Month}/{date.Year}");
            command2.ExecuteNonQuery().ToString();
            MessageBox.Show("Успешно");

            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                $"INSERT INTO MASTER (SYMBOL, CO_NAME, EXCHANGE, CUR_PRICE, YRL_HIGH, YRL_LOW, P_E_RATIO," +
                $"BETA, PROJ_GRTH, INDUSTRY, PRICE_CHG, SAFETY, RATING, RANK, OUTLOOK, RCMNDATION, RICK) VALUES " +
                $"(N'{textBox9.Text}', N'{textBox10.Text}', N'{textBox11.Text}', N'{textBox12.Text}',N'{textBox13.Text}'" +
                $"N'{textBox14.Text}', N'{textBox15.Text}', N'{textBox16.Text}', N'{textBox17.Text}', N'{textBox18.Text}'" +
                $"N'{textBox19.Text}', N'{textBox20.Text}', N'{textBox21.Text}', N'{textBox22.Text}', N'{textBox23.Text}'" +
                $"N'{textBox24.Text}', N'{textBox25.Text}'" +
                sqlConnection);

            command.ExecuteNonQuery().ToString();
            MessageBox.Show("Успешно");
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
        }
         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это первая лабораторная работа по этой дисциплне. " +
                "Здесь используються базы данных. Автор - Артём Громенко, Илья калюга, группа 326ст. Было сложно. ");
        }

        private void helpContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В следующей лабе будет что-то похожее.Наверное... ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 showDate = new Form2();
            showDate.Show();
        }

        private void rEADMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ВНИМАНИЕ!!! Ввод данных допускаеться в размерах, указанных в задании." +
                "В случае попытки ввести данные, которые больше по размеру, произойдёт ошибка. Спасибо.");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 showDate = new Form4();
            showDate.Show();
        }
    }
}
