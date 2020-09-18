using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Models;


namespace DAL
{
    public class RecruitmentService
    {
        /// <summary>
        /// 招聘
        /// </summary>
        /// <returns></returns>
        public List<Recruitment1> GetAllRecruit()
        {
            string sql = "select PostId, PostName, PostType, PostPlace, PostDesc, PostRequire, Experience, EduBackground, RequireCount, PublishTime, Manager, PhoneNumber, Email";
            sql += " from Recruitment order by PublishTime Desc";
            List<Recruitment1> list = new List<Recruitment1>();
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            while (objReader.Read())
            {
                list.Add(new Recruitment1() {
                    PostId = Convert.ToInt32(objReader["PostId"]),
                    PostName = objReader["PostName"].ToString(),
                    PostType = objReader["PostType"].ToString(),
                    PostPlace = objReader["PostPlace"].ToString(),
                    PostDesc = objReader["PostDesc"].ToString(),
                    PostRequire = objReader["PostRequire"].ToString(),
                    Experience = objReader["Experience"].ToString(),
                    EduBackground = objReader["EduBackground"].ToString(),
                    RequireCount = Convert.ToInt32(objReader["RequireCount"]),
                    PublishTime = Convert.ToDateTime(objReader["PublishTime"]),
                    Manager = objReader["Manager"].ToString(),
                    PhoneNumber = objReader["PhoneNumber"].ToString(),
                    Email = objReader["Email"].ToString()
                
                
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 按序号查询
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public Recruitment1 GetRecruitById(int postId)
        {   
            string sql="select PostId, PostName, PostType, PostPlace, PostDesc, PostRequire, Experience, EduBackground, RequireCount, PublishTime, Manager, PhoneNumber, Email";
            sql += " from Recruitment where PostId=@PostId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@PostId",postId)
            };
            Recruitment1 objRecruit = null;
            SqlDataReader objReader = SQLHelper.GetReader(sql, param);
            if (objReader.Read())
            {
                objRecruit=new Recruitment1()
                {   
                    PostId=Convert.ToInt32(objReader["PostId"]),
                    PostName=objReader["PostName"].ToString(),
                    PostType=objReader["PostType"].ToString(),
                    PostPlace=objReader["PostPlace"].ToString(),
                    PostDesc=objReader["PostDesc"].ToString(),
                    PostRequire=objReader["PostRequire"].ToString(),
                    Experience=objReader["Experience"].ToString(),
                    EduBackground=objReader["EduBackground"].ToString(),
                    RequireCount=Convert.ToInt32(objReader["RequireCount"]),
                    PublishTime=Convert.ToDateTime(objReader["PublishTime"]),
                    Manager = objReader["Manager"].ToString(),
                    PhoneNumber = objReader["PhoneNumber"].ToString(),
                    Email = objReader["Email"].ToString()
                
                };
            
            }
            return objRecruit;
        }

        /// <summary>
        /// 增加发布信息
        /// </summary>
        /// <param name="objRecr"></param>
        /// <returns></returns>
        public int AddRecr(Recruitment1 objRecr)
        {
            string sql = "insert into Recruitment(PostName,PostType,Experience,EduBackground,PostPlace,RequireCount,PublishTime,";
            sql += " PostDesc,PostRequire,Manager,PhoneNumber,Email)";
            sql += " values(@PostName,@PostType,@Experience,@EduBackground,@PostPlace,@RequireCount,@PublishTime,@PostDesc,@PostRequire,@Manager,@PhoneNumber,@Email)";
            SqlParameter[] param = new SqlParameter[] {

                new SqlParameter("@PostName",objRecr.PostName),
                new SqlParameter("@PostType",objRecr.PostType),
                new SqlParameter("@Experience",objRecr.Experience),
                new SqlParameter("@EduBackground",objRecr.EduBackground),
                new SqlParameter("@PostPlace",objRecr.PostPlace),
                new SqlParameter("@RequireCount",objRecr.RequireCount),
                new SqlParameter("@PublishTime",objRecr.PublishTime),
                new SqlParameter("@PostDesc",objRecr.PostDesc),
                new SqlParameter("@PostRequire",objRecr.PostRequire),
                new SqlParameter("@Manager",objRecr.Manager),
                new SqlParameter("@PhoneNumber",objRecr.PhoneNumber),
                new SqlParameter("@Email",objRecr.Email),

            };
            return SQLHelper.Update(sql, param);

        
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public int RecrDel(string postId)
        {
            string sql = "delete from Recruitment where PostId=@PostId";
            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@PostId",postId)
            };
            return SQLHelper.Update(sql, param);
        }


        


    }
}
