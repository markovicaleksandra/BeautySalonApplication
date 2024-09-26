using Microsoft.Win32;
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
    public class Usluga : IEntity
    {
        public int IDUsluga { get; set; }
        public string Naziv { get; set; }
        public double Cena { get; set; }
        public int Trajanje { get; set; }
        public  TipUsluge TipUsluge { get; set; }

        [JsonIgnore]
        [Browsable(false)]

        public string Uslov { get; set; }
       
        [JsonIgnore]
        [Browsable(false)]

        public string TableName => "Usluga";

        [JsonIgnore]
        [Browsable(false)]

        public string TableAlias => "u";

        [JsonIgnore]
        [Browsable(false)]

        public string JoinTable => "join TipUsluge tu";

        [JsonIgnore]
        [Browsable(false)]

        public string JoinCondition => "on u.IDTipUsluge = tu.IDTipUsluge";

        [JsonIgnore]
        [Browsable(false)]

        public string WhereCondition => $"IDUsluga={IDUsluga}";

        [JsonIgnore]
        [Browsable(false)]

        public string GeneralCondition => $"{Uslov}";

        [JsonIgnore]
        [Browsable(false)]

        public string SelectValues => "*";

        [JsonIgnore]
        [Browsable(false)]

        public string UpdateValues => $" Naziv = '{Naziv}', Cena = {Cena}, Trajanje = {Trajanje}, IDTipUsluge = {TipUsluge.IDTipUsluge}";

        [JsonIgnore]
        [Browsable(false)]

        public string InsertValues => $"'{Naziv}', {Cena}, {Trajanje}, {TipUsluge.IDTipUsluge}";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> usluge = new List<IEntity>();
            using (reader)
            {
                while (reader.Read())
                {
                    usluge.Add(new Usluga
                    {
                        IDUsluga = (int)reader["IDUsluga"],
                        Naziv = (string)reader["Naziv"],
                        Cena = (double)reader["Cena"],
                        Trajanje = (int)reader["Trajanje"],
                        TipUsluge = new TipUsluge()
                        {
                            IDTipUsluge = (int)reader["IDTipUsluge"],
                            NazivTipaUsluge = (string)reader["NazivTipa"]
                        }
                    });
                }
            }
            return usluge;
        }

        public override string ToString()
        {
            return Naziv;
        }
        public override bool Equals(object obj)
        {

            if (obj is Usluga u) return u.Naziv == Naziv;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public IEntity GetOne(SqlDataReader reader)
        {
            Usluga u = new Usluga();
            using (reader)
            {
                if (reader.Read())
                {
                    u.IDUsluga = (int)reader["IDUsluga"];
                    u.Cena = (double)reader["Cena"];
                    u.Trajanje = (int)reader["Trajanje"];
                    u.Naziv = (string)reader["Naziv"];
                    u.TipUsluge = new TipUsluge
                    {
                        IDTipUsluge = (int)reader["IDTipUsluge"],
                        NazivTipaUsluge = (string)reader["NazivTipa"]
                    };
                }
            }
            return u;
        }
    }
}
