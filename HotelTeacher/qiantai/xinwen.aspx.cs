﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace HotelTeacher.qiantai
{
    public partial class xinwen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Repeater1.DataSource = new NewService().GetNewes();
            this.Repeater1.DataBind();

        }
    }
}