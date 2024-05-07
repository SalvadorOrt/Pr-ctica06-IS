using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MedicosDatos : IDatos<Medicos>
    {
        CitasMedicasEntities contexto;
        public MedicosDatos()
        {
            contexto = new CitasMedicasEntities();
        }
        public bool Actualizar(Medicos item)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Medicos item)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Medicos item)
        {
            try
            {
                contexto.Medicos.Add(item);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Medicos> Listar()
        {
            return contexto.Medicos.ToList();
        }
    }
}
