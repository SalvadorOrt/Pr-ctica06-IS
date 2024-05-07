using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PacientesNegocio
    {
        
        public List<Pacientes> ListarPacientes()
        {
            PacientesDatos datos1 = new PacientesDatos();
            List<Pacientes> pacientes = datos1.Listar();
            return pacientes;
        }
        public Pacientes ListarPacientesXId(int id)
        {
            PacientesDatos datos1 = new PacientesDatos();
            Pacientes paciente = datos1.Listar().Where(c => c.PacienteID== id).SingleOrDefault();
            return paciente;
        }


    }
}
