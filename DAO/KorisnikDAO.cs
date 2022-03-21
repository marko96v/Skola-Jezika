using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SkolaJezikaConsole;
using System.Windows;

namespace SkolaJezikaWPF.DAO
{
    public class KorisnikDAO
    {
        public static void Create(Korisnik k) 
        {
            using (SqlConnection conn = new SqlConnection(Aplikacija.CONN_STR))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Insert into korisnik values (@ime,@prezime,@jmbg,@datum,@kime,@kloz)";

                cmd.Parameters.Add("@ime", k.Ime);
                cmd.Parameters.Add("@prezime", k.Prezime);
                cmd.Parameters.Add("@jmbg", k.JMBG);
                cmd.Parameters.Add("@datum", k.DatumRodjenja);
                cmd.Parameters.Add("@kime", k.KorisnickoIme);
                cmd.Parameters.Add("@kloz", k.Lozinka);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message, "Greska", MessageBoxButton.OK);
                }
            }
        }
        public static void Read() 
        {
            using (SqlConnection conn = new SqlConnection(Aplikacija.CONN_STR))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select * from korisnik";

                SqlDataAdapter sqlDA = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                sqlDA.Fill(ds,"korisnici");

                Console.WriteLine(ds.GetXml());
                foreach (DataRow row in ds.Tables["korisnici"].Rows)
                {
                    Korisnik k = new Korisnik();
                    k.Id = (long) row["ID"];
                    k.Ime = (string) row["Ime"];
                    k.Prezime = (string)row["Prezime"];
                    k.JMBG = (string)row["JMBG"];
                    k.DatumRodjenja = (DateTime)row["Datum_Rodjenja"];
                    k.KorisnickoIme = (string)row["K_Ime"];
                    k.Lozinka = (string)row["K_Loz"];
                    Aplikacija.Instanca.Korisnici.Add(k);
                }

            }
        }
        public static void Update() { }
        public static void Delete() { }
    }
}
