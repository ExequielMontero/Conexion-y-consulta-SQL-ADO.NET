using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models.Entities
{
    internal class CostoVariable
    {
        public int Id { get; set; }
        public string Concepto { get; set; }
        public decimal ValorFinal { get; set; }
        public int Id_Envio { get; set; }
        public double PrecioPorUnidad { get; set; }
        public double Unidades { get; set; }
    }
}
