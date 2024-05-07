using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PacientesDatos : IDatos<Pacientes>
    {
        CitasMedicasEntities contexto;
        public PacientesDatos()
        {
            contexto = new CitasMedicasEntities();
        }
        public bool Actualizar(Pacientes item)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Pacientes item)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Pacientes item)
        {
            try
            {
                contexto.Pacientes.Add(item);   
                contexto.SaveChanges();
                return true;
            }catch (Exception )
            {
                return false;
            }
        }

        public List<Pacientes> Listar()
        {
            return contexto.Pacientes.ToList(); 
        }
    }
}
