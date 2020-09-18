using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Models;

namespace DAL
{
     public class NewService
    {
         
         /// <summary>
         /// 添加新闻
         /// </summary>
         /// <param name="objNew"></param>
         /// <returns></returns>
         public int AddNews(News1 objNew) 
         {
             string sql = "insert into dbo.News (NewsTitle, NewsContents,CategoryId)values(@NewsTitle, @NewsContents,@CategoryId)";
             SqlParameter[] param = new SqlParameter[]
             {
             new SqlParameter("@NewsTitle",objNew.NewsTitle),
             new SqlParameter("@NewsContents",objNew.NewsContents),
             new SqlParameter("@CategoryId",objNew.CategoryId)
             };
             return SQLHelper.Update(sql,param);
         }
         /// <summary>
         /// 修改新闻
         /// </summary>
         /// <param name="objNew"></param>
         /// <returns></returns>
         public int ModifyNew(News1 objNew) 
         {
             string sql = "update dbo.News set NewsTitle=@NewsTitle, NewsContents=@NewsContents,CategoryId=@CategoryId where NewsId=@NewsId";
             SqlParameter[] param = new SqlParameter[]
             {
             new SqlParameter("@NewsTitle",objNew.NewsTitle),
             new SqlParameter("@NewsContents",objNew.NewsContents),
             new SqlParameter("@CategoryId",objNew.CategoryId),
             new SqlParameter("@NewsId",objNew.NewsId)
             };
             return SQLHelper.Update(sql, param);
         }
         /// <summary>
         /// 根据新闻编号删除新闻
         /// </summary>
         /// <param name="newId"></param>
         /// <returns></returns>
         public int DelNew(string newId) 
         {
             string sql = "delete from News where NewsId=@NewsId";
             SqlParameter[] param = new SqlParameter[]
             {
             new SqlParameter("@NewsId",newId)
             };
             return SQLHelper.Update(sql, param);
         }

         /// <summary>
         /// 查询所有新闻
         /// </summary>
         /// <param name="count"></param>
         /// <returns></returns>
         public List<News1> GetNews(string count)
         {
             string sql = "select top @count NewsId, NewsTitle, NewsContents, PublishTime, News.CategoryId,categoryName from News";
             sql += " inner join NewsCategory on NewsCategory.CategoryId=News.CategoryId order by PublishTime Desc";
             List<News1> list = new List<News1>();
             SqlParameter[] param = new SqlParameter[]
             {
                  new SqlParameter("@count",count)
             };
             SqlDataReader objReader = SQLHelper.GetReader(sql,param);
             while (objReader.Read())
             {
                 list.Add(new News1()
                 {
                     NewsContents = objReader["NewsContents"].ToString(),
                     NewsTitle = objReader["NewsTitle"].ToString(),
                     NewsId = Convert.ToInt32(objReader["NewsId"]),
                     PublishTime = Convert.ToDateTime(objReader["PublishTime"]),
                     CategoryId = Convert.ToInt32(objReader["CategoryId"]),
                     CategoryName = objReader["CategoryName"].ToString()
                 });
             }
             objReader.Close();
             return list;
         }
         /// <summary>
         /// 根据新闻编号查询新闻具体内容
         /// </summary>
         /// <param name="newId"></param>
         /// <returns></returns>
         public News1 GetNewsbyId(string newId)
         {
             string sql="select  NewsTitle, NewsContents,CategoryId from News where NewsId=@NewsId";
             SqlParameter[] param = new SqlParameter[]
             {
                 new SqlParameter("@NewsId",newId)
             };
             News1 objNew = null;
             SqlDataReader objReader = SQLHelper.GetReader(sql, param);
             if (objReader.Read())
             {
                 objNew = new News1()
                 {
                     NewsContents = objReader["NewsContents"].ToString(),
                     NewsTitle = objReader["NewsTitle"].ToString(),
                     CategoryId = Convert.ToInt32(objReader["CategoryId"])
                 };
             }
             objReader.Close();
             return objNew;
         }



         public List<News1> GetNewes()
         {
             string sql = "select NewsId, NewsTitle, NewsContents, PublishTime, CategoryId from News order by PublishTime Desc";

             List<News1> list = new List<News1>();
             SqlDataReader objReader = SQLHelper.GetReader(sql);
             while (objReader.Read())
             {
                 list.Add(new News1()
                 {
                     NewsId = Convert.ToInt32(objReader["NewsId"]),
                     NewsTitle = objReader["NewsTitle"].ToString(),
                     NewsContents = objReader["NewsContents"].ToString(),
                     PublishTime = Convert.ToDateTime(objReader["PublishTime"]),
                     CategoryId = Convert.ToInt32(objReader["CategoryId"])


                 });
             }
             objReader.Close();
             return list;
         }
    }
}
