using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csillagjegyek
{
    class Horoszkop
    {
        int honap,
            fordulonap;
        string kezdoCsillagjegy,
            vegeCsillagjegy;

        public Horoszkop(int honap, int fordulonap, string kezdoCsillagjegy, string vegeCsillagjegy)
        {
            this.honap = honap;
            this.fordulonap = fordulonap;
            this.kezdoCsillagjegy = kezdoCsillagjegy;
            this.vegeCsillagjegy = vegeCsillagjegy;
        }

        public int Honap { get => honap; set => honap = value; }
        public int Fordulonap { get => fordulonap; set => fordulonap = value; }
        public string KezdoCsillagjegy { get => kezdoCsillagjegy; set => kezdoCsillagjegy = value; }
        public string VegeCsillagjegy { get => vegeCsillagjegy; set => vegeCsillagjegy = value; }
    }
}
