using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using Kisbolt.Kivetelek;
using Kisbolt.Tipusok;

namespace Kisbolt.Modellek
{
    class FelhasznaloKezelo:AbKezelo
    {
        MySqlConnection conn;
        MySqlConnectionStringBuilder connString;

        public static Cegadatok Elfogadva
        {
            get;
            private set;
        }

        static public Cegadatok Beleptetes(AbKezelo abkezelo, string felh, string jelsz)
        {
            // Cegadatok cegadatok = this.Bejelentkezes(felh, jelsz);
            
            Cegadatok cegadatok = Bejelentkezes(abkezelo, felh, jelsz);

            if (cegadatok != null)
            {
                Elfogadva = cegadatok;
            }
            else
            {
                throw new AutentikacioKivetel("Nem megfelelő felhasználónév/jelszó páros!");
            }
            return cegadatok;
        }

        static protected Cegadatok Bejelentkezes(AbKezelo abkezelo, string felh, string jelsz)
        {
            jelsz = Sha512hash.GetHash(jelsz);

            string sql = "SELECT felhasznalo_adatok.*, vevotipusok.VevoTipusNev " +
                "FROM felhasznalo_adatok " +
                "INNER JOIN vevotipusok " +
                "ON felhasznalo_adatok.VevoTipusID = vevotipusok.VevoTipusID " +
                "WHERE FelhNev = @FelhNev AND Jelszo = @Jelszo LIMIT 1";
            
            Cegadatok cegadatok = null;

            using (MySqlCommand cmd = new MySqlCommand(sql, abkezelo.GetConn()))
            {
                cmd.Parameters.AddWithValue("@FelhNev", felh);
                cmd.Parameters.AddWithValue("@Jelszo", jelsz);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cegadatok = new Cegadatok(reader["FelhNev"].ToString(),
                                                    reader["Cegnev"].ToString(),
                                                    reader["Adoszam"].ToString(),
                                                    reader["VevoTipusNev"].ToString());
                    }
                }
            }

            return cegadatok;
        }

        public static bool Autentikalt()
        {
            return (Elfogadva != null);            
        }
    }
}
