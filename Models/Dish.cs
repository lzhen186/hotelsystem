using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// 菜品类
    /// </summary>
   public class Dish
    {
       public int DishId { get; set; }
       public string DishName { get; set; }
	   public decimal UnitPrice { get; set; }
	   public int CategoryId { get; set; }
       //扩展属性
       public string CategoryName { get; set; }


    }
}
