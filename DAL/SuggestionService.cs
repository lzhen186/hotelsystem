using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Models;


namespace DAL
{
    public class SuggestionService
    {

        /// <summary>
        /// 查看投诉信息
        /// </summary>
        /// <returns></returns>
        public List<Suggestion> GetSuggest()
        {
            string sql = "select SuggestionId,CustomerName, ConsumeDesc, SuggestionDesc, SuggestTime, PhoneNumber, Email, StatusId from Suggestion";
            sql += "  where StatusId=0 or StatusId=1 order by SuggestTime desc";
            List<Suggestion> list = new List<Suggestion>();
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            while (objReader.Read())
            {
                list.Add(new Suggestion()
                {
                    SuggestionId = Convert.ToInt32(objReader["SuggestionId"]),
                    CustomerName = objReader["CustomerName"].ToString(),
                    ConsumeDesc = objReader["ConsumeDesc"].ToString(),
                    SuggestionDesc = objReader["SuggestionDesc"].ToString(),
                    SuggestTime = Convert.ToDateTime(objReader["SuggestTime"]),
                    PhoneNumber = objReader["PhoneNumber"].ToString(),
                    Email = objReader["Email"].ToString(),
                    StatusId = Convert.ToInt32(objReader["StatusId"])



                });
            }
                    objReader.Close();
                    return list;
        }
 
        }
    }

