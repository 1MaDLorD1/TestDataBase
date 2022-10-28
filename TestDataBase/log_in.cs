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
    public partial class log_in : Form
    {
        private DataBase _dataBase = new DataBase();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '•';
            openEye.Visible = false;
            loginBox.MaxLength = 50;
            passwordBox.MaxLength = 50;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            var loginUser = loginBox.Text;
            var passwordUser = HashingMD5.HashPassword(passwordBox.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string queryString = $"select * from register where login_user = '{loginUser}' and password_user = '{passwordUser}'";

            SqlCommand command = new SqlCommand(queryString, _dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form = new Form1();
                Hide();
                form.ShowDialog();
                Show();
            }
            else
                MessageBox.Show("Проверьте логин или пароль!", "Неверно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up signUp = new sign_up();
            signUp.Show();
            Hide();
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

        private void log_in_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
