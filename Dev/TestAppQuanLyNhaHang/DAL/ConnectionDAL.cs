using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppQuanLyNhaHang.DAL
{
    class ConnectionDAL
    {
        #region Varialbles
        private SqlConnection connect;
        #endregion

        #region Mothods
        /// <summary>
        /// Create connection database method
        /// </summary>
        public ConnectionDAL()
        {
            connect = new SqlConnection();
            connect.ConnectionString = @"Data Source=NAMLXUIT\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error: " + sqlEx.Message);
            }
            //finally
            //{
            //    connect.Close();
            //}
        }

        /// <summary>
        /// Get data from database non parameter
        /// </summary>
        /// <param name="sql">store procedure name</param>
        /// <returns>table have data</returns>
        public DataTable LoadData(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connect) { CommandType = CommandType.StoredProcedure };
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Function get data form database have some parameter
        /// </summary>
        /// <param name="sql"> store procedure name </param>
        /// <param name="name"> parameters name </param>
        /// <param name="value"> value of parameters </param>
        /// <param name="parameters"> number of parameters </param>
        /// <returns></returns>
        public DataTable LoadData(string sql,
            string[] name,
            object[] value,
            int parameters)
        {
            SqlCommand command = new SqlCommand(sql, connect) { CommandType = CommandType.StoredProcedure };
            for (int i = 0; i < parameters; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Update data into database no parameter
        /// </summary>
        /// <param name="sql"> store procedure name </param>
        /// <returns> Check update ( 1 is success, 0 non-fail) </returns>
        public int Update(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connect) { CommandType = CommandType.StoredProcedure };
            return command.ExecuteNonQuery();
        }

        /// <summary>
        /// Update data into database have some parameter
        /// </summary>
        /// <param name="sql"> store procedure name </param> 
        /// <param name="name"> parameter name </param>
        /// <param name="value">parameter value </param>
        /// <param name="parameters"> number of parameter </param>
        /// <returns> Check update ( 1 is success, 0 non-fail) </returns>
        public int Update(string sql,
            string[] name,
            object[] value,
            int parameters)
        {
            SqlCommand command = new SqlCommand(sql, connect) { CommandType = CommandType.StoredProcedure };

            for (int i = 0; i < parameters; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            return command.ExecuteNonQuery();
        }
        #endregion
    }
}
