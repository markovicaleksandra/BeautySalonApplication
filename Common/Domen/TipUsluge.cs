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
    public class TipUsluge : IEntity
    {
        public int IDTipUsluge { get; set; }
        public string NazivTipaUsluge { get; set; }


        [JsonIgnore]
        [Browsable(false)]

        public string Uslov { get; set; }

        [JsonIgnore]
        [Browsable(false)]
        public string TableName => "TipUsluge";

        [JsonIgnore]
        [Browsable(false)]

        public string TableAlias => "tu";

        [JsonIgnore]
        [Browsable(false)]

        public string JoinTable => "join ZaposleniRadi zr";

        [JsonIgnore]
        [Browsable(false)]

        public string JoinCondition => "on tu.IDTipUsluge = zr.IDTipUsluge";

        [JsonIgnore]
        [Browsable(false)]

        public string WhereCondition => "";

        [JsonIgnore]
        [Browsable(false)]

        public string GeneralCondition => $"{Uslov}";

        [JsonIgnore]
        [Browsable(false)]

        public string SelectValues => "distinct tu.IDTipUsluge, tu.NazivTipa";

        [JsonIgnore]
        [Browsable(false)]

        public string UpdateValues => "";

        [JsonIgnore]
        [Browsable(false)]

        public string InsertValues => "";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> tipoviUsluge = new List<IEntity>();
            using (reader)
            {
                while (reader.Read())
                {
                    tipoviUsluge.Add(new TipUsluge
                    {
                            IDTipUsluge = (int)reader["IDTipUsluge"],
                            NazivTipaUsluge = (string)reader["NazivTipa"]
                    });
                }
            }
            return tipoviUsluge;
        }

        public override string ToString()
        {
            return NazivTipaUsluge;
        }
        public override bool Equals(object obj)
        {
            if (obj is TipUsluge tu) return tu.NazivTipaUsluge == NazivTipaUsluge;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public IEntity GetOne(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
