using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using Kisbolt.Tipusok;

namespace Kisbolt.Modellek
{
    class AbKezelo
    {
        MySqlConnection conn;
        MySqlConnectionStringBuilder connString;

        public AbKezelo()
        {
            connString = new MySqlConnectionStringBuilder();
            connString.Server = "localhost";
            connString.Database = "kisbolt";
            connString.UserID = "root";
            connString.Password = "";
            //server=localhost;database=kisbolt;user id=root;password=
            //Console.WriteLine(connString.ConnectionString);

            try
            {
                conn = new MySqlConnection(connString.ConnectionString);
                conn.Open();
            } catch(MySqlException ex)
            {
                string datum = DateTime.Now.ToString();

                File.AppendAllText("mysql.log", 
                    $"A következő hiba lépett fel " +
                    $"az adatbázishoz való kapcsolódás során: " +
                    $"{ex.Message} \n {datum} \n");
            }
        }

        public MySqlConnection GetConn()
        {
            return conn;
        }

        protected void KategoriaFelvitel(TermekKategoria kategoria)
        {
            string sql = "INSERT INTO termekkategoriak " +
                "(KategoriaNev) VALUES(@KategoriaNev)";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@KategoriaNev", kategoria.kategoriaNev);
                cmd.ExecuteNonQuery();
            }
        }

