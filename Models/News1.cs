using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// 新闻类
    /// </summary>
  public class News1
    {
       public int NewsId { get; set; }
       public string NewsTitle { get; set; }
	   public string NewsContents { get; set; }
	   public DateTime PublishTime { get; set; }
	   public int CategoryId { get; set; }
      //扩展属性
       public string CategoryName { get; set; }

	 
    }
}
