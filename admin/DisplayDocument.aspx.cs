using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace HR_Management_System.admin
{
    public partial class DisplayDocument : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        private void BindGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select Id,fname,lastname,dob,PhotoName,PhotoType, photo, x10Name, X10type, X10 from DocumentUpload";
                    cmd.Connection = con;
                    con.Open();
                    //GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                    con.Close();
                }
            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes;
            string fileName, contentType;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    
                    cmd.CommandText = "select fname, lastname, dob, PhotoName, PhotoType, photo from DocumentUpload where id=@id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["photo"];
                        contentType = sdr["PhotoType"].ToString();
                        fileName = sdr["PhotoName"].ToString();
                    }
                    con.Close();
                }
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
            
            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();


        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes;
            string fileName, contentType;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.CommandText = "select fname, lastname, dob, PhotoName, PhotoType, photo, gender, email, x10Name, X10Type, X10, x12Name, X12Type, X12 from DocumentUpload where id=@id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                       
                        fileName = sdr["x10Name"].ToString();
                        contentType = sdr["X10Type"].ToString();
                        bytes = (byte[])sdr["X10"];
                    }
                    con.Close();
                }
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();

        }

        protected void link_12th_Click(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes;
            string fileName, contentType;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.CommandText = "select fname, lastname, dob, PhotoName, PhotoType, photo, gender, email, x10Name, X10Type, X10, x12Name, X12Type, X12 from DocumentUpload where id=@id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["X12"];
                        contentType = sdr["X12Type"].ToString();
                        fileName = sdr["x12Name"].ToString();
                    }
                    con.Close();
                }
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();

        }

        protected void Link_Graduation_Click(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes;
            string fileName, contentType;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.CommandText = "select fname, lastname, dob, PhotoName, PhotoType, photo, gender, email, x10Name, X10Type, X10, x12Name, X12Type, X12 , GraName, GraType, graduation from DocumentUpload where id=@id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["graduation"];
                        contentType = sdr["GraType"].ToString();
                        fileName = sdr["GraName"].ToString();
                    }
                    con.Close();
                }
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }

        protected void link_degree_Click(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes;
            string fileName, contentType;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.CommandText = "select fname, lastname, dob, PhotoName, PhotoType, photo, gender, email, x10Name, X10Type, X10, x12Name, X12Type, X12 , GraName, GraType, graduation, DeeName, DeeType, Degree from DocumentUpload where id=@id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["Degree"];
                        contentType = sdr["DeeType"].ToString();
                        fileName = sdr["DeeName"].ToString();
                    }
                    con.Close();
                }
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }

        protected void link_postgraduation_Click(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes;
            string fileName, contentType;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.CommandText = "select fname, lastname, dob, PhotoName, PhotoType, photo, gender, email, x10Name, X10Type, X10, x12Name, X12Type, X12 , GraName, GraType, graduation, DeeName, DeeType, Degree, PostName, PostType, Postgraduation from DocumentUpload where id=@id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["Postgraduation"];
                        contentType = sdr["PostType"].ToString();
                        fileName = sdr["PostName"].ToString();
                    }
                    con.Close();
                }
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }

        protected void link_aadharcard_Click(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes;
            string fileName, contentType;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.CommandText = "select fname, lastname, dob, PhotoName, PhotoType, photo, gender, email, x10Name, X10Type, X10, x12Name, X12Type, X12 , GraName, GraType, graduation, DeeName, DeeType, Degree, PostName, PostType, Postgraduation , AadharName, AadharType, Aadharcard from DocumentUpload where id=@id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["Aadharcard"];
                        contentType = sdr["AadharType"].ToString();
                        fileName = sdr["AadharName"].ToString();
                    }
                    con.Close();
                }
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }

        protected void link_pancard_Click(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes;
            string fileName, contentType;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.CommandText = "select fname, lastname, dob, PhotoName, PhotoType, photo, gender, email, x10Name, X10Type, X10, x12Name, X12Type, X12 , GraName, GraType, graduation, DeeName, DeeType, Degree, PostName, PostType, Postgraduation , AadharName, AadharType, Aadharcard, PanName, PanType, pancard from DocumentUpload where id=@id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["pancard"];
                        contentType = sdr["PanType"].ToString();
                        fileName = sdr["PanName"].ToString();
                    }
                    con.Close();
                }
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }

        protected void link_bankpass_Click(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes;
            string fileName, contentType;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.CommandText = "select fname, lastname, dob, PhotoName, PhotoType, photo, gender, email, x10Name, X10Type, X10, x12Name, X12Type, X12 , GraName, GraType, graduation, DeeName, DeeType, Degree, PostName, PostType, Postgraduation , AadharName, AadharType, Aadharcard, PanName, PanType, pancard, BankName, BankType, Bankpass from DocumentUpload where id=@id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["Bankpass"];
                        contentType = sdr["BankType"].ToString();
                        fileName = sdr["BankName"].ToString();
                    }
                    con.Close();
                }
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }
    }
}