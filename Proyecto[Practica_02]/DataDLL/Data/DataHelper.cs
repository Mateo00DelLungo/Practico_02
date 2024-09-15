using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLL.Data
{
    public class DataHelper
    {
        private static SqlConnection _cnn;
        private static DataHelper _instance;
        public DataHelper()
        {
            _cnn = new SqlConnection(Properties.Resources.cnnString);
        }
        public static DataHelper GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DataHelper();
            }
            return _instance;
        }
        public static SqlConnection GetConnection()
        {
            return _cnn;
        }
        private void CloseConnection()
        {
            if (_cnn != null && _cnn.State == ConnectionState.Open) 
            {
                _cnn.Close();
            }
        }
        public int ExecuteSPNonQuery(string sp, List<Parametro>? parametros)
        {
            int rows = 0;
            try
            {
                _cnn.Open();
                var cmd = new SqlCommand(sp, _cnn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                if (parametros != null)
                {
                    cmd = Parametro.LoadToCMD(parametros,cmd);
                }
                rows = cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return rows;
        }
        public DataTable ExecuteSPQuery(string sp, List<Parametro>? parametros)
        {
            var dt = new DataTable();
            try
            {
                _cnn.Open();
                var cmd = new SqlCommand(sp, _cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                {
                    cmd = Parametro.LoadToCMD(parametros, cmd);
                }
                dt.Load(cmd.ExecuteReader());
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
    }
}
