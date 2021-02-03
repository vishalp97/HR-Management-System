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
    public partial class DocumentUpload : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            con = new SqlConnection(c1.connect().ToString());
            
        }

        protected void btn_sub_Click(object sender, EventArgs e)
        {

            int? Count = null;
            HR_ManagementDataContext dc = new HR_ManagementDataContext();

            //HttpPostedFile filephotos = filephoto.PostedFile;
            //string sfilephto = Path.GetExtension(filephoto.FileName);

           

            HttpPostedFile filephotos = filephoto.PostedFile; string filephotoExt = Path.GetExtension(filephotos.FileName);

            HttpPostedFile file10 = file10th.PostedFile; string file10Ext = Path.GetExtension(file10.FileName);
            HttpPostedFile file12 = file12th.PostedFile; string file12Ext = Path.GetExtension(file12.FileName);
            HttpPostedFile fileGra = fileGraduation.PostedFile; string fileGraExt = Path.GetExtension(fileGra.FileName);
            HttpPostedFile filedegree = fileDegree.PostedFile; string fileDegExt = Path.GetExtension(filedegree.FileName);
            HttpPostedFile filePG = FilePostGraduation.PostedFile; string filePGExt = Path.GetExtension(filePG.FileName);
            HttpPostedFile fileaadhar = Fileaadhar.PostedFile; string fileAAdharExt = Path.GetExtension(fileaadhar.FileName);
            HttpPostedFile filePancad = filePancard.PostedFile; string filePancardExt = Path.GetExtension(filePancad.FileName);
            HttpPostedFile filebankpass = fileBankpass.PostedFile; string fileBankpasExt = Path.GetExtension(filebankpass.FileName);

            //Stream resumeStream = fileRe.InputStream;
            //BinaryReader br1 = new BinaryReader(resumeStream);

            Stream XthStream = file10.InputStream;
            BinaryReader br1 = new BinaryReader(XthStream);

            Stream XIIthStream = file12.InputStream;
            BinaryReader br2 = new BinaryReader(XIIthStream);

            Stream GraStream = fileGra.InputStream;
            BinaryReader br3 = new BinaryReader(GraStream);

            Stream degreeStream = filedegree.InputStream;
            BinaryReader br4 = new BinaryReader(degreeStream);

            Stream PGStream = filePG.InputStream;
            BinaryReader br5 = new BinaryReader(PGStream);

            Stream aadharStream = fileaadhar.InputStream;
            BinaryReader br6 = new BinaryReader(aadharStream);
            
            Stream pancardStream = filePancad.InputStream;
            BinaryReader br7 = new BinaryReader(pancardStream);
            
            Stream bankpassStream = filebankpass.InputStream;
            BinaryReader br8 = new BinaryReader(bankpassStream);

            Stream photoStream = filephotos.InputStream;
            BinaryReader br9 = new BinaryReader(photoStream);

            
            //FOR GET FILE TYPE and file name
            string photocontentType = filephoto.PostedFile.ContentType;
            string photofilename = Path.GetFileName(filephoto.PostedFile.FileName);

            string XcontentType = file10th.PostedFile.ContentType;
            string Xfilename = Path.GetFileName(file10th.PostedFile.FileName);

            string XIIcontentType = file12th.PostedFile.ContentType;
            string XIIfilename = Path.GetFileName(file12th.PostedFile.FileName);

            string GracontentType = fileGraduation.PostedFile.ContentType;
            string Grafilename = Path.GetFileName(fileGraduation.PostedFile.FileName);
           
            string DeecontentType = fileDegree.PostedFile.ContentType;
            string Deefilename = Path.GetFileName(fileDegree.PostedFile.FileName);

            string postcontentType = FilePostGraduation.PostedFile.ContentType;
            string postfilename = Path.GetFileName(FilePostGraduation.PostedFile.FileName);

            string aacontentType = Fileaadhar.PostedFile.ContentType;
            string aafilename = Path.GetFileName(Fileaadhar.PostedFile.FileName);

            string pancontentType = filePancard.PostedFile.ContentType;
            string panfilename = Path.GetFileName(filePancard.PostedFile.FileName);

            string bnkcontentType = fileBankpass.PostedFile.ContentType;
            string bnkfilename = Path.GetFileName(fileBankpass.PostedFile.FileName);

            try
            {
                //if (fileRExt == ".pdf" || fileRExt == ".doc" && fileXExt == ".pdf" || fileXExt == ".doc" && fileXIIExt == ".pdf" || fileXIIExt == ".doc" && fileGraExt == ".pdf" || fileGraExt == ".doc" && fileAdExt == ".pdf" || fileAdExt == ".doc" && filePExt == ".pdf" || filePExt == ".doc" && fileExt == ".jpg" || fileExt == ".png")
                //{
                //string imgName = SelectedFile.FileName;
                //   string folderPath = Server.MapPath("~/Images/");
                //   if (Directory.Exists(folderPath) == false)
                //   {
                //       Directory.CreateDirectory(folderPath);
                //   }
                //   SelectedFile.SaveAs(folderPath + imgName);
                //.ImageUrl = "~/Images/" + imgName;
                // binary conversion of photo by using Binaryreader class

                //BinaryReader br = new BinaryReader(SelectedFile.InputStream);
                //byte[] imgData = br.ReadBytes(SelectedFile.ContentLength);

                //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                //using (SqlConnection con = new SqlConnection(constr))
                //{
                //    string query = "insert into DocumentUpload values (@fname,@lastname,@dob,@photo,@gender,@email,@X10,@X12,@graduation,@degree,@postgraduation,@aadharcard,@pancard,@bankpass)";
                //    using (SqlCommand cmd = new SqlCommand(query))
                //    {
                //        cmd.Connection = con;
                //        cmd.Parameters.AddWithValue("@fname", txt_nm.Text);
                //        cmd.Parameters.AddWithValue("@lastname", txt_lnm.Text);
                //        cmd.Parameters.AddWithValue("@dob", txt_dob.Text);
                //        cmd.Parameters.AddWithValue("@photo", br9.ReadBytes((Int32)photoStream.Length));
                //        cmd.Parameters.AddWithValue("@gender", DropDownList1.SelectedIndex);
                //        cmd.Parameters.AddWithValue("@X10", br1.ReadBytes((Int32)XthStream.Length));
                //        cmd.Parameters.AddWithValue("@X12", br2.ReadBytes((Int32)XIIthStream.Length));
                //        cmd.Parameters.AddWithValue("@graduation", br3.ReadBytes((Int32)GraStream.Length));
                //        cmd.Parameters.AddWithValue("@degree", br4.ReadBytes((Int32)degreeStream.Length));
                //        cmd.Parameters.AddWithValue("@postgraduation", br5.ReadBytes((Int32)PGStream.Length));
                //        cmd.Parameters.AddWithValue("@aadharcard", br6.ReadBytes((Int32)aadharStream.Length));
                //        cmd.Parameters.AddWithValue("@pancard", br7.ReadBytes((Int32)pancardStream.Length));
                //        cmd.Parameters.AddWithValue("@bankpass", br8.ReadBytes((Int32)bankpassStream.Length));
                       
                //        con.Open();
                //        cmd.ExecuteNonQuery();
                //        con.Close();
                //    }
                //}


                var count = dc.DocumentUpload_Insert(txt_nm.Text,txt_lnm.Text,txt_dob.Text,photofilename,photocontentType, br9.ReadBytes((Int32)photoStream.Length), DropDownList1.SelectedValue, txt_email.Text,
                  Xfilename,XcontentType,  
                  br1.ReadBytes((Int32)XthStream.Length),
                  
                  XIIfilename,XIIcontentType,
                  br2.ReadBytes((Int32)XIIthStream.Length),
                  
                  Grafilename,GracontentType,
                  br3.ReadBytes((Int32)GraStream.Length),
                  
                  Deefilename,DeecontentType,
                  br4.ReadBytes((Int32)degreeStream.Length),
                  
                  postfilename,postcontentType,
                  br5.ReadBytes((Int32)PGStream.Length),
                  
                  aafilename,aacontentType,
                  br6.ReadBytes((Int32)aadharStream.Length),
                  
                  panfilename, pancontentType,
                  br7.ReadBytes((Int32)pancardStream.Length),

                  bnkfilename, bnkcontentType,
                  br8.ReadBytes((Int32)bankpassStream.Length), ref Count);
                 

                //    Response.Redirect("https://localhost:44393/SendMail.aspx");



                //    Response.Write("<script>alert('Selected file format is not supported.')</script>");



            }
            
            catch (Exception ex)
            {
                Response.Write("You are getting error " + ex + " Please try again ..");
            }





        }
    }
}