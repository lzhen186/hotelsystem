using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Models;

namespace DAL
{
   public class DIshBookService
    {
       /// <summary>
       /// 查询预订信息
       /// </summary>
       /// <returns></returns>
       public List<DishBook> GerDishBook()
       {
           string sql = "select BookId, HotelName, ConsumeTime, ConsumePersons, RoomType, CustomerName, CustomerPhone, CustomerEmail, Comments, BookTime, OrderStatus";
           sql += "  from DishBook where OrderStatus=0 or OrderStatus=1 order by BookTime desc";
           List<DishBook> list = new List<DishBook>();
           SqlDataReader objReader = SQLHelper.GetReader(sql);
           while (objReader.Read())
           {
               list.Add(new DishBook() {
                   BookId = Convert.ToInt32(objReader["BookId"]),
                   HotelName = objReader["HotelName"].ToString(),
                   ConsumeTime = Convert.ToDateTime(objReader["ConsumeTime"]),
                   ConsumePersons = Convert.ToInt32(objReader["ConsumePersons"]),
                   RoomType = objReader["RoomType"].ToString(),
                   CustomerName = objReader["CustomerName"].ToString(),
                   CustomerPhone = objReader["CustomerPhone"].ToString(),
                   CustomerEmail = objReader["CustomerEmail"].ToString(),
                   Comments = objReader["Comments"].ToString(),
                   BookTime = Convert.ToDateTime(objReader["BookTime"]),
                   OrderStatus = Convert.ToInt32(objReader["OrderStatus"])
               });
           }
           objReader.Close();
           return list;
       
       }

       /// <summary>
       /// 更改状态信息
       /// </summary>
       /// <param name="bookId">要更改记录的Id</param>
       /// <param name="orderStatus">要更改为的状态</param>
       /// <returns></returns>
       public int ModifyOrderStatus(string bookId,string orderStatus)
       {
           string sql = "update DishBook  set OrderStatus=@OrderStatus  where BookId=@BookId";
           SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@OrderStatus",orderStatus),
                new SqlParameter("@BookId",bookId)
           };
           return SQLHelper.Update(sql, param);
       
       }

        /// <summary>
        /// 增加预订
        /// </summary>
        /// <param name="objDishBook"></param>
        /// <returns></returns>
       public int AddBook(DishBook objDishBook)
       {
           string sql = "insert into DishBook(HotelName, ConsumeTime, ConsumePersons, RoomType, CustomerName, CustomerPhone, CustomerEmail, Comments)";
           sql += "  values(@HotelName, @ConsumeTime, @ConsumePersons, @RoomType, @CustomerName, @CustomerPhone, @CustomerEmail, @Comments) ";
           SqlParameter[] param = new SqlParameter[] {
           
              new SqlParameter("@HotelName",objDishBook.HotelName),
              new SqlParameter("@ConsumeTime",objDishBook.ConsumeTime),
              new SqlParameter("@ConsumePersons",objDishBook.ConsumePersons),
              new SqlParameter("@RoomType",objDishBook.RoomType),
              new SqlParameter("@CustomerName",objDishBook.CustomerName),           
              new SqlParameter("@CustomerPhone",objDishBook.CustomerPhone),           
              new SqlParameter("@CustomerEmail",objDishBook.CustomerEmail),           
              new SqlParameter("@Comments",objDishBook.Comments)
           };
           return SQLHelper.Update(sql, param);
       
       
       }


    }
}
