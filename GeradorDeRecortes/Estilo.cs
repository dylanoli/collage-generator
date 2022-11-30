using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeRecortes
{
    public class Estilo
    {
        public Estilo(BaseColor cor1, BaseColor cor2)
        {
            Cor1 = cor1;
            Cor2 = cor2;
        }

        public BaseColor Cor1 { get; }
        public BaseColor Cor2 { get; }
    }
}
