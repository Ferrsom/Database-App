using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;


namespace DatenbankApp
{
    public class Datenbank
    {
        private MySqlConnection conn;

        public Datenbank()
        {
            string connstr = "SERVER=localhost; UID='root'; PASSWORD=''; DATABASE=mitarbeiter;";
            
            conn = new MySqlConnection(connstr);
            //conn.Open(); zum testen
            //conn.Close();
        }


        //Mitarbeiter funktionen

        public void delMitarbeiter(int whichNo)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = string.Format("DELETE FROM mitarbeiter " +
                                                "WHERE MaNr = {0};", whichNo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delMitarbeiter " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void saveMitarbeiter(Mitarbeiter ma) //die Methode bekommt eine Instanz Mitarbeiter
        {
            
            try
            {
                conn.Open(); //critical, may not work, so try/catch
                
                MySqlCommand cmd = conn.CreateCommand(); //if this were to be used by finally, needs to be outside the try and inside the method

                if (ma.MaNr1 == 0)
                {
                    cmd.CommandText = string.Format("INSERT INTO mitarbeiter " +
                                                    "VALUES( NULL, '{0}', '{1}', NULL);", //paremeter zählen ab null
                                                    ma.MaName1, ma.MaVorname1);
                    
                }
                else
                {
                    cmd.CommandText = string.Format("UPDATE mitarbeiter " +
                                                    "SET maName = '{0}', mavorname = '{1}' " +
                                                    "WHERE maNr = '{2}';",
                                                    ma.MaName1, ma.MaVorname1, ma.MaNr1);
                }
                cmd.ExecuteNonQuery(); //keine anfrage, nur command schicken
            }
            catch (Exception ex)
            {
                MessageBox.Show("saveMitarbeiter " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        //#region zumwegblenden
        //#endregion

        public List<Mitarbeiter> getMitarbeiter()
        {
            List<Mitarbeiter> liMa = new List<Mitarbeiter>();

            MySqlDataReader reader = null;
            
            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM mitarbeiter;";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liMa.Add(
                        new Mitarbeiter(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1), //wenn leer, leere string: ""
                            reader.IsDBNull(2) ? "" : reader.GetString(2),
                            reader.IsDBNull(3) ? -1 : reader.GetInt32(3) //wenn leer, leere int: -1
                            )
                        );
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("getMitarbeiter " + ex.Message);
            }
            finally
            {
                if (reader != null)
                { 
                    reader.Close();
                    conn.Close();
                }
                
            }

            return liMa;
        }

        //Abteilungs Funktionen

        public void delAbteilung(int whichNo)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = string.Format("DELETE FROM abteilung " +
                                                "WHERE AbtNr = {0};", whichNo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delAbteilung " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void saveAbteilung(Abteilung ab)
        {

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();

                if (ab.AbtNr1 == 0)
                {
                    cmd.CommandText = string.Format("INSERT INTO abteilung " +
                                                    "VALUES( NULL, '{0}');",
                                                    ab.AbtName1);

                }
                else
                {
                    cmd.CommandText = string.Format("UPDATE abteilung " +
                                                    "SET AbtName = '{0}'" +
                                                    "WHERE AbtNr = '{1}';",
                                                    ab.AbtName1, ab.AbtNr1);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("saveAbteilung " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public List<Abteilung> getAbteilung()
        {
            List<Abteilung> liAb = new List<Abteilung>();

            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM abteilung;";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liAb.Add(
                        new Abteilung(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1)
                            )
                        );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("getAbteilung " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }

            }

            return liAb;
        }

    }
}
