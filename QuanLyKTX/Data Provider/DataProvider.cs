using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKTX.DataProvider
{

    public class DBConnection
    {
        //SqlConnection cnnStr = new SqlConnection(@"Data Source=THANHBINH\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        //SqlConnection cnnStr = new SqlConnection(@"Data Source=LAPTOP-MB5F72F2\SQLEXPRESS;Initial Catalog=QuanLyKTX_3;Integrated Security=True");
        //SqlConnection cnnStr = new SqlConnection(@"Data Source=LAPTOP-MB5F72F2\SQLEXPRESS;Initial Catalog=QuanLyKTX_3;Integrated Security=True");
        SqlConnection cnnStr = new SqlConnection(@"Data Source=DESKTOP-JBR423G;Initial Catalog=QuanLyKTX_3;Integrated Security=True");
        private SqlDataAdapter adapter;
        private SqlConnection connection;
        public DBConnection()
        {
            adapter = new SqlDataAdapter();
            connection = new SqlConnection(Properties.Settings.Default.cnnStr);
        }
        private SqlConnection openConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }

        public object executeScalar(String query, SqlParameter[] sqlParameter)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddRange(sqlParameter);
                object result = new object();
                try
                {
                    result = sqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return result;
            }
        }

        public DataTable ExecuteProcedureDatatable(string spName, string[] pNames, object[] pValues)
        {
            openConnection();
            // Khai báo và khởi tạo đối tượng Command với tham số tên thủ tục spName
            SqlCommand cmd = new SqlCommand(spName, connection);
            // Khai báo kiểu thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            // Khai báo tham số SqlParameter
            SqlParameter p;
            // Khởi tạo danh sách các tham số với giá trị tương ứng
            for (int i = 0; i < pNames.Length; i++)
            {
                p = new SqlParameter(pNames[i], pValues[i]);
                cmd.Parameters.Add(p);
            }
            DataTable dt = new DataTable();
            SqlDataReader dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dt.Load(dataReader);
            return dt;
        }

        public DataTable executeReader(String query, SqlParameter[] sqlParameter)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddRange(sqlParameter);
                DataTable dt = new DataTable();
                try
                {
                    SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    dt.Load(dataReader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return dt;
            }
        }
        public DataTable ExecuteProcedureDatatableNoPara(string spName) //trả về 1 bảng khi gọi procedure bên sql
        {

            openConnection();
            // Khai báo và khởi tạo đối tượng Command với tham số tên thủ tục spName
            SqlCommand cmd = new SqlCommand(spName, connection);
            // Khai báo kiểu thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataReader dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dt.Load(dataReader);
            return dt;

        }
       /* public string executeCount(string query)           // trả về số lượng 
        {
            string cout = null ;
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                try
                {
                    cout = (string)sqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return cout;
            }
        }*/

        public DataTable executeLoadData(string query)      // trả về bảng dữ liệu
        {
            using (SqlCommand command = new SqlCommand(query, openConnection()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        dt.Load(reader);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                        reader.Close();
                    }
                    return dt;
                }
            }
        }

        public int ExecuteStoredProcedure(string spName, string[] pNames, object[] pValues) //trả về 1 giá trị khi gọi procedure bên sql

        {
            int kq = 0;
            openConnection();
            // Khai báo và khởi tạo đối tượng Command với tham số tên thủ tục spName
            SqlCommand cmd = new SqlCommand(spName, connection);
            // Khai báo kiểu thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            // Khai báo tham số SqlParameter
            SqlParameter p;
            // Khởi tạo danh sách các tham số với giá trị tương ứng
            for (int i = 0; i < pNames.Length; i++)
            {
                p = new SqlParameter(pNames[i], pValues[i]);
                cmd.Parameters.Add(p);
            }
            SqlParameter n = new SqlParameter("@kq", SqlDbType.Int);
            n.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(n);
            cmd.ExecuteScalar();
            kq = (Int32)n.Value;
            connection.Close();
            return kq;
        }
        public string ExecuteStoredProcedureString(string spName, string[] pNames, object[] pValues) //trả về 1 giá trị khi gọi procedure bên sql

        {
            string kq = "";
            openConnection();
            // Khai báo và khởi tạo đối tượng Command với tham số tên thủ tục spName
            SqlCommand cmd = new SqlCommand(spName, connection);
            // Khai báo kiểu thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            // Khai báo tham số SqlParameter
            SqlParameter p;
            // Khởi tạo danh sách các tham số với giá trị tương ứng
            for (int i = 0; i < pNames.Length; i++)
            {
                p = new SqlParameter(pNames[i], pValues[i]);
                cmd.Parameters.Add(p);
            }
            SqlParameter n = new SqlParameter("@kq", SqlDbType.VarChar);
            n.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(n);
            cmd.ExecuteScalar();
            kq = Convert.ToString(n.Value);
            connection.Close();
            return kq;
        }

        public int ExecuteStoredProcedure_Update(string spName, string[] pNames, object[] pValues) //thêm, xóa, sửa khi gọi procedure bên sql

        {
            openConnection();
            // Khai báo và khởi tạo đối tượng Command với tham số tên thủ tục spName
            SqlCommand cmd = new SqlCommand(spName, connection);
            // Khai báo kiểu thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            // Khai báo tham số SqlParameter
            SqlParameter p;
            // Khởi tạo danh sách các tham số với giá trị tương ứng
            for (int i = 0; i < pNames.Length; i++)
            {
                p = new SqlParameter(pNames[i], pValues[i]);
                cmd.Parameters.Add(p);
            }
            return cmd.ExecuteNonQuery();
        }
    }     
}
