using AccesoDatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace API_soa
{
    /// <summary>
    /// Descripción breve de ServiciosPacientes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiciosPacientes : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Pacientes> Listado_Pacientes()
        {
            PacientesNegocio datos1 = new PacientesNegocio();
            List<Pacientes> lista = datos1.ListarPacientes();
            return lista;
        }

        [WebMethod]
        public List<Citas> Listado_Citas()
        {
            CitasNegocio datos1 = new CitasNegocio();
            List<Citas> lista = datos1.ListarCitas();
            return lista;
        }
        [WebMethod]
        public List<Medicos> Listado_Medicos()
        {
            MedicosNegocio datos1 = new MedicosNegocio();
            List<Medicos> lista = datos1.ListarMedicos();
            return lista;
        }
    }
}
