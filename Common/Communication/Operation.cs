using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public enum Operation
    {
        Login,
        UcitajListuTipovaUsluga,
        DodajUslugu,
        DodajKlijenta,
        UcitajListuKlijenata,
        IzmeniKlijenta,
        PretraziKlijente,
        UcitajListuUsluga,
        IzbrisiUslugu,
        IzmeniUslugu,
        UcitajListuUslugaPoTipu,
        UcitajListuZaposlenihPoTipuUsluge,
        UcitajListuRezervacijaZaDatumIZaposlenog,
        UcitajListuRezervacija,
        UcitajKlijenta,
        UcitajUslugu,
        SacuvajRezervacije,
        ProveriDostupnostTermina,
        IzbrisiRezervaciju,
        UcitajListuZaposlenih,
        UcitajListuTipovaUslugaPoZaposlenom,
        IzmeniZaposlenog,
        UcitajZaposlenog
    }
}