        public List<TermekKategoria> KategoriaLista()
        {
            List<TermekKategoria> kategoriaLista = new List<TermekKategoria>();
            string sql = "SELECT * FROM termekkategoriak";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int kategoriaID = Convert.ToInt32(reader["KategoriaID"]);
                        string kategoriaNev = reader["KategoriaNev"].ToString();

                        TermekKategoria tk = new TermekKategoria(kategoriaID, kategoriaNev);
                        kategoriaLista.Add(tk);
                    }
                }
            }

            return kategoriaLista;
        }

        public void KategoriaTorles(int kategoriaID)
        {
            string sql = "DELETE FROM termekkategoriak " +
                "WHERE KategoriaID = @KategoriaID";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@KategoriaID", kategoriaID);
                cmd.ExecuteNonQuery();
            }
        }

        protected void KategoriaFeluliras(TermekKategoria tk)
        {
            string sql = "UPDATE termekkategoriak " +
                "SET KategoriaNev = @KategoriaNev " +
                "WHERE KategoriaID = @KategoriaID";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@KategoriaNev", tk.kategoriaNev);
                cmd.Parameters.AddWithValue("@KategoriaID", tk.kategoriaID);
                cmd.ExecuteNonQuery();
            }
        }

        public TermekKategoria Kategoria(int kategoriaID)
        {
            TermekKategoria tk = new TermekKategoria("");
            string sql = "SELECT * FROM termekkategoriak " +
                "WHERE KategoriaID = @KategoriaID";
            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@KategoriaID", kategoriaID);

                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["KategoriaID"]);
                        string kategoriaNev = reader["KategoriaNev"].ToString();
                        tk = new TermekKategoria(ID, kategoriaNev);
                    }
                }
            }

            return tk;
        }

        protected void TermekFelvitel(Termek termek)
        {
            string sql = "INSERT INTO termekek " +
                "(TermekNev, KategoriaID, Ar, Egyseg) " +
                "VALUES(@TermekNev, @KategoriaID, @Ar, @Egyseg)";
            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TermekNev", termek.termekNev);
                cmd.Parameters.AddWithValue("@KategoriaID", termek.kategoriaID);
                cmd.Parameters.AddWithValue("@Ar", termek.ar);
                cmd.Parameters.AddWithValue("@Egyseg", termek.egyseg);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Termek> TermekLista()
        {
            List<Termek> termekLista = new List<Termek>();
            string sql = "SELECT * FROM termekek";
            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int termekID = Convert.ToInt32(reader["TermekID"]);
                        string termekNev = reader["TermekNev"].ToString();
                        int ar = Convert.ToInt32(reader["Ar"]);
                        int kategoriaID = Convert.ToInt32(reader["KategoriaID"]);
                        string egyseg = reader["Egyseg"].ToString();

                        Termek termek = new Termek(
                            termekID, ar, kategoriaID, 
                            termekNev, egyseg
                        );
                        termekLista.Add(termek);
                    }
                }
            }

            return termekLista;
        }

        public Termek TermekAdatok(int termekID)
        {
            Termek termek = new Termek(0, 0, "", "");
            string sql = "SELECT * FROM termekek " +
                "WHERE TermekID = @TermekID";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TermekID", termekID);

                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["TermekID"]);
                        string termekNev = reader["TermekNev"].ToString();
                        int ar = Convert.ToInt32(reader["Ar"]);
                        int kategoriaID = Convert.ToInt32(reader["KategoriaID"]);
                        string egyseg = reader["Egyseg"].ToString();

                        termek = new Termek(
                            termekID, ar, kategoriaID,
                            termekNev, egyseg
                        );
                    }
                }
            }

            return termek;
        }

        protected void TermekFeluliras(Termek termek)
        {
            string sql = "UPDATE termekek " +
                "SET Ar = @Ar, TermekNev = @TermekNev, " +
                "KategoriaID = @KategoriaID, Egyseg = @Egyseg " +
                "WHERE TermekID = @TermekID";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Ar", termek.ar);
                cmd.Parameters.AddWithValue("@TermekNev", termek.termekNev);
                cmd.Parameters.AddWithValue("@KategoriaID", termek.kategoriaID);
                cmd.Parameters.AddWithValue("@Egyseg", termek.egyseg);
                cmd.Parameters.AddWithValue("@TermekID", termek.termekID);

                cmd.ExecuteNonQuery();
            }
        }

        public void TermekTorles(int termekID)
        {
            string sql = "DELETE FROM termekek " +
                "WHERE TermekID = @TermekID";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TermekID", termekID);
                cmd.ExecuteNonQuery();
            }
        }

        protected void RaktarFelvitel(Raktar raktar)
        {
            string sql = "INSERT INTO raktar " +
                "(TermekID, Mennyiseg, BeszerzesiAr, BeszerzesiIdopont) " +
                "VALUES(@TermekID, @Mennyiseg, @BeszerzesiAr, @BeszerzesiIdopont)";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TermekID", raktar.termek.termekID);
                cmd.Parameters.AddWithValue("@Mennyiseg", raktar.mennyiseg);
                cmd.Parameters.AddWithValue("@BeszerzesiAr", raktar.beszerzesiAr);
                cmd.Parameters.AddWithValue("@BeszerzesiIdopont", raktar.beszerzesiIdopont);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Raktar> RaktarLista()
        {
            List<Raktar> raktarLista = new List<Raktar>();
            string sql = "SELECT raktar.*, termekek.* " +
                "FROM raktar " +
                "INNER JOIN termekek " + 
                "ON raktar.TermekID = termekek.TermekID";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int raktarID = Convert.ToInt32(reader["RaktarID"]);
                        int mennyiseg = Convert.ToInt32(reader["Mennyiseg"]);
                        int beszerzesiAr = Convert.ToInt32(reader["BeszerzesiAr"]);
                        DateTime beszerzesiIP = DateTime.Parse(reader["BeszerzesiIdopont"].ToString());
                        Termek termek = new Termek(
                            Convert.ToInt32(reader["TermekID"]),
                            Convert.ToInt32(reader["Ar"]),
                            Convert.ToInt32(reader["KategoriaID"]),
                            reader["TermekNev"].ToString(),
                            reader["Egyseg"].ToString()
                        );

                        Raktar raktar = new Raktar(
                            raktarID, termek,
                            mennyiseg, beszerzesiAr, beszerzesiIP
                        );

                        raktarLista.Add(raktar);
                    }
                }
            }

            return raktarLista;
        }
             
        public void RaktarTorles(int raktarID)
        {
            string sql = "DELETE FROM raktar " +
                "WHERE RaktarID = @RaktarID";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@RaktarID", raktarID);
                cmd.ExecuteNonQuery();
            }
        }

        public Raktar RaktarAdatok(int raktarID)
        {
            Termek termek = new Termek(0, 0, "", "");
            Raktar raktar = new Raktar(termek, 0, 0, new DateTime());
            string sql = "SELECT raktar.*, termekek.* " +
                "FROM raktar " +
                "INNER JOIN termekek " +
                "ON raktar.TermekID = termekek.TermekID " + 
                "WHERE raktar.RaktarID = @RaktarID ";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@RaktarID", raktarID);

                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["RaktarID"]);
                        int mennyiseg = Convert.ToInt32(reader["Mennyiseg"]);
                        int beszerzesiAr = Convert.ToInt32(reader["BeszerzesiAr"]);
                        DateTime beszerzesiIP = DateTime.Parse(reader["BeszerzesiIdopont"].ToString());
                        termek = new Termek(
                            Convert.ToInt32(reader["TermekID"]),
                            Convert.ToInt32(reader["Ar"]),
                            Convert.ToInt32(reader["KategoriaID"]),
                            reader["TermekNev"].ToString(),
                            reader["Egyseg"].ToString()
                        );

                        raktar = new Raktar(
                            ID, termek,
                            mennyiseg, beszerzesiAr, beszerzesiIP
                        );
                    }
                }
            }

            return raktar;
        }

        protected void RaktarFeluliras(Raktar raktar)
        {
            string sql = "UPDATE raktar SET " +
                "Mennyiseg = @Mennyiseg, BeszerzesiAr = @BeszerzesiAr, " +
                "TermekID = @TermekID, BeszerzesiIdopont = @BeszerzesiIdopont " +
                "WHERE RaktarID = @RaktarID";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Mennyiseg", raktar.mennyiseg);
                cmd.Parameters.AddWithValue("@BeszerzesiAr", raktar.beszerzesiAr);
                cmd.Parameters.AddWithValue("@TermekID", raktar.termek.termekID);
                cmd.Parameters.AddWithValue("@BeszerzesiIdopont", raktar.beszerzesiIdopont);
                cmd.Parameters.AddWithValue("@RaktarID", raktar.raktarID);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Termek> TermekKereses(int termekKategoria = 0, string termekNev = "")
        {
            List<Termek> termekLista = new List<Termek>();
            string sql = "SELECT * FROM termekek " +
                "WHERE 1 = 1 ";

            if (termekNev.Length > 0)
                sql += "AND TermekNev LIKE @TermekNev ";

            if (termekKategoria != 0)
                sql += "AND KategoriaID = @KategoriaID ";

            using(MySqlCommand cmd =new MySqlCommand(sql, conn))
            {
                if(termekNev.Length > 0)
                    cmd.Parameters.AddWithValue("@TermekNev", $"%{termekNev}%");

                if (termekKategoria != 0)
                    cmd.Parameters.AddWithValue("@KategoriaID", termekKategoria);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int termekID = Convert.ToInt32(reader["TermekID"]);
                        string nev = reader["TermekNev"].ToString();
                        int ar = Convert.ToInt32(reader["Ar"]);
                        int kategoriaID = Convert.ToInt32(reader["KategoriaID"]);
                        string egyseg = reader["Egyseg"].ToString();

                        Termek termek = new Termek(
                            termekID, ar, kategoriaID,
                            nev, egyseg
                        );
                        termekLista.Add(termek);
                    }
                }
            }

            return termekLista;
        }

        public void Vasarlas(List<Vasarlas> vasarlasLista, int vevoID)
        {
            string sql = "INSERT INTO vasarlasok " +
                "(VasarlasIdopont, VevoID) VALUES(@VasarlasIdopont, @VevoID)";

            string sql2 = "INSERT INTO vasarlas_tetelei " +
                "(VasarlasID, TermekID, Mennyiseg) " +
                "VALUES(@VasarlasID, @TermekID, @Mennyiseg)";

            MySqlTransaction transaction = conn.BeginTransaction();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            cmd.Transaction = transaction;
            cmd2.Transaction = transaction;
            DateTime now = DateTime.Now;

            try
            {
                cmd.Parameters.AddWithValue("@VasarlasIdopont", now);
                cmd.Parameters.AddWithValue("@VevoID", vevoID);
                cmd.ExecuteNonQuery();

                foreach (Vasarlas vasarlas in vasarlasLista)
                {
                    cmd2.Parameters.AddWithValue("@VasarlasID", cmd.LastInsertedId);
                    cmd2.Parameters.AddWithValue("@TermekID", vasarlas.termekID);
                    cmd2.Parameters.AddWithValue("@Mennyiseg", vasarlas.mennyiseg);
                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.Clear();
                }

                transaction.Commit();
            } catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                transaction.Rollback();
            }
            
        }

        protected void VevoFelvitel(Vevo vevo)
        {
            string sql = "INSERT INTO vevok " +
                "(VevoNev, Adoszam, Szekhely, VevoTipusID) " +
                "VALUES(@VevoNev, @Adoszam, @Szekhely, @VevoTipusID)";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@VevoNev", vevo.vevoNev);
                cmd.Parameters.AddWithValue("@Adoszam", vevo.adoszam);
                cmd.Parameters.AddWithValue("@Szekhely", vevo.szekhely);
                cmd.Parameters.AddWithValue("@VevoTipusID", vevo.vt.tipus);

                cmd.ExecuteNonQuery();
            }
        }

        public List<VevoTipus> VevoTipusLista()
        {
            List<VevoTipus> vevoTipusLista = new List<VevoTipus>();
            string sql = "SELECT * FROM vevotipusok";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int vevoTipusID = int.Parse(reader["VevoTipusID"].ToString());
                        string vevoTipus = reader["VevoTipusNev"].ToString();

                        VevoTipus vt = new VevoTipus();
                        vt.tipus = vevoTipusID;
                        vt.nev = vevoTipus;
                        vevoTipusLista.Add(vt);
                    }
                }
            }

            return vevoTipusLista;
        }

        public List<Vevo> VevoLista()
        {
            List<Vevo> vevoLista = new List<Vevo>();
            string sql = "SELECT vevok.*, vevotipusok.* " +
                "FROM vevok " +
                "INNER JOIN vevotipusok " +
                "ON vevok.VevoTipusID = vevotipusok.VevoTipusID";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int vevoID = int.Parse(reader["VevoID"].ToString());
                        string vevoNev = reader["VevoNev"].ToString();
                        VevoTipus vt = new VevoTipus();
                        vt.tipus = int.Parse(reader["VevoTipusID"].ToString());
                        vt.nev = reader["VevoTipusNev"].ToString();
                        string adoszam = reader["Adoszam"].ToString();
                        string szekhely = reader["Szekhely"].ToString();
                        int aktiv = int.Parse(reader["Aktiv"].ToString());

                        Vevo vevo = new Vevo(
                            vevoID, vevoNev, vt, 
                            adoszam, szekhely, aktiv
                        );

                        vevoLista.Add(vevo);
                    }
                }
            }

            return vevoLista;
        }

        public void VevoStatusz(int vevoID, int aktiv)
        {
            string sql = "UPDATE vevok " +
                "SET Aktiv = @Aktiv WHERE VevoID = @VevoID";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@VevoID", vevoID);
                cmd.Parameters.AddWithValue("@Aktiv", aktiv);

                cmd.ExecuteNonQuery();
            }
        }

        public void VevoFeluliras(Vevo vevo)
        {
            string sql = "UPDATE vevok " +
                "SET VevoNev = @VevoNev, " +
                "Adoszam = @Adoszam, " +
                "Szekhely = @Szekhely, " +
                "VevoTipusID = @VevoTipusID " +
                "WHERE VevoID = @VevoID";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@VevoNev", vevo.vevoNev);
                cmd.Parameters.AddWithValue("@Adoszam", vevo.adoszam);
                cmd.Parameters.AddWithValue("@Szekhely", vevo.szekhely);
                cmd.Parameters.AddWithValue("@VevoTipusID", vevo.vt.tipus);
                cmd.Parameters.AddWithValue("@VevoID", vevo.vevoID);

                cmd.ExecuteNonQuery();
            }
        }

        public Vevo VevoAdatok(int vevoID)
        {
            Vevo vevo = new Vevo("", new VevoTipus(), "", "", 0);
            string sql = "SELECT vevok.*, vevotipusok.* " +
                "FROM vevok " +
                "INNER JOIN vevotipusok " +
                "ON vevok.VevoTipusID = vevotipusok.VevoTipusID " +
                "WHERE vevok.VevoID = @VevoID";

            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@VevoID", vevoID);

                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int ID = int.Parse(reader["VevoID"].ToString());
                        string vevoNev = reader["VevoNev"].ToString();
                        VevoTipus vt = new VevoTipus();
                        vt.tipus = int.Parse(reader["VevoTipusID"].ToString());
                        vt.nev = reader["VevoTipusNev"].ToString();
                        string adoszam = reader["Adoszam"].ToString();
                        string szekhely = reader["Szekhely"].ToString();
                        int aktiv = int.Parse(reader["Aktiv"].ToString());

                        vevo = new Vevo(
                            ID, vevoNev, vt,
                            adoszam, szekhely, aktiv
                        );
                    }
                }
            }

            return vevo;
        }

        public List<VasarlasAlap> VasarlasLista()
        {
            List<VasarlasAlap> vasarlasLista = new List<VasarlasAlap>();
            string sql = "SELECT * FROM vasarlasok";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int vasarlasID = Convert.ToInt32(reader["VasarlasID"]);
                        DateTime vasarlasIdopont = Convert.ToDateTime(reader["VasarlasIdopont"]);
                        int vevoID = Convert.ToInt32(reader["VevoID"].ToString());

                        VasarlasAlap vasarlas = new VasarlasAlap();
                        vasarlas.vasarlasID = vasarlasID;
                        vasarlas.vasarlasIdopont = vasarlasIdopont;
                        vasarlas.vevoID = vevoID;
                        vasarlas.sztorno = Convert.ToInt32(reader["Sztorno"].ToString());

                        vasarlasLista.Add(vasarlas);
                    }
                }
            }

            return vasarlasLista;
        }

        public List<Vasarlas> VasarlasReszletek(int vasarlasID)
        {

            List<Vasarlas> vasarlasLista = new List<Vasarlas>();

            string sql = "SELECT vasarlas_tetelei.*, termekek.TermekNev, termekek.TermekID " +
                "FROM vasarlas_tetelei " +
                "INNER JOIN termekek " +
                "ON termekek.TermekID = vasarlas_tetelei.TermekID " +
                "AND vasarlas_tetelei.VasarlasID = @VasarlasID";

            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@VasarlasID", vasarlasID);

                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int tetelID = Convert.ToInt32(reader["TetelID"]);
                        string termekNev = reader["TermekNev"].ToString();
                        int mennyiseg = Convert.ToInt32(reader["Mennyiseg"]);
                        int termekID = Convert.ToInt32(reader["TermekID"]);

                        Vasarlas vasarlas = new Vasarlas(
                            tetelID, termekID, 
                            termekNev, mennyiseg
                        );

                        vasarlasLista.Add(vasarlas);
                    }
                }
            }
            return vasarlasLista;
        }

        public void VasarlasSztorno(int vasarlasID, int sztorno)
        {
            string sql = "UPDATE vasarlasok SET " +
                "Sztorno = @Sztorno " +
                "WHERE VasarlasID = @VasarlasID ";
            using(MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Sztorno", sztorno);
                cmd.Parameters.AddWithValue("@VasarlasID", vasarlasID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
