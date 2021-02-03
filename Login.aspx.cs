using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace HR_Management_System
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd, cmd1, cmd2;
        SqlDataAdapter da;
        Boolean f = false;

        

        IDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            con = new SqlConnection(c1.connect().ToString());
        }
        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_unm.Text) && string.IsNullOrWhiteSpace(txt_pas.Text))
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "aleartMessage", "javascript:alert('Please enter username and password')", true);
                txt_unm.Focus();

            }
            else
            {
                if (txt_unm.Text != "")
                {
                    if (txt_pas.Text != "")
                    {
                        con.Open();
                        cmd = new SqlCommand("select *from Login ", con);
                        dr = cmd.ExecuteReader();
                        int temp = 0;

                        while (dr.Read())
                        {
                            if (txt_unm.Text == dr["unm"].ToString() && txt_pas.Text == dr["pass"].ToString())
                            {
                                temp = 1;
                                Session["unm"] = dr["id"].ToString();
                            }
                            if (txt_unm.Text != dr["unm"].ToString() && txt_pas.Text == dr["pass"].ToString())
                            {
                                temp = 2;
                            }
                            if (txt_unm.Text == dr["unm"].ToString() && txt_pas.Text != dr["pass"].ToString())
                            {
                                temp = 3;
                            }
                        }
                        if (temp == 1)
                        {


                            Session["unm"] = txt_unm.Text;
                            txt_pas.Text = "";
                            txt_unm.Text = "";
                            //Response.Redirect("~/Home.aspx");
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "aleartMessage", "javascript:alert('Login Sucessfull')", true);
                            Session.RemoveAll();

                        }

                        else if (temp == 2)
                        {

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "aleartMessage", "javascript:alert('Please enter correct username')", true);
                            txt_unm.Text = "";

                        }
                        else if (temp == 3)
                        {

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "aleartMessage", "javascript:alert('Please enter correct password')", true);
                            txt_unm.Text = "";


                        }
                        else if (temp == 0)
                        {

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "aleartMessage", "javascript:alert('Incorrect username & password')", true);
                            txt_pas.Text = "";
                            txt_unm.Text = "";

                        }
                    }
                    else
                    {

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "aleartMessage", "javascript:alert('Please enter password')", true);
                        txt_unm.Text = "";

                        txt_pas.Focus();
                    }
                }
                else
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "aleartMessage", "javascript:alert('Please enter username')", true);
                    txt_pas.Text = "";

                    txt_unm.Focus();

                }
            }
            con.Close();
        }
    }
}