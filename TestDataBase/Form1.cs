using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDataBase
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {
        private DataBase _dataBase = new DataBase();

        private int _selectedRow;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView.Columns.Add("id", "ID");
            dataGridView.Columns.Add("type_of", "Тип товара");
            dataGridView.Columns.Add("count_of", "Количество");
            dataGridView.Columns.Add("supply", "Поставщик");
            dataGridView.Columns.Add("price", "Цена");
            dataGridView.Columns.Add("IsNew", String.Empty);
        }

        private void ClearFields()
        {
            idTextBox.Text = "";
            productTypeTextBox.Text = "";
            countTextBox.Text = "";
            supplyTextBox.Text = "";
            priceTextBox.Text = "";
        }

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRow = e.RowIndex;

            if (_selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[_selectedRow];

                idTextBox.Text = row.Cells[0].Value.ToString();
                productTypeTextBox.Text = row.Cells[1].Value.ToString();
                countTextBox.Text = row.Cells[2].Value.ToString();
                supplyTextBox.Text = row.Cells[3].Value.ToString();
                priceTextBox.Text = row.Cells[4].Value.ToString();
            }
        }

        private void newEntryButton_Click(object sender, EventArgs e)
        {
            _dataBase.OpenConnection();

            var type = productTypeTextBox.Text;
            var count = countTextBox.Text;
            var supply = supplyTextBox.Text;
            int price;

            if(int.TryParse(priceTextBox.Text, out price))
            {
                var addQuery = $"insert into testdb (type_of, count_of, supply, price) values ('{type}', '{count}', '{supply}', '{price}')";

                SqlCommand command = new SqlCommand(addQuery, _dataBase.GetConnection());

                command.ExecuteNonQuery();

                MessageBox.Show("Новая запись создана!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Цена должна быть числом!", "Невозможно создать запись!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            _dataBase.CloseConnection();
        }

        private void updateBox_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView);
            ClearFields();
        }

        private void RefreshDataGrid(DataGridView dataGridView)
        {
            string query = $"select * from testdb";

            RefreshDataGridWithRegulations(query);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchQuery = $"select * from testdb where concat (id, type_of, count_of, supply, price) like '%" + searchTextBox.Text + "%'";

            RefreshDataGridWithRegulations(searchQuery);
        }

        private void RefreshDataGridWithRegulations(string query)
        {
            dataGridView.Rows.Clear();

            SqlCommand command = new SqlCommand(query, _dataBase.GetConnection());

            _dataBase.OpenConnection();

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ReadSingleRow(dataGridView, dataReader);
            }

            dataReader.Close();

            _dataBase.CloseConnection();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы дейсвительно хотите удалить запись?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int index = dataGridView.CurrentCell.RowIndex;

                    dataGridView.Rows[index].Visible = false;

                    dataGridView.Rows[index].Cells[5].Value = RowState.Deleted;
                }
            }
            catch
            {
                MessageBox.Show("Нельзя удалить запись, т.к. она не выбрана", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            ClearFields();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _dataBase.OpenConnection();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView.Rows[i].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }
                else if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);

                    var deleteQuery = $"delete from testdb where id = '{id}'";

                    SqlCommand command = new SqlCommand(deleteQuery, _dataBase.GetConnection());

                    command.ExecuteNonQuery();
                }
                else if (rowState == RowState.Modified)
                {
                    var id = dataGridView.Rows[i].Cells[0].Value.ToString();
                    var type = dataGridView.Rows[i].Cells[1].Value.ToString();
                    var count = dataGridView.Rows[i].Cells[2].Value.ToString();
                    var supply = dataGridView.Rows[i].Cells[3].Value.ToString();
                    var price = dataGridView.Rows[i].Cells[4].Value.ToString();

                    var changeQuery = $"update testdb set type_of = '{type}', count_of = '{count}', supply = '{supply}', price = '{price}' where id = '{id}'";

                    SqlCommand command = new SqlCommand(changeQuery, _dataBase.GetConnection());

                    command.ExecuteNonQuery();
                }
            }

            _dataBase.CloseConnection();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = dataGridView.CurrentCell.RowIndex;

            var id = idTextBox.Text;
            var type = productTypeTextBox.Text;
            var count = countTextBox.Text;
            var supply = supplyTextBox.Text;
            int price;

            if (dataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(priceTextBox.Text, out price))
                {
                    dataGridView.Rows[selectedRowIndex].SetValues(id, type, count, supply, price);

                    dataGridView.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                    MessageBox.Show("Цена должна быть числом!", "Невозможно создать запись!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ClearFields();
        }

        private void trashBox_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
