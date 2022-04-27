using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;



namespace LaEnterpriseInternational
{
    public partial class WelcomePeople : System.Web.UI.Page
    {
        static string connectionString = getConnectionString();
        private OleDbConnection myConnection = new OleDbConnection(connectionString);
        private OleDbTransaction objTrans;

        const string FILE_NAME = "LaGroup.accdb";
        public static string getConnectionString()
        {
            string location = HttpContext.Current.Server.MapPath("~/App_Data/" + FILE_NAME);
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0 ; data source=" + location;

            return ConnectionString;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        void buttonSubmit_Click(Object sender,
                               EventArgs e)
        {
            // When the button is clicked,
            // change the button text, and disable it.

           }

        protected void buttonSubmit_Click1(object sender, EventArgs e)
        {
            Response.Write("hi " + name.Value.ToString()+"!");

            OleDbCommand objCmd = new OleDbCommand("insertSubscriber", myConnection);
            objCmd.CommandType = CommandType.StoredProcedure;
            OleDbParameter objParam;


            objParam = objCmd.Parameters.Add("@Email", OleDbType.BSTR);
            objParam.Direction = ParameterDirection.Input;
            objParam.Value = email.Value;

            objParam = objCmd.Parameters.Add("@Name", OleDbType.BSTR);
            objParam.Direction = ParameterDirection.Input;
            objParam.Value = name.Value;


            try
            {

                this.myConnection.Open();
                objCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.myConnection.Close();
            }
        }

        // Display the greeting label text.

    }
}