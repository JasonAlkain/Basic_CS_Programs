using NewsLetterApp.Models;
using NewsLetterApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterApp.Controllers
{
    public class HomeController : Controller
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            bool isNotValid = string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress);
            if (isNotValid)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {

                /* TODO:
                 * Connect to server database 
                 */
                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                                        (@FirstName, @LastName, @EmailAddress)";

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", System.Data.SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("Success");
            }
        }

    }
}