﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelQuiz2015
{
    public partial class Question2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Event handler for btnNext_Click
        protected void btnNext_Click(object sender, EventArgs e)
        {
            Session.Add("2", RadioButtonList1.SelectedValue);
            Response.Redirect("Question3.aspx");
        }

    }
}