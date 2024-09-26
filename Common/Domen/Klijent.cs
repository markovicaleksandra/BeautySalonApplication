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
    public class Klijent : IEntity
    {
        public int IDKlijent { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        [Browsable(false)]

        public string Filter { get; set; }

        [JsonIgnore]
        [Browsable(false)]
        public string TableName => "Klijent";

        [JsonIgnore]
        [Browsable(false)]

        public string TableAlias => "kl";

        [JsonIgnore]
        [Browsable(false)]

        public string JoinTable => "";

        [JsonIgnore]
        [Browsable(false)]

        public string JoinCondition => "";

        [JsonIgnore]
        [Browsable(false)]

        public string WhereCondition => $"IDKlijent = {IDKlijent}";

        [JsonIgnore]
        [Browsable(false)]

        public string GeneralCondition => $"{Filter}";

        [JsonIgnore]
        [Browsable(false)]

        public string SelectValues => "*";

        [JsonIgnore]
        [Browsable(false)]

        public string UpdateValues => $"Ime = '{Ime}', Prezime = '{Prezime}', Telefon = '{Telefon}', Email = '{Email}' ";

        [JsonIgnore]
        [Browsable(false)]

        public string InsertValues => $"'{Ime}', '{Prezime}', '{Telefon}', '{Email}'";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> klijenti = new List<IEntity>();
            using (reader)
            {
                while (reader.Read())
                {
                    klijenti.Add(new Klijent
                    {
                        IDKlijent = (int)reader["IDKlijent"],
                        Ime = (string)reader["Ime"],
                        Prezime = (string)reader["Prezime"],
                        Telefon = (string)reader["Telefon"],
                        Email = (string)reader["Email"]
                    });
                }
            }
            return klijenti;
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Klijent k) return k.IDKlijent == IDKlijent;
            return false;
        }

        public IEntity GetOne(SqlDataReader reader)
        {
            Klijent k = new Klijent();
            using (reader)
            {
                if (reader.Read())
                {
                    k.IDKlijent = (int)reader["IDKlijent"];
                    k.Ime = (string)reader["Ime"];
                    k.Prezime = (string)reader["Prezime"];
                    k.Telefon = (string)reader["Telefon"];
                    k.Email = (string)reader["Email"];
                }
            }
            return k;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    
    }
}
