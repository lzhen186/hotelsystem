using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Models;

namespace DAL
{
    public class DishesService
    {
        /// <summary>
        /// 查询所有的菜系
        /// </summary>
        /// <returns></returns>
        public List<DishCategory> GetAllCategory()
        {
            string sql = "select CategoryId, CategoryName from DishCategory";
            List<DishCategory> list = new List<DishCategory>();
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            while (objReader.Read())
            {
                list.Add(new DishCategory()
                {
                    CategoryId = Convert.ToInt32(objReader["CategoryId"]),
                    CategoryName = objReader["CategoryName"].ToString()
                });
            }
            objReader.Close();
            return list;        
        }
        /// <summary>
        /// 添加菜品
        /// </summary>
        /// <param name="objDish"></param>
        /// <returns></returns>
        public int AddDish(Dish objDish)
        {
            string sql = "insert into Dishes(DishName, UnitPrice, CategoryId)";
            sql += "values(@DishName, @UnitPrice, @CategoryId);select @@IDENTITY";
            SqlParameter[] paran = new SqlParameter[] { 
              new SqlParameter("@DishName",objDish.DishName),
              new SqlParameter("@UnitPrice",objDish.UnitPrice),
              new SqlParameter("@CategoryId",objDish.CategoryId)            
            };
          return  Convert.ToInt32(SQLHelper.Getsingel(sql, paran));
        }
      /// <summary>
      /// 查询菜品
      /// </summary>
      /// <param name="categoryId"></param>
      /// <returns></returns>
        public List<Dish> GetDish(string categoryId)
        {
            string sql = "select DishId,Dishes.CategoryId,DishName,CategoryName,UnitPrice from Dishes inner join DishCategory on Dishes.CategoryId=DishCategory.CategoryId ";
            List<Dish> list = new List<Dish>();
            SqlDataReader objReader = null;
            if (categoryId == null || categoryId == string.Empty)
            {
                objReader = SQLHelper.GetReader(sql);

            }
            else
            {
                sql += " where Dishes.CategoryId=@CategoryId";
                SqlParameter[] param = new SqlParameter[]
                {
                 new SqlParameter("@CategoryId",categoryId)
                };
                objReader = SQLHelper.GetReader(sql, param);

            }
            while (objReader.Read())
            {
                list.Add(new Dish()
                {
                    DishName = objReader["DishName"].ToString(),
                    UnitPrice = Convert.ToInt32(objReader["UnitPrice"]),
                    CategoryName = objReader["CategoryName"].ToString(),
                    DishId = Convert.ToInt32(objReader["DishId"]),
                    CategoryId=Convert.ToInt32(objReader["CategoryId"])
                });
            }
            objReader.Close();
            return list;
        }


        /// <summary>
        /// 根据菜品编号查询菜品信息
        /// </summary>
        /// <param name="dishId"></param>
        /// <returns></returns>
        public Dish GetDishById(int dishId)
        {
            string sql = "select DishName, UnitPrice, CategoryId from Dishes where DishId=@DishId";
            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@DishId",dishId)
            };
            SqlDataReader objReader = SQLHelper.GetReader(sql, param);
            Dish objDish =new Dish();
            if (objReader.Read())
            { 
                objDish.DishName=objReader["DishName"].ToString();
                objDish.UnitPrice = Convert.ToInt32(objReader["UnitPrice"]);
                objDish.CategoryId = Convert.ToInt32(objReader["CategoryId"]);
            };
            objReader.Close();
            return objDish;
        }

        /// <summary>
        /// 修改菜品信息
        /// </summary>
        /// <param name="objDish">参数是一个菜品实体对象</param>
        /// <returns>受影响行数</returns>
        public int Modify(Dish objDish)
        {
            string sql = "update Dishes set DishName=@DishName,UnitPrice=@UnitPrice,CategoryId=@CategoryId where DishId=@DishId";
            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@DishName",objDish.DishName),
            new SqlParameter("@UnitPrice",objDish.UnitPrice),
            new SqlParameter("@CategoryId",objDish.CategoryId),
            new SqlParameter("@DishId",objDish.DishId)
            };
            return SQLHelper.Update(sql, param);
        }

        /// <summary>
        /// 删除菜品
        /// </summary>
        /// <param name="dishId"></param>
        /// <returns></returns>

        public int DishDel(string dishId)
        {
            string sql = "delete from Dishes where DishId=@DishId";
            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@DishId",dishId)
            };
            return SQLHelper.Update(sql, param);
        }
    }
}
