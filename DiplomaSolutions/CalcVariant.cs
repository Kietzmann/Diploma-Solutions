using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaSolutions
{
    public enum CalcVariant
    {
        [Description("По міжосьовій відстані")]
        BetweenAxesDistance,
        [Description("По коефіціенту зміщення черв'яка")]
        WormCoef
    }
}
