using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Ejercicio_1.Models;

namespace Ejercicio_1.Data
{
    internal class CostoVariableDAO
    {
        string connectionString = "Server=DESKTOP-3M720L6; Database=PruebaADO; Integrated Security=True;";
        
        public List<CostoVariableDTO> GetcostrovariableDTO(int id)
        {
            string queqry = "select * from "
            using(SqlConnection conn = new SqlConnection(connectionString))
            {




            }


        }
        




    }
}
