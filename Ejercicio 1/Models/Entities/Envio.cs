using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models.Entities
{
    internal class Envio
    {
        public int Id { get; set; }
        public double ValorTotal { get; set; }

        public override string ToString()
        {
            return $"{Id} - {ValorTotal}";
        }
    }
}
