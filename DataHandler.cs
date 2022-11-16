using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;

namespace Prg_2782_Project_1
{
    class DataHandler
    {
        //string conn = @"Data Source=LAPTOP-6ECE23C1\SQLEXPRESS01;Initial Catalog=StudentInfo;Integrated Security=True";
        string conn = @"Data Source=X\SQLEXPRESS;Initial Catalog=StudentInfo;Integrated Security=True";
       
       
        //Students section Form 3
        public DataTable DisplayStudents()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetStudents", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            
        }

        public DataTable SearchStudent(int id)
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spSearchStudent", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void UpdateStudent(int id, string name, string surname, string dob, string gender,string phone, string address, string codes)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdateStudent", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Surname", surname);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(dob));
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Codes", codes);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AddStudent(int id, string name, string surname, string dob, string gender, string phone, string address, string codes)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spAddStudent", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Surname", surname);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(dob));
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Codes", codes);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int id)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudent", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                
                cmd.ExecuteNonQuery();
            }
        }


        //Modules section Form 4
        public DataTable DisplayModule()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetModule", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void AddModule(string modid , string modname , string moddes , string resource)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spAddModule", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ModuleCode", modid);
                cmd.Parameters.AddWithValue("@ModuleName", modname);
                cmd.Parameters.AddWithValue("@ModuleDescription", moddes);
                cmd.Parameters.AddWithValue("@ResourceLink", resource);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateModule(string modid, string modname, string moddes, string resource)
        {
            using(SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdateModule", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ModuleCode", modid);
                cmd.Parameters.AddWithValue("@ModuleName", modname);
                cmd.Parameters.AddWithValue("@ModuleDescription", moddes);
                cmd.Parameters.AddWithValue("@ResourceLink", resource);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteModule(string modid)
        {
            using(SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spDeleteModule", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ModuleCode", modid);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable SearchModule(string modid)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchModule", con);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();

                cmd.Parameters.AddWithValue("@ModuleCode", modid);
                con.Open();

                using ( SqlDataReader dr = cmd.ExecuteReader())
                {
                   dt.Load(dr);
                    return dt;
                }
            }
        }
    }
}

       


       
      
