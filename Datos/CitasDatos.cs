using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CitasDatos : IDatos<Citas>
    {
        CitasMedicasEntities contexto;
        public CitasDatos()
        {
            contexto = new CitasMedicasEntities();
        }
        public bool Actualizar(Citas item)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Citas item)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Citas item)
        {
            try
            {
                contexto.Citas.Add(item);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Citas> Listar()
        {
            return contexto.Citas.ToList(); 
        }
    }
}
