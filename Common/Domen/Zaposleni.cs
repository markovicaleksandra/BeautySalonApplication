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
    public class Zaposleni : IEntity
    {
        public int IDZaposleni { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string  Username { get; set; }
        public string Password { get; set; }
        public List<TipUsluge> TipoviUsluga { get; set; } = new List<TipUsluge>();

        [JsonIgnore]
        [Browsable(false)]  
        public string Uslov { get; set; }

        [JsonIgnore]
        [Browsable(false)]
        public string WhereUslov { get; set; }

        [JsonIgnore]
        [Browsable(false)]
        public string TableName => "Zaposleni";

        [JsonIgnore]
        [Browsable(false)]
        public string TableAlias => "z";

        [JsonIgnore]
        [Browsable(false)]

        public string JoinTable => "join ZaposleniRadi zr";

        [JsonIgnore]
        [Browsable(false)]

        public string JoinCondition => "on z.IDZaposleni = zr.IDZaposleni";

        [JsonIgnore]
        [Browsable(false)]

        public string WhereCondition => $"{WhereUslov}";

        [JsonIgnore]
        [Browsable(false)]

        public string GeneralCondition => $"{Uslov}";

        [JsonIgnore]
        [Browsable(false)]

        public string SelectValues => "distinct z.*";

        [JsonIgnore]
        [Browsable(false)]

        public string UpdateValues => $"Ime = '{Ime}', Prezime = '{Prezime}', Telefon = '{Telefon}', Adresa = '{Adresa}'";


        [JsonIgnore]
        [Browsable(false)]

        public string InsertValues => $"'{Ime}', '{Prezime}', '{Telefon}', '{Adresa}'";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> zaposleni = new List<IEntity>();
            while (reader.Read())
            {
                zaposleni.Add(new Zaposleni
                {
                    IDZaposleni = (int)reader["IDZaposleni"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    Telefon = (string)reader["Telefon"],
                    Adresa = (string)reader["Adresa"],
                    Username = (string)reader["Username"],
                    Password = (string)reader["Password"]
                }
                );
            }
            reader.Close();
            return zaposleni;
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Zaposleni z) return z.IDZaposleni == IDZaposleni;
            return false;
        }

        public IEntity GetOne(SqlDataReader reader)
        {
            Zaposleni z = new Zaposleni();
            using (reader)
            {
                if (reader.Read())
                {
                    z.IDZaposleni = (int)reader["IDZaposleni"];
                    z.Ime = (string)reader["Ime"];
                    z.Prezime = (string)reader["Prezime"];
                    z.Adresa = (string)reader["Adresa"];
                    z.Telefon = (string)reader["Telefon"];
                    z.Username = (string)reader["Username"];
                    z.Password = (string)reader["Password"];
                }
            }
            return z;
        }
    }
}
