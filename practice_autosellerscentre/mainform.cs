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
using Microsoft.Office.Interop.Excel;

namespace practice_autosellerscentre
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password;
            MySqlConnection mysql_connection = new MySqlConnection(Connect);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "select * from `autosellerscentre`";
            mysql_connection.Open();
            MySqlDataReader mySqlDataReader = mysql_query.ExecuteReader();
            try
            {
                while (mySqlDataReader.Read())
                {
                    dataGridView1.Rows.Add(mySqlDataReader["mark"].ToString(), mySqlDataReader["model"].ToString(), 
                        mySqlDataReader["kuzov"].ToString(), mySqlDataReader["engine"].ToString(), mySqlDataReader["wheel"].ToString(), mySqlDataReader["box"].ToString(), mySqlDataReader["vin"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка");
            }
            finally
            {
                mysql_connection.Close();
            }
        }

        private void exitTB_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }
        public string host = "localhost"; // Имя хоста
        public string database = ""; // Имя базы данных
        public string user = "root"; // Имя пользователя
        public string password = ""; // Пароль пользователя
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void copyToExcelButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 15;

            ExcelApp.Cells[1, 1] = "ID";
            ExcelApp.Cells[1, 2] = "Марка";
            ExcelApp.Cells[1, 3] = "Модель";
            ExcelApp.Cells[1, 4] = "Кузов";
            ExcelApp.Cells[1, 5] = "Двигатель";
            ExcelApp.Cells[1, 6] = "Руль";
            ExcelApp.Cells[1, 7] = "Коробка";
            ExcelApp.Cells[1, 8] = "VIN";

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = (dataGridView1[i, j].Value).ToString();
                }
            }
            ExcelApp.Visible = true;
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
