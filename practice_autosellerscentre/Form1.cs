﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_autosellerscentre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string host = "localhost"; // Имя хоста
        public string database = ""; // Имя базы данных
        public string user = "root"; // Имя пользователя
        public string password = ""; // Пароль пользователя
        private void authButton_Click(object sender, EventArgs e)
        {
            if (loginTB.Text == "LoginW/DB")
            {
                MessageBox.Show("Авторизация без БД");
                mainform mainform = new mainform();
                mainform.Show();
                this.Hide();
            }
            else
            {
                string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password;
                MySqlConnection mysql_connection = new MySqlConnection(Connect);
                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = "select * from `auth` where `login`=@username and `password`=@userpassword";
                mysql_query.Parameters.Add("@username", MySqlDbType.VarChar).Value = loginTB.Text;
                mysql_query.Parameters.Add("@userpassword", MySqlDbType.VarChar).Value = passTB.Text;
                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                mysql_connection.Open();
                dataAdapter.SelectCommand = mysql_query;
                dataAdapter.Fill(dataTable);
                try
                {
                    if (dataTable.Rows.Count == 1)
                    {
                        mainform mainform = new mainform();
                        mainform.Show();
                        mysql_connection.Close();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неправильные логин или пароль");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка подключения к базе данныx.");
                }
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {

        }

        private void loginTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void passTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
