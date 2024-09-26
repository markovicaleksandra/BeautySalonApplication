using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Common.Domen
{
    [Serializable]
    public class Rezervacija : IEntity
    {
        public int IDRezervacija { get; set; }
        public Usluga Usluga { get; set; }
        public Klijent Klijent { get; set; }
        public DateTime Datum { get; set; }
        public DateTime VremePocetka { get; set; }
        public DateTime VremeZavrsetka { get; set; }
        public Zaposleni Zaposleni { get; set; }
        public string Napomena { get; set; }

        [JsonIgnore]
        [Browsable(false)]
        public string Uslov { get; set; }

        [JsonIgnore]
        [Browsable(false)]

        public string TableName => "Rezervacija";

        [JsonIgnore]
        [Browsable(false)]

        public string TableAlias => "r";

        [JsonIgnore]
        [Browsable(false)]

        public string JoinTable => "JOIN Klijent k ON r.IDKlijent = k.IDKlijent JOIN Usluga u ON r.IDUsluga = u.IDUsluga JOIN Zaposleni z ON r.IDZaposleni = z.IDZaposleni ";


        [JsonIgnore]
        [Browsable(false)]

        public string JoinCondition => "";

        [JsonIgnore]
        [Browsable(false)]

        public string WhereCondition => $"IDRezervacija = {IDRezervacija}";
        
        [JsonIgnore]
        [Browsable(false)]

        public string GeneralCondition => $"{Uslov}";

        [JsonIgnore]
        [Browsable(false)]

        public string SelectValues => "r.*, k.IDKlijent AS KlijentID, k.Ime AS KlijentIme, k.Prezime AS KlijentPrezime, k.Telefon AS KlijentTelefon, k.Email AS KlijentEmail, z.IDZaposleni AS ZaposleniID, z.Ime AS ZaposleniIme, z.Prezime AS ZaposleniPrezime, z.Telefon as ZaposleniTelefon, u.*";

        [JsonIgnore]
        [Browsable(false)]

        public string UpdateValues => $"IDKlijent = {Klijent.IDKlijent}, IDUsluga = {Usluga.IDUsluga}, Datum = '{Datum.ToString("dd.MM.yyyy")}', VremePocetka = '{VremePocetka.ToString("yyyy-MM-dd HH:mm")}', VremeZavrsetka = '{VremeZavrsetka.ToString("yyyy-MM-dd HH:mm")}', Napomena = '{Napomena}', IDZaposleni = {Zaposleni.IDZaposleni}";

        [JsonIgnore]
        [Browsable(false)]

        public string InsertValues => $"{Klijent.IDKlijent}, {Usluga.IDUsluga}, '{Datum.Date.ToString("yyyy-MM-dd")}', '{VremePocetka.ToString("yyyy-MM-dd HH:mm")}', '{VremeZavrsetka.ToString("yyyy-MM-dd HH:mm")}', '{Napomena}', {Zaposleni.IDZaposleni}";



        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> rezervacije = new List<IEntity>();
            while (reader.Read())
            {
                Rezervacija rezervacija = new Rezervacija
                {
                    IDRezervacija = (int)reader["IDRezervacija"],
                    Datum = (DateTime)reader["Datum"],
                    VremePocetka = (DateTime)reader["VremePocetka"],
                    VremeZavrsetka = (DateTime)reader["VremeZavrsetka"],
                    Napomena = (string)reader["Napomena"],
                    Klijent = new Klijent
                    {
                        IDKlijent = (int)reader["KlijentID"],
                        Ime = (string)reader["KlijentIme"],
                        Prezime = (string)reader["KlijentPrezime"],
                        Telefon = (string)reader["KlijentTelefon"],
                        Email = (string)reader["KlijentEmail"]
                    },
                    Usluga = new Usluga
                    {
                        IDUsluga = (int)reader["IDUsluga"],
                        Naziv = (string)reader["Naziv"],
                        Cena = (double)reader["Cena"],
                        Trajanje = (int)reader["Trajanje"]
                    },
                    Zaposleni = new Zaposleni
                    {
                        IDZaposleni = (int)reader["ZaposleniID"],
                        Ime = (string)reader["ZaposleniIme"],
                        Prezime = (string)reader["ZaposleniPrezime"],
                        Telefon = (string)reader["ZaposleniTelefon"]
                    }
                };
                rezervacije.Add(rezervacija);
            }
            reader.Close();
            return rezervacije;
        }

        public IEntity GetOne(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
