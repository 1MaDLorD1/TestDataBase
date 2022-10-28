using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestDataBase
{
    class DataBase
    {
        private SqlConnection _sqlConnection = new SqlConnection(@"Data Source=DESKTOP-DQEKR3D;Initial Catalog=test;Integrated Security=True");

        public void OpenConnection()
        {
            if(_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();
        }

        public void CloseConnection()
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Open)
                _sqlConnection.Close();
        }

        public SqlConnection GetConnection()
        {
            return _sqlConnection;
        }
    }
}
