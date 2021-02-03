using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

namespace HR_Management_System
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        Boolean f = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            con = new SqlConnection(c1.connect().ToString());
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
                    cmd.CommandText = "select id, Name from tbl";
                    cmd.Connection = con;
                    con.Open();
                    //GridView1.DataSource = cmd.ExecuteReader();
                    //GridView1.DataBind();
                    con.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            string gen;
#pragma warning restore CS0219 // Variable is assigned but its value is never used

            if (RadioButton1.Checked == false)
            {
                gen = "Female";
            }
            else
            {
                gen = "Male";
            }

            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);

            string contentType = FileUpload1.PostedFile.ContentType;
           
            using (Stream fs = FileUpload1.PostedFile.InputStream)
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bytes = br.ReadBytes((Int32)fs.Length);
                    string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        string query = "insert into Register values (@Name, @Gender, @Position, @Work_as, @Start_Date, @End_Date, @Mobile, @Email, @Address, @Resume, @Data)";
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@Name", txt_nm.Text);
                            cmd.Parameters.AddWithValue("@Gender", gen);
                            cmd.Parameters.AddWithValue("@Position", txt_position.Text);
                            cmd.Parameters.AddWithValue("@Work_as", DropDownList1.SelectedItem.Value);
                            cmd.Parameters.AddWithValue("@Start_Date", txt_strdate.Text);
                            cmd.Parameters.AddWithValue("@End_Date", txt_enddate.Text);
                            cmd.Parameters.AddWithValue("@Mobile", txt_mob.Text);
                            cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                            cmd.Parameters.AddWithValue("@Address", txt_add.Text);
                            cmd.Parameters.AddWithValue("@Resume", filename);
                            cmd.Parameters.AddWithValue("@Data", bytes);

                            //cmd.Parameters.AddWithValue("@ContentType", contentType);
                            //cmd.Parameters.AddWithValue("@Data", bytes);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }
            Response.Redirect(Request.Url.AbsoluteUri);

            //if (FileUpload1.HasFile == false)
            //{
            //    ScriptManager.RegisterStartupScript(this, this.GetType(), "aleartMessage", "javascript:alert('Please select file')", true);
            //}
            //else
            //{
            //    string filename1 = Path.GetFileName(FileUpload1.PostedFile.FileName);
            //    string filename_1 = FileUpload1.FileName;
            //    //FileUpload1.SaveAs(Server.MapPath("~/admin/" + filename_1));
            //    FileUpload1.SaveAs(Server.MapPath("~/") + filename1);
            //    //FileUpload1.SaveAs(@"C:\temp\" + FileUpload1.FileName);

            //    //string filename2 = Path.GetFileName(FileUpload2.PostedFile.FileName);
            //    //string filename_2 = FileUpload2.FileName;
            //    //FileUpload2.SaveAs(Server.MapPath("~/" + FileUpload2.FileName));


            //    string query = "insert into try1 values (@Name, @Resume, @10th)";
            //    using (SqlCommand cmd = new SqlCommand(query))
            //    {
            //        cmd.Connection = con;
            //        cmd.Parameters.AddWithValue("@Name", txt_nm.Text);
            //        cmd.Parameters.AddWithValue("@Resume", filename1);

            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        FileUpload1.Dispose();

            //        con.Close();
            //    }

            //con.Open();

            //cmd = new SqlCommand("insert into try1 values('" + txt_nm.Text + "','" + filename1 + "','" + filename2 + "')", con);
            //cmd.ExecuteNonQuery();
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "aleartMessage", "javascript:alert('Record inserted Successfully')", true);
            //txt_nm.Text = "";

            //FileUpload1.Dispose();
            //FileUpload2.Dispose();






            //con.Close();



        }
    }
}
