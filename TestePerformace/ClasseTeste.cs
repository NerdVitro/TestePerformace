using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePerformace
{
    public class ClasseTeste
    {
        private int _IDDOCARA;
        private string _NOMECARA;

        public int IDDOCARA { get => _IDDOCARA; set => _IDDOCARA = value; }
        public string NOMECARA { get => _NOMECARA; set => _NOMECARA = value; }

        public ClasseTeste(int iDDOCARA, string nOMECARA)
        {
            _IDDOCARA = iDDOCARA;
            _NOMECARA = nOMECARA;
        }
        public ClasseTeste()
        {

        }
    }
}
