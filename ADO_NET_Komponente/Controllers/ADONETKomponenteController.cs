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
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";
        public ActionResult List()
        {
            //instanciranje konekcije
            SqlConnection conn = new SqlConnection(ConnStr);
                        
            //string cmdTxt = "";
            //cmdTxt += "SELECT * FROM tblPolaznici";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tblPolaznici";

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
                            lstPolaznici.Add(polaznik);
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

        [HttpGet]
        public ActionResult Details(int idPolaznik)
        {
            SqlConnection conn = new SqlConnection(ConnStr);
            string cmdText = "SELECT * FROM tblPolaznici WHERE"
                +" IdPolaznik=@IdPolaznik";

            SqlCommand cmd = new SqlCommand(cmdText, conn);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@IdPolaznik";
            param.DbType = DbType.Int32;
            param.Direction = ParameterDirection.Input;
            param.Value = idPolaznik;
            cmd.Parameters.Add(param);

            SqlDataReader dr = null;
            Polaznik polaznik = new Polaznik();

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr != null)
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {                       
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
                if (dr != null)
                {
                    dr.Close();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return View(polaznik);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Polaznik());
        }

        [HttpPost]
        public ActionResult Create(Polaznik model)
        {
            string ConnStr =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnStr))
                {
                    string cmdText = "";
                    cmdText += "INSERT INTO tblPolaznici ";
                    cmdText += "(Ime, Prezime, Email) ";
                    cmdText += "VALUES ";
                    cmdText += "('" + model.Ime + "', '"
                        + model.Prezime + "', '" + model.Email + "') ";

                    SqlCommand cmd = new SqlCommand(cmdText, conn);
                    cmd.Connection.Open();

                    int brojDodanihRedaka = cmd.ExecuteNonQuery();
                    ViewBag.Message = "Broj dodanih redaka: " + brojDodanihRedaka;
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

            return View(model);

        }

    }
}