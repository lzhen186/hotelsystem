using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Models;
namespace DAL
{
    public class AdminService
    {
        //管理员登录
        public SysAdmin Login(SysAdmin objAdmin) {
            string sql = "select LoginName from SysAdmins where LoginId=@LoginId and LoginPwd=@LoginPwd";
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@LoginId",objAdmin.LoginId),
                new SqlParameter("@LoginPwd",objAdmin.LoginPwd)
            };
            SqlDataReader objReader = SQLHelper.GetReader(sql, param);
            if (objReader.Read())
            {                objAdmin.LoginName = objReader["LoginName"].ToString();            }
            else
            {                objAdmin = null;            }
            objReader.Close();
            return objAdmin;
        }
    }
}
