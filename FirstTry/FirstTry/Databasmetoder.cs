﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace FirstTry
{

    class Databasmetoder
    {
        public int x { get; set; }



        public static int LaggTillForestallning(Forestallning laggtillforestallning)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=pgmvaru_g4;User Id=pgmvaru_g4;Password=trapets;ssl=true");
            conn.Open();
            //Forestallning laggtillforestallning = new Forestallning();
            string query = "INSERT INTO forestallning (namn, generell_info, starttid, sluttid, open, vuxenpris, ungdomspris, barnpris, fri_placering) VALUES(@namn, @generell_info, @starttid, @sluttid, @open, @vuxenpris, @ungdomspris, @barnpris, @fri_placering)";

            NpgsqlCommand command = new NpgsqlCommand(query, conn);

            command.Parameters.AddWithValue("@namn", laggtillforestallning.namn);
            command.Parameters.AddWithValue("@generell_info", laggtillforestallning.generellinfo);
            command.Parameters.AddWithValue("@starttid", laggtillforestallning.starttid);
            command.Parameters.AddWithValue("@sluttid", laggtillforestallning.sluttid);
            command.Parameters.AddWithValue("@open", false);//false tills öppnad
            command.Parameters.AddWithValue("@vuxenpris", laggtillforestallning.vuxenpris);
            command.Parameters.AddWithValue("@ungdomspris", laggtillforestallning.ungdomspris);
            command.Parameters.AddWithValue("@barnpris", laggtillforestallning.barnpris);
            command.Parameters.AddWithValue(@"fri_placering", false);

            return command.ExecuteNonQuery();
            
        }

       
        public static List<Forestallning> HamtaForestallningLista()
        {
            List<Forestallning> forestallningslista = new List<Forestallning>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=pgmvaru_g4;User Id=pgmvaru_g4;Password=trapets;ssl=true");
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("Select * from forestallning", conn);
            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
               // if ((string) dr["namn"] != null)
               // {
                

                Forestallning forestallning = new Forestallning();

                   forestallning.id = Convert.ToInt32(dr["id"]);
                   forestallning.namn = (string)dr["namn"];
                   forestallning.generellinfo = (string)dr["generell_info"];
                   forestallning.starttid = Convert.ToDateTime(dr["starttid"]);
                   forestallning.sluttid = Convert.ToDateTime(dr["sluttid"]);
                   forestallning.vuxenpris = Convert.ToInt32(dr["vuxenpris"]);
                   forestallning.ungdomspris = Convert.ToInt32(dr["ungdomspris"]);
                   forestallning.barnpris = Convert.ToInt32(dr["barnpris"]);
                
                    
                forestallningslista.Add(forestallning);
                //}
            }
            conn.Close();
            return forestallningslista;

        }
        public static List<Akt> HamtaAktLista(int fsid)
        {
            /*  List<Forestallning> forestallningslista = new List<Forestallning>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=pgmvaru_g4;User Id=pgmvaru_g4;Password=trapets;ssl=true");
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("Select * from forestallning", conn);
            NpgsqlDataReader dr = command.ExecuteReader();  */

            List<Akt> aktlista = new List<Akt>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=pgmvaru_g4;User Id=pgmvaru_g4;Password=trapets;ssl=true");
            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand(@"Select * from akter , forestallning
                                                  Where akter.forestallningsid = forestallning.id
                                                 and forestallningsid = :fsid ;", conn);  ///**/

             command.Parameters.Add(new NpgsqlParameter("fsid", DbType.Int32));
             command.Parameters[0].Value = Convert.ToInt32(fsid);
            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Akt akten = new Akt();

                akten.id = Convert.ToInt32(dr["id"]);
                akten.namn = (string)dr["aktnamn"];
                akten.Aktinfo  = (string)dr["aktinfo"];
                //akten.Starttid = Convert.ToDateTime(dr["starttid"]);   //datumtid
                //akten.Sluttid = Convert.ToDateTime(dr["sluttid"]);
                akten.vuxen = Convert.ToInt32(dr["vuxenpris"]);
                akten.ungdom = Convert.ToInt32(dr["ungdomspris"]);
                akten.barn = Convert.ToInt32(dr["barnpris"]);


                //Akt akten = new Akt();
                //{
                //    id = Convert.ToInt32(dr["id"]),
                //    namn = (string)dr["aktnamn"],
                //    AktInfo = (string)dr["aktinfo"],
                //    //starttid = Convert.ToDateTime(dr["starttid"]),   //datumtid
                //    Sluttid = Convert.ToDateTime(dr["sluttid"]),
                //    vuxen = Convert.ToInt32(dr["vuxenpris"]),
                //    ungdom = Convert.ToInt32(dr["ungdomspris"]),
                //    barn = Convert.ToInt32(dr["barnpris"]),

                //};
                
                aktlista.Add(akten);
            }
            conn.Close();
            return aktlista;
        }

        public static void LaggTillNyForestallning(string namn, string generellinfo, bool open ,DateTime starttid, DateTime sluttid, int vuxenpris, int ungdomspris, int barnpris, bool friplacering)
        {
            NpgsqlConnection conn1 = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=pgmvaru_g4;User Id=pgmvaru_g4;Password=trapets;ssl=true");
            // NpgsqlTransaction trans = new NpgsqlTransaction();
            //NpgsqlTransaction trans = null;
           
            //NpgsqlTransaction trans = conn1.BeginTransaction();

            try
            {
                conn1.Open();
               // NpgsqlTransaction trans = conn1.BeginTransaction();

                NpgsqlCommand command1 = new NpgsqlCommand(@"INSERT INTO forestallning(namn, generell_info, open, starttid, sluttid, fri_placering) VALUES (:nyNamn, :nyGenerellInfo,:nyOpen ,:nyStarttid, :nySluttid, :nyFriplacering)", conn1);

                //"/*, vuxenpris, ungdomspris, barnpris
                // /*, NyttVuxenpris, :NyttUngdomspris, :NyttBarnpris)"*/

                command1.Parameters.Add(new NpgsqlParameter("nyNamn", DbType.String));
                command1.Parameters[0].Value = namn;
                command1.Parameters.Add(new NpgsqlParameter("nyGenerellinfo", DbType.String));
                command1.Parameters[1].Value = generellinfo;
                command1.Parameters.Add(new NpgsqlParameter("nyOpen", DbType.Boolean));
                command1.Parameters[2].Value = open;
                command1.Parameters.Add(new NpgsqlParameter("nyStarttid", DbType.DateTime));
                command1.Parameters[3].Value = starttid;
                command1.Parameters.Add(new NpgsqlParameter("nySluttid", DbType.DateTime));
                command1.Parameters[4].Value = sluttid;
                command1.Parameters.Add(new NpgsqlParameter("nyttVuxenpris", DbType.Int32));
                command1.Parameters[5].Value = vuxenpris;
                command1.Parameters.Add(new NpgsqlParameter("nyttUngdomspris", DbType.Int32));
                command1.Parameters[6].Value = ungdomspris;
                command1.Parameters.Add(new NpgsqlParameter("nyttBarnpris", DbType.Int32));
                command1.Parameters[7].Value = barnpris;
                command1.Parameters.Add(new NpgsqlParameter("nyFriplacering", DbType.Boolean));
                command1.Parameters[8].Value = friplacering;
                // command1.Transaction = trans;
                int numberOfAffectedRows = command1.ExecuteNonQuery();


                //NpgsqlCommand command2 = new NpgsqlCommand(@"SELECT id FROM forestallning WHERE namn = :namn", conn1);

                //command2.Parameters.Add(new NpgsqlParameter("nyttNamn", DbType.String));
                //command2.Parameters[0].Value = namn;
                //command2.Transaction = trans;
                //int id = (int)command2.ExecuteScalar();


                //NpgsqlCommand command3 = new NpgsqlCommand(@"SELECT aktid FROM forestallning WHERE aktnamn = :aktnamn", conn1);

                //command3.Parameters.Add(new NpgsqlParameter("nyttNamn", DbType.String));
                //command3.Parameters[0].Value = namn;

                //command3.Transaction = trans;
                //int aktid = (int)command3.ExecuteScalar();

                //NpgsqlCommand command4 = new NpgsqlCommand(@"INSERT INTO innehaller (id, aktid) VALUES(:id, :aktid)", conn1);

                //command4.Parameters.Add(new NpgsqlParameter("aktid", DbType.Int32));
                //command4.Parameters[0].Value = id;
                //command4.Parameters.Add(new NpgsqlParameter("id", DbType.Int32));
                //command4.Parameters[0].Value = aktid;

                //command4.Transaction = trans;
                //numberOfAffectedRows = command4.ExecuteNonQuery();
                //trans.Commit();
            }

            catch (NpgsqlException ex)
            {
                //trans.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn1.Close();
            }       
       }

        public static void LaggTillNyAkt(string aktnamn, string aktinfo, DateTime starttid, DateTime sluttid, int vuxen, int ungdom, int barn, string forestallningsNamn)
        {
            NpgsqlConnection conn1 = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=pgmvaru_g4;User Id=pgmvaru_g4;Password=trapets;ssl=true");
            //NpgsqlTransaction trans = null;


            try
            {
                conn1.Open();
               // trans = conn1.BeginTransaction();

                NpgsqlCommand command1 = new NpgsqlCommand(@"INSERT INTO forestallning(aktnamn, aktinfo, starttid, sluttid, vuxen ungdom, barn) VALUES (:nyttAktNamn, :NyAktInfo, :NyStarttid, :NySluttid, NyttVuxenpris, :NyttUngdomspris, :NyttBarnpris)", conn1);

                command1.Parameters.Add(new NpgsqlParameter("nyttAktNamn", DbType.String));
                command1.Parameters[0].Value = aktnamn;
                command1.Parameters.Add(new NpgsqlParameter("nyGenerellinfo", DbType.String));
                command1.Parameters[0].Value = aktinfo;
                command1.Parameters.Add(new NpgsqlParameter("nyStarttid", DbType.DateTime));
                command1.Parameters[0].Value = starttid;
                command1.Parameters.Add(new NpgsqlParameter("nySluttid", DbType.DateTime));
                command1.Parameters[0].Value = sluttid;
                command1.Parameters.Add(new NpgsqlParameter("nyttVuxenpris", DbType.Int32));
                command1.Parameters[0].Value = vuxen;
                command1.Parameters.Add(new NpgsqlParameter("nyttUngdomspris", DbType.Int32));
                command1.Parameters[0].Value = ungdom;
                command1.Parameters.Add(new NpgsqlParameter("nyttBarnpris", DbType.Int32));
                command1.Parameters[0].Value = barn;
               // command1.Transaction = trans;
                int numberOfAffectedRows = command1.ExecuteNonQuery();


                //NpgsqlCommand command2 = new NpgsqlCommand(@"SELECT id FROM forestallning WHERE namn = :namn", conn1);

                //command2.Parameters.Add(new NpgsqlParameter("nyttNamn", DbType.String));
                ////command2.Parameters[0].Value = namn;
                //command2.Transaction = trans;
                //int id = (int)command2.ExecuteScalar();


                //NpgsqlCommand command3 = new NpgsqlCommand(@"SELECT aktid FROM forestallning WHERE aktnamn = :aktnamn", conn1);

                //command3.Parameters.Add(new NpgsqlParameter("nyttAktNamn", DbType.String));
                //command3.Parameters[0].Value = aktnamn;

                //command3.Transaction = trans;
                //int aktid = (int)command3.ExecuteScalar();

                //NpgsqlCommand command4 = new NpgsqlCommand(@"INSERT INTO innehaller (id, aktid) VALUES(:id, :aktid)", conn1);

                //command4.Parameters.Add(new NpgsqlParameter("aktid", DbType.Int32));
                //command4.Parameters[0].Value = id;
                //command4.Parameters.Add(new NpgsqlParameter("id", DbType.Int32));
                //command4.Parameters[0].Value = aktid;

                //command4.Transaction = trans;
                //numberOfAffectedRows = command4.ExecuteNonQuery();
                //trans.Commit();
            }

            catch (NpgsqlException ex)
            {
               // trans.Rollback();
            }
            finally
            {
                conn1.Close();
            }
        }



             public static void UppdateraForestallning(int forestallningsid, string namn, string generellinfo, DateTime starttid, DateTime sluttid, int vuxenpris, int ungdomspris, int barnpris)
        {

            NpgsqlConnection conn1 = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=pgmvaru_g4;User Id=pgmvaru_g4;Password=trapets;ssl=true");

            
            {

            }
            try
            {
                conn1.Open();
                MessageBox.Show(conn1.State.ToString());
               
                NpgsqlCommand command1 = new NpgsqlCommand(@" UPDATE forestallning set namn = :uppdnamn, generell_info = :uppdgenerellinfo, starttid = :uppdstarttid, sluttid = :uppdsluttid, vuxenpris = :uppdvuxenpris, ungdomspris = :uppdungdomspris, barnpris = :uppdbarnpris 
                                                            WHERE id = :uppdid", conn1);

                command1.Parameters.Add(new NpgsqlParameter("uppdid", DbType.Int32));
                command1.Parameters["id"].Value = forestallningsid;
                command1.Parameters.Add(new NpgsqlParameter("uppdnamn", DbType.String));
                command1.Parameters["namn"].Value = namn;
                command1.Parameters.Add(new NpgsqlParameter("uppdgenerellinfo", DbType.String));
                command1.Parameters["generell_info"].Value = generellinfo;
                command1.Parameters.Add(new NpgsqlParameter("uppdstarttid", DbType.DateTime));
                command1.Parameters["starttid"].Value = starttid;
                command1.Parameters.Add(new NpgsqlParameter("uppdsluttid", DbType.DateTime));
                command1.Parameters["sluttid"].Value = sluttid;
                command1.Parameters.Add(new NpgsqlParameter("uppdvuxenpris", DbType.Int32));
                command1.Parameters["vuxenpris"].Value = vuxenpris;
                command1.Parameters.Add(new NpgsqlParameter("uppdungdomspris", DbType.Int32));
                command1.Parameters["ungdomspris"].Value = ungdomspris;
                command1.Parameters.Add(new NpgsqlParameter("uppdbarnpris", DbType.Int32));
                command1.Parameters["barnpris"].Value = barnpris;
               

                int numberOfAffectedRows = command1.ExecuteNonQuery();

                }

            catch (NpgsqlException ex)
            {
                MessageBox.Show("gör om gör rätt!");
                return;
                
            }
            finally
            {
                conn1.Close();
            }       
       }  

    }
}





            
       
        
       


    
