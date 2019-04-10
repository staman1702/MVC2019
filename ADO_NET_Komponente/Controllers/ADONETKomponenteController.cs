using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADO_NET_Komponente.Models;

namespace ADO_NET_Komponente.Controllers
{
    public class ADONETKomponenteController : Controller
    {
        //prvo smo kreirali conn string 
        string ConnStr =
            @"Data Source=MISTY\SQLEXPRESS;Initial Catalog = dbAlgebra2; Integrated Security = True";

        public ActionResult List()
        {
            //instanciranje konekcije
            SqlConnection conn = new SqlConnection(ConnStr);
                        
            string cmdTxt = "";
            cmdTxt += "SELECT count(*) FROM [dbo].[tblTecajevi] ";

            SqlCommand cmd = new SqlCommand(cmdTxt, conn);
            cmd.Connection.Open();

            SqlDataReader dr = null;
            List<Polaznik> lstPolaznici = new List<Polaznik>();

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                if(dr !=null)
                {
                    if(dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Polaznik polaznik = new Polaznik();
                            polaznik.IdPolaznik = int.Parse(dr["IdPolaznik"].ToString());
                            polaznik.Ime = dr["Ime"].ToString();
                            polaznik.Prezime = dr["Prezime"].ToString();
                            polaznik.Email = dr["Email"].ToString();
                        }
                    }
                }

            }
            catch (SqlException sqlex)
            {
                ViewBag.Message = "SQL greška:" + sqlex.Message;
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Greška:" + ex.Message;
            }
            finally
            {
                if (dr!=null)
                {
                    dr.Close();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                   
            }
            return View(lstPolaznici);
        }

        
    }
}