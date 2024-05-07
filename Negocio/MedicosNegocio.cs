using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MedicosNegocio
    {
        
        public List<Medicos> ListarMedicos()
        {
            MedicosDatos datos3 = new MedicosDatos();
            List<Medicos> medicos = datos3.Listar();
            return medicos;
        }

        public Medicos ListarCitasXId(int id)
        {
            MedicosDatos datos3 = new MedicosDatos();
            Medicos medicos = datos3.Listar().Where(c => c.MedicoID == id).SingleOrDefault();
            return medicos;
        }

    }
}
