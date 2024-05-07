using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CitasNegocio
    {

        public List<Citas> ListarCitas()
        {
            CitasDatos datos3 = new CitasDatos();
            List<Citas> citas = datos3.Listar();
            return citas;
        }

        public Citas ListarCitasXId(int id)
        {
            CitasDatos datos3 = new CitasDatos();
            Citas citas = datos3.Listar().Where(c => c.CitaID == id).SingleOrDefault();
            return citas;
        }

    }
}
