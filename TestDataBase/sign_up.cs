using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDataBase
{
    public partial class sign_up : Form
    {
        private DataBase dataBase = new DataBase();

        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '•';
            openEye.Visible = false;
            loginBox.MaxLength = 50;
            passwordBox.MaxLength = 50;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var loginUser = loginBox.Text;
            var passwordUser = HashingMD5.HashPassword(passwordBox.Text);

            if (CheckEnteredData())
            {
                string queryString = $"insert into register (login_user, password_user) values('{loginUser}', '{passwordUser}')";

                SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

                dataBase.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Вы успешно создали аккаунт!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log_in loginForm = new log_in();
                    Hide();
                    loginForm.Show();
                }
                else
                    MessageBox.Show("Что-то пошло не так!", "Неверно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Пользователь с таким логином уже существует!", "Неверно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dataBase.CloseConnection();
        }

        private bool CheckEnteredData()
        {
            var loginUser = loginBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string queryString = $"select login_user from register where login_user = '{loginUser}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
                return false;
            else
                return true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            loginBox.Text = "";
            passwordBox.Text = "";
        }

        private void openEye_Click(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = false;
            openEye.Visible = false;
            closedEye.Visible = true;
        }

        private void closedEye_Click(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = true;
            openEye.Visible = true;
            closedEye.Visible = false;
        }

        private void sign_up_FormClosing(object sender, FormClosingEventArgs e)
        {
            log_in loginForm = new log_in();
            loginForm.Show();
        }
    }
}
