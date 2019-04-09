using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADONET_spajanje_na_bazu.Models;

namespace ADONET_spajanje_na_bazu.Controllers
{
    public class DataReaderObjectController : Controller
    {
        // GET: DataReaderObject
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Read()
        {
            string connString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";

            //priprema prazne liste za kasniji ispis
            List<Tecaj> lstTecaj = new List<Tecaj>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdTxt = "";
                cmdTxt += "SELECT (*) FROM [dbo].[tblTecajevi] ";


                SqlCommand cmd = new SqlCommand(cmdTxt, conn);
                cmd.Connection.Open();

                //vraca prvi redak, u ovom slucaju broj zapisa
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Tecaj t1 = new Tecaj();
                        t1.Id = (int)reader["id"];
                        t1.Naziv = (string)reader["naziv"];
                        t1.Opis = (string)reader["opis"];

                        lstTecaj.Add(t1);
                    }
                }


                else
                {
                    ViewBag.Message = "U tablici nema zapisa!";
                }


                return View("Index", lstTecaj);
            }
        }

    }
}