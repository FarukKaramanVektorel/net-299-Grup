using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_09_2026
{
    // Kargo Durumları
    // 0 Şubeye Teslim Edildi
    // 1 Şubeden aktarma merkezine yola çıktı
    // 2 il dışı aktarmada
    // 3 aktarma merkezinden şubeya yola çıktı
    // 4 dağıtım şubesine ulaştı
    // 5 dağıtıma çıktı
    // 6 teslim edildi
    // 7 adreste bulunamadı
    // 8 iade edildi
    enum Status
    {
        [Description("Teslim Şubesi Tarafından Teslim Alındı")]
        SubeyeTeslimEdildi=0,// 0
        [Description("Teslim Şubesinden Aktarma Merkezine Yolda")]
        SubedenAktarmaMerkezine=1,// 1
        [Description("İl Dışı Aktarmada")]
        IlDisiAktarma=2,// 2
        [Description("Aktarma Merkezinden Teslim Şubesine Yolda")]
        AktarmaMerkezindenSubeye=3,// 3
        [Description("Dağıtım Şubesi Tarafından Teslim Alındı")]
        DagitimSubesinde=4,// 4
        [Description("Dağıtım Şubesi Tarafından Dağıtıma Çıktı")]
        Dagitimda=5,// 5
        [Description("Teslim Edildi")]
        TeslimEdildi=6,// 6
        [Description("Geldik Yoktunuz")]
        AdresteBulunamadi=7,// 7
        [Description("İade Edildi")]
        IadeEdildi=8// 8
    }
}
