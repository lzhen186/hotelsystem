using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class SQLHelper
    {
        private static string conn = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        //方法重载
        /// <summary>
        /// 执行增删改的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql) {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd  =  new SqlCommand(sql, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
            
        }
        public static int Update(string sql,SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddRange(param);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }
        /// <summary>
        /// 执行单行返回结果的的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object Getsingel(string sql) {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            object result = cmd.ExecuteScalar();
            con.Close();
            return result;
        }
        public static object Getsingel(string sql,SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddRange(param);
            object result = cmd.ExecuteScalar();
            con.Close();
            return result;
        }
        /// <summary>
        /// 返回多行语句的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql) {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader result = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return result;
           
        }
        public static SqlDataReader GetReader(string sql,SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddRange(param);
            SqlDataReader result = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return result;

        }

    }
}
