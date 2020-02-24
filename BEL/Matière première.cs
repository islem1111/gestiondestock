using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Matière_première
    {
        public string TAG { get; set; }
        public string libellé { get; set; }
        public float prix { get; set; }
        public string image { get; set; }
        public string fournisseur { get; set; }
        public DateTime Date_entrée { get; set; }
        public DateTime Date_expiration { get; set; }
    }
}
