using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace HR_Management_System.admin
{
    public partial class Admin : System.Web.UI.Page
    {
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            con = new SqlConnection(c1.connect().ToString());

            if (!Page.IsPostBack)
            {
                BindEmpGrid();
            }
        }
        protected void BindEmpGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from Register", con);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            //GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DownloadFile(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

            //int id = int.Parse((sender as LinkButton).CommandArgument);
            //byte[] bytes;
            //string filename;
            //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        cmd.CommandText = "select Resume, Data from Register where id=@id";
            //        cmd.Parameters.AddWithValue("@id", id);
            //        cmd.Connection = con;
            //        con.Open();
            //        using (SqlDataReader sdr = cmd.ExecuteReader())
            //        {
            //            sdr.Read();
                      
            //            //contenttype = sdr["contenttype"].tostring();
            //            filename = sdr["Resume"].ToString();
            //            bytes = (byte[])sdr["Data"];
            //        }
            //        con.Close();
            //    }
            //}
            //Response.Clear();
            //Response.Buffer = true;
            //Response.Charset = "";
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);
            ////Response.ContentType = contentType;
            //Response.AppendHeader("Content-Disposition", "attachment; filename=" + filename);
            //Response.BinaryWrite(bytes);
            //Response.Flush();
            //Response.End();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            ////int id = int.Parse((sender as LinkButton).CommandArgument);
            
            //byte[] bytes;
            ////string fileName, contentType;
            //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        cmd.CommandText = "select Data from Register where id=@id";
            //        //cmd.Parameters.AddWithValue("@id", id);
            //        cmd.Connection = con;
            //        con.Open();
            //        using (SqlDataReader sdr = cmd.ExecuteReader())
            //        {
            //            sdr.Read();
            //            bytes = (byte[])sdr["Data"];
            //            //contenttype = sdr["contenttype"].tostring();
            //            //filename = sdr["name"].tostring();
            //        }
            //        con.Close();
            //    }
            //}
            //Response.Clear();
            //Response.Buffer = true;
            //Response.Charset = "";
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //Response.ContentType = contentType;
            //Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
            //Response.BinaryWrite(bytes);
            //Response.Flush();
            //Response.End();
        }

        string empId = string.Empty;
        string name,position,startdate,workas;
        
        protected void btn_sent_Click(object sender, EventArgs e)
        {

            

            DataTable dt = new DataTable();
            try
            {
                foreach (GridViewRow row in GridView1.Rows)
                {
                    CheckBox cb = (CheckBox)row.FindControl("chkSelect");

                    if (cb.Checked == true)
                    {
                        if (cb != null && cb.Checked)
                        {


                            //get Current EMAIL_ID from the DataKey
                            empId = Convert.ToString(GridView1.DataKeys[row.RowIndex].Value);

                            SqlCommand cmd = new SqlCommand("select Email,Name,Position,Start_Date,Work_as from Register where id=" + empId + "", con);
                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            //Fill datatable with EMAIL_ID corresponding to Current EMP_ID
                            adp.Fill(dt);
                            //Get EMAIL_ID into variable
                            string emailId = dt.Rows[0]["Email"].ToString();
                            name = dt.Rows[0]["Name"].ToString();
                            position = dt.Rows[0]["Position"].ToString();
                            startdate = dt.Rows[0]["Start_Date"].ToString();
                            workas = dt.Rows[0]["Work_as"].ToString();
                            //write code to send mail
                            SendEmailUsingGmail(emailId);
                            dt.Clear();
                            dt.Dispose();

                            //for update data
                            //int eid = Convert.ToInt32(row.Cells[1].Text);
                            //updaterow(eid, "Yes");
                            //**********************************************************
                            //SqlDataSource1.DataBind();
                            //GridView1.DataSource = SqlDataSource1;
                            //GridView1.DataBind();
                        }


                    }
                }
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('Emails sent successfully');", true);
            }
            catch (Exception ex)
            {
                Response.Write("Error occured: " + ex.Message.ToString());

            }
            finally
            {
                empId = string.Empty;
            }

        }


        private void SendEmailUsingGmail(string toEmailAddress)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential("vishalparmar16297@gmail.com", "Pvishal@1620");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                MailMessage message = new MailMessage();
                message.From = new MailAddress("vishalparmar16297@gmail.com");
                message.To.Add(toEmailAddress);
                message.Subject = "Congratulations | Offer- Internship | Innerwork Solution Pvt.Ltd";

                message.Body = "Dear " + name + ", " + Environment.NewLine + Environment.NewLine + "Innerwork Solutions Pvt Ltd is pleased to offer you a corporate internship opportunity" + Environment.NewLine + " as a " + position + "\t" + workas + "." + Environment.NewLine + "You will report directly to Mr. Navneet Raj.You are authorized to work from any" + Environment.NewLine + "location during this internship."
                + Environment.NewLine + Environment.NewLine + "As you will be receiving academic credit for this position, you will get stipend based on your performance." + Environment.NewLine + Environment.NewLine + "Your schedule will be approximately 40 hours per week beginning " + startdate + Environment.NewLine +
                 "This program is for aperiod of 180 days." + Environment.NewLine + Environment.NewLine + "Congratulations and welcome to the team! " + Environment.NewLine + Environment.NewLine +"Upload document using below link for further processing :)"+ Environment.NewLine + $"https://localhost:44350/admin/DocumentUpload.aspx" + Environment.NewLine+ Environment.NewLine +
                "Sincerely," + Environment.NewLine + "For, Innerwork Solutions Pvt Ltd." + Environment.NewLine +
                 "Ansu Hanna Biji" + Environment.NewLine + "HR Manager";


                smtp.Send(message);
            }
            catch (Exception ex)
            {
                Response.Write("Error occured: " + ex.Message.ToString());
            }
        }
    }
}