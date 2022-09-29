using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Vaje10
{
    class model
    {

        public static void DodajClana(clan clan)
        {
            baza baza = new baza();
            var command = new SQLiteCommand("INSERT INTO clan (ime, priimek, starost, spol, dolg) VALUES (@ime, @priimek, @starost, @spol, @dolg)", baza.connection);
            baza.OpenConnection();

            command.Parameters.AddWithValue("@ime", clan.Ime);
            command.Parameters.AddWithValue("@priimek", clan.Priimek);
            command.Parameters.AddWithValue("@starost", clan.Starost);
            command.Parameters.AddWithValue("@spol", clan.Spol);
            command.Parameters.AddWithValue("@dolg", clan.Dolg);

            command.ExecuteNonQuery();
            baza.CloseConnection();

        }
        public static void DodajKnjigo(knjiga knjiga)
        {
            baza baza = new baza();
            var command = new SQLiteCommand("INSERT INTO knjiga (naslov, avtor, zanr, leto_izdaje,zalozba) VALUES (@naslov, @avtor, @zanr, @leto_izdaje, @zalozba)", baza.connection);
            baza.OpenConnection();

            command.Parameters.AddWithValue("@naslov", knjiga.Naslov);
            command.Parameters.AddWithValue("@avtor", knjiga.Avtor);
            command.Parameters.AddWithValue("@zanr", knjiga.Zanr);
            command.Parameters.AddWithValue("@leto_izdaje", knjiga.Leto_izdaje);
            command.Parameters.AddWithValue("@zalozba", knjiga.Zalozba);

            command.ExecuteNonQuery();
            baza.CloseConnection();

        }

        public static List<knjiga> IzpisKnjig()
        {
            baza baza = new baza();
            List<knjiga> knjige = new List<knjiga>();
            var command = new SQLiteCommand("SELECT * FROM knjiga", baza.connection);
            baza.OpenConnection();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

            DataSet data = new DataSet();
            adapter.Fill(data);

            foreach (DataRow row in data.Tables[0].Rows)
            {
                knjiga knjiga = new knjiga();
                knjiga.Naslov = (string)row["naslov"];
                knjiga.Avtor = (string)row["avtor"];
                knjiga.Zanr = (string)row["zanr"];
                knjiga.Leto_izdaje = (string)row["leto_izdaje"].ToString();
                knjiga.Zalozba = (string)row["zalozba"];

                knjige.Add(knjiga);
            }
            return knjige;

        }

        public static List<clan> IzpisClanov()
        {
            baza baza = new baza();
            List<clan> clani = new List<clan>();
            var command = new SQLiteCommand("SELECT * FROM clan", baza.connection);
            baza.OpenConnection();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

            DataSet data = new DataSet();
            adapter.Fill(data);

            foreach (DataRow row in data.Tables[0].Rows)
            {
                clan clanData = new clan();
                clanData.Ime = (string)row["ime"];
                clanData.Priimek = (string)row["priimek"];
                clanData.Starost = (string)row["starost"].ToString();
                clanData.Spol = (string)row["spol"];
                clanData.Dolg = (string)row["dolg"].ToString();


                clani.Add(clanData);
            }
            return clani;
        }


    }
}
