using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OLXProject.Models
{
    public class RegistrationRepo
    {
        private SqlConnection con;

        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            con = new SqlConnection(constr);

        }

        public void InsertUser(RegistrationModel obj)
        {
            connection();
            SqlCommand cmd = new SqlCommand("Users", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@firstName", obj.firstName);
            cmd.Parameters.AddWithValue("@lastName", obj.lastName);
            cmd.Parameters.AddWithValue("@userEmail", obj.userEmail);
            cmd.Parameters.AddWithValue("@MobileNo", obj.MobileNo);
            cmd.Parameters.AddWithValue("@Address", obj.Address);
            cmd.Parameters.AddWithValue("@City", obj.City);
            cmd.Parameters.AddWithValue("@Gender", obj.Gender);
            cmd.Parameters.AddWithValue("@Password", obj.Password);
            cmd.Parameters.AddWithValue("@Role", obj.Role);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }

}

