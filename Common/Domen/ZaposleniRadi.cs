using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domen
{
    [Serializable]
    public class ZaposleniRadi:IEntity
    {
        public Zaposleni Zaposleni { get; set; }
        public TipUsluge TipUsluge { get; set; }

        public string TableName => "ZaposleniRadi";

        public string TableAlias => "zr";
        public string JoinTable => "";

        public string JoinCondition => "";

        public string WhereCondition => $" IDZaposleni = {Zaposleni.IDZaposleni}";
                
        public string GeneralCondition => $"IDTipUsluge = {TipUsluge.IDTipUsluge}";

        public string SelectValues => "*";

        public string UpdateValues => "";

        public string InsertValues => $"{Zaposleni.IDZaposleni}, {TipUsluge.IDTipUsluge}";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            return null;
        }

        public IEntity GetOne(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
