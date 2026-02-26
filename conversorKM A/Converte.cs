using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversorKM_A
{
    internal class Converte
    {
        private string valor;

        public void setV(string _valor) {valor = _valor;}
        public string getV() { return valor;}

        public string converteKM() { return (float.Parse(valor) * 1.60934).ToString(); }
        public string converteMilhas() { return (float.Parse(valor) / 1.60934).ToString(); }
    }
}
