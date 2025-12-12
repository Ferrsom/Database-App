using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace Zoo
{
    public class Datenbank
    {
        private MySqlConnection conn;

        public Datenbank()
        {
            string connstr = "SERVER=localhost; UID='root'; PASSWORD=''; DATABASE=zoo;";
            conn = new MySqlConnection(connstr);
        }

        //Kontinent

        public List<Kontinent> getKontinent()
        {
            List<Kontinent> liKo = new List<Kontinent>();
            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM kontinent;";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liKo.Add(
                        new Kontinent(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1)
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getKontinent " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }

            }

            return liKo;
        }

        public void saveKontinent(Kontinent ko)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                if (ko.kID1 == 0)
                {
                    cmd.CommandText = string.Format("INSERT INTO kontinent " +
                                                    "VALUES( NULL, '{0}');",
                                                    ko.KBezeichnung1);
                }
                else
                {
                    cmd.CommandText = string.Format("UPDATE kontinent " +
                                                    "SET KBezeichnung = '{0}'" +
                                                    "WHERE kID = '{1}';",
                                                    ko.KBezeichnung1, ko.kID1);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("saveKontinent " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void delKontinent(int whichNo)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("DELETE FROM kontinent " +
                                                "WHERE kID = {0};", whichNo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delKontinent " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        //Tierart

        public List<Tierart> getTierart()
        {
            List<Tierart> liTa = new List<Tierart>();
            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM tierart;";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liTa.Add(
                        new Tierart(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1)
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getTierart " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }

            }

            return liTa;
        }

        public void saveTierart(Tierart ta)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                if (ta.tierartID1 == 0)
                {
                    cmd.CommandText = string.Format("INSERT INTO tierart " +
                                                    "VALUES( NULL, '{0}');",
                                                    ta.TABezeichnung1);
                }
                else
                {
                    cmd.CommandText = string.Format("UPDATE tierart " +
                                                    "SET TABezeichnung = '{0}'" +
                                                    "WHERE tierartID = '{1}';",
                                                    ta.TABezeichnung1, ta.tierartID1);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("saveTierart " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void delTierart(int whichNo)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("DELETE FROM tierart " +
                                                "WHERE tierartID = {0};", whichNo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delTierart " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        //Gehege

        public List<Gehege> getGehege()
        {
            List<Gehege> liGe = new List<Gehege>();
            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM gehege;";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liGe.Add(
                        new Gehege(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1),
                            reader.IsDBNull(2) ? -1 : reader.GetInt32(2)
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getGehege " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }
            }

            return liGe;
        }

        public List<Gehege> gridGehege(int nr) //For the grid view
        {
            List<Gehege> ligGe = new List<Gehege>();

            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM gehege " +
                                  "WHERE gID = " + nr + ";";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ligGe.Add(
                        new Gehege(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1),
                            reader.IsDBNull(2) ? -1 : reader.GetInt32(2)
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("gridGehege " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }

            }

            return ligGe;
        }

        public void saveGehege(Gehege ge)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                string str = ge.kontinentID1 == 0 ? "null" : ge.kontinentID1.ToString();

                if (ge.gID1 == 0)
                {
                    cmd.CommandText = string.Format("INSERT INTO gehege " +
                                                    "VALUES( NULL, '{0}', {1});",
                                                    ge.GBezeichnung1, str);
                }
                else
                {
                    cmd.CommandText = string.Format("UPDATE gehege " +
                                                    "SET GBezeichnung = '{0}', kontinentID = {1} " +
                                                    "WHERE gID = '{2}';",
                                                    ge.GBezeichnung1, str, ge.gID1);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("saveGehege " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void delGehege(int whichNo)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("DELETE FROM gehege " +
                                                "WHERE gID = {0};", whichNo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delGehege " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        //Tier

        public List<Tiere> getTiere()
        {
            List<Tiere> liTi = new List<Tiere>();
            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM tiere;";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liTi.Add(
                        new Tiere(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1),
                            reader.IsDBNull(2) ? 0  : reader.GetDecimal(2),
                            reader.IsDBNull(3) ? "" : reader.GetString(3),
                            reader.IsDBNull(4) ? -1 : reader.GetInt32(4),
                            reader.IsDBNull(5) ? -1 : reader.GetInt32(5)
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getTiere " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }
            }

            return liTi;
        }

        public void saveTiere(Tiere ti)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                string str1 = ti.TierartID1 == 0 ? "null" : ti.TierartID1.ToString();
                string str2 = ti.GehegeID1 == 0 ? "null" : ti.GehegeID1.ToString();

                if (ti.tierID1 == 0)
                {
                    cmd.CommandText = string.Format("INSERT INTO tiere " +
                                                    "VALUES( NULL, '{0}', {1}, '{2}', {3}, {4});",
                                                    ti.Name1, ti.Gewicht1.ToString().Replace(',', '.'), ti.Geburtsdatum1, str1, str2);
                }
                else
                {
                    cmd.CommandText = string.Format("UPDATE tiere " +
                                                    "SET Name = '{0}', Gewicht = {1}, Geburtsdatum = '{2}', TierartID = {3}, GehegeID = {4} " +
                                                    "WHERE tierID = '{5}';",
                                                    ti.Name1, ti.Gewicht1.ToString().Replace(',','.'), ti.Geburtsdatum1, str1, str2, ti.tierID1);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("saveTiere " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void delTiere(int whichNo)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("DELETE FROM tiere " +
                                                "WHERE tierID = {0};", whichNo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delTiere " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        //Futter

        public List<Futter> getFutter()
        {
            List<Futter> liFu = new List<Futter>();
            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM futter;";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liFu.Add(
                        new Futter(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1),
                            reader.IsDBNull(3) ? "" : reader.GetString(3),
                            reader.IsDBNull(2) ? "" : reader.GetString(2)
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getFutter " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }

            }

            return liFu;
        }

        public void saveFutter(Futter fu)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                if (fu.fID1 == 0)
                {
                    cmd.CommandText = string.Format("INSERT INTO futter " +
                                                    "VALUES( NULL, '{0}', '{1}', '{2}');",
                                                    fu.FBezeichnung1, fu.Kommentar1, fu.Verpackungsgroesse1);
                }
                else
                {
                    cmd.CommandText = string.Format("UPDATE futter " +
                                                    "SET FBezeichnung = '{0}', Verpackungsgroesse = '{1}', Kommentar = '{2}' " +
                                                    "WHERE fID = '{3}';",
                                                    fu.FBezeichnung1, fu.Verpackungsgroesse1, fu.Kommentar1, fu.fID1);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("saveFutter " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void delFutter(int whichNo)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("DELETE FROM futter " +
                                                "WHERE fID = {0};", whichNo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delFutter " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        //Füttern

        public List<Füttern> getFüttern(int nr)
        {
            List<Füttern> liFue = new List<Füttern> ();

            MySqlDataReader reader = null;

            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM füttern " +
                                  "WHERE TierId = " + nr + ";";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liFue.Add(
                        new Füttern(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1),
                            reader.IsDBNull(2) ? "" : reader.GetString(2),
                            reader.IsDBNull(3) ? -1 : reader.GetInt32(3),
                            reader.IsDBNull(4) ? -1 : reader.GetInt32(4)
                            )
                        );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("getFütter " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    conn.Close();
                }

            }

            return liFue;
        }

        public void saveFüttern(Füttern fue)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                if (fue.fuetID1 == 0)
                {
                    cmd.CommandText = string.Format("INSERT INTO füttern " +
                                                    "VALUES( NULL, '{0}', '{1}', {2}, {3});",
                                                    fue.Menge1, fue.Uhrzeit1, fue.TierID1, fue.FutterID1);
                }
                else
                {
                    cmd.CommandText = string.Format("UPDATE füttern " +
                                                    "SET Menge = '{0}', Uhrzeit = '{1}', TierID = {2}, FutterID = {3} " +
                                                    "WHERE fuetID = '{4}';",
                                                    fue.Menge1, fue.Uhrzeit1, fue.TierID1, fue.FutterID1, fue.fuetID1);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("saveFüttern " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void delFüttern(int whichNo)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("DELETE FROM füttern " +
                                                "WHERE fuetID = {0};", whichNo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delFüttern " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

    }
}
