﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Error : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Error"] != null)
                mensajeDeError.InnerText = Session["Error"].ToString();
        }


        protected void volverInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);
        }

        protected void volverAlInicio_Click(object sender, EventArgs e)
        {
            Session.Remove("Error");
            Response.Redirect("InicioClientes.aspx", false);
        }

    }
}