using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_ENUM
{
    public enum SiparisDurumu
    {
        siparisAlindi =0,
        kargoda =0,
        teslimEdildi =2,
        iptalEdildi=3
    }

    public enum UrunDurumu
    {
        stoktaYok=10,
        stoktaVar=11,
        pasifSatis=12
    }

    public enum CalisanDurum
    {
        AktifGorevde,
        AktifIzinde,
        IstenAyrildi
    }
}
