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
    public class AdminController : Controller
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // GET: Admin
        public ActionResult Index()
        {



            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress FROM SignUps";
            List<NewsLetterSignUp> signUps = new List<NewsLetterSignUp>();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);

            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        var signup = new NewsLetterSignUp();
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();

            //        signUps.Add(signup);
            //    }
            //}
            var signUpVMs = new List<SignUpVM>();

            foreach (var signUp in signUps)
            {
                var su_Vm = new SignUpVM();
                su_Vm.Id = signUp.Id;
                su_Vm.FirstName = signUp.FirstName;
                su_Vm.LastName = signUp.LastName;
                su_Vm.EmailAddress = signUp.EmailAddress;

                signUpVMs.Add(su_Vm);
            }

            //
            return View(signUpVMs);
        }

        public ActionResult Unsubscribe(int Id)
        {
            //using(NewsLetterEntities db = new NewsLetterEntities())
            //{

            //}

            return RedirectToAction("Index");
        }
    }
}