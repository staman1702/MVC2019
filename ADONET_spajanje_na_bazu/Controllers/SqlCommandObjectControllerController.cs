using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADONET_spajanje_na_bazu.Controllers
{
    public class SqlCommandObjectControllerController : Controller
    {
        // GET: SqlCommandObjectController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            string connString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdTxt = "";
                cmdTxt += "INSERT INTO [dbo].[tblTecajevi] ( [naziv], [opis] )"
                    + "Values ('Web design','Naucite kreirati web stranicu')";

                SqlCommand cmd = new SqlCommand(cmdTxt, conn);
                cmd.Connection.Open();

                int brojRedaka = cmd.ExecuteNonQuery();

                if (brojRedaka > 0)
                {
                    ViewBag.Message = "Zapis je u bazi.";
                }

                else
                {
                    ViewBag.Message = "Zapis nije u bazi.";
                }
            }

            return View("Index");

        }

        public ActionResult Edit()
        {
            string connString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdTxt = "";
                cmdTxt += "UPDATE [dbo].[tblTecajevi] "
                    + "SET " + "[naziv] = 'Web Dev',"
                    + "[opis] = 'Web Development'"
                    + " WHERE [dbo].[tblTecajevi].id=1";

                SqlCommand cmd = new SqlCommand(cmdTxt, conn);
                cmd.Connection.Open();

                int brojRedaka = cmd.ExecuteNonQuery();

                if (brojRedaka > 0)
                {
                    ViewBag.Message = "Zapis je izmjenjen u bazi.";
                }

                else
                {
                    ViewBag.Message = "Zapis nije izmjenjen u bazi.";
                }
            }

            return View("Index");
        }

        public ActionResult Delete()
        {
            string connString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdTxt = "";
                cmdTxt += "DELETE [dbo].[tblTecajevi]"                   
                    + " WHERE [dbo].[tblTecajevi].id=2";

                SqlCommand cmd = new SqlCommand(cmdTxt, conn);
                cmd.Connection.Open();

                int brojRedaka = cmd.ExecuteNonQuery();

                if (brojRedaka > 0)
                {
                    ViewBag.Message = "Zapis je obrisan iz baze.";
                }

                else
                {
                    ViewBag.Message = "Zapis nije obrisan iz baze.";
                }
            }

            return View("Index");
        }

        public ActionResult Count()
        {
            string connString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdTxt = "";
                cmdTxt += "SELECT count(*) FROM [dbo].[tblTecajevi] ";
                   

                SqlCommand cmd = new SqlCommand(cmdTxt, conn);
                cmd.Connection.Open();

                 //vraca prvi redak, u ovom slucaju broj zapisa
                int brojRedaka = (int)cmd.ExecuteScalar();

                if (brojRedaka > 0)
                {
                    ViewBag.Message = "U tablici se nalazi " + brojRedaka + " zapisa";
                }

                else
                {
                    ViewBag.Message = "U tablici nema zapisa!";
                }
            }

            return View("Index");
        }
    }
}