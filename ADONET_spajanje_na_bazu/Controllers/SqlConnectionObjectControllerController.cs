using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ADONET_spajanje_na_bazu.Controllers
{
    public class SqlConnectionObjectControllerController : Controller
    {
        // GET: SqlConnectionObjectController direktno
        public ActionResult Index()
        {
            //prvo smo kreirali conn string 
            string connString = 
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";

            //zatim instanciramo taj conn
            SqlConnection conn = new SqlConnection(connString);

            //kada radimo konekcije sa bazom uvijek radimo try catch blok
            try
            {
                conn.Open();
                if(conn.State == ConnectionState.Open)
                {
                    Response.Write("Konekcija je uspjela.");
                }
            }
            catch (SqlException sqlex)
            {
                Response.Write("greška spajanje na bazu" + sqlex.ToString());
            }

            catch (Exception ex)
            {
                Response.Write("neka greška" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }


            return View();
        }


        // GET: SqlConnectionObjectController preko Web.config
        public ActionResult PrekoWebConfig()
        {

            string connString = ConfigurationManager.ConnectionStrings["dbAlgebraConnString"].ConnectionString;

            
            SqlConnection conn = new SqlConnection(connString);

            
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    Response.Write("Konekcija je uspjela.");
                }
            }
            catch (SqlException sqlex)
            {
                Response.Write("greška spajanje na bazu" + sqlex.ToString());
            }

            catch (Exception ex)
            {
                Response.Write("neka greška" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }


            return View();
        }
    }
}