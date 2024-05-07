using AccesoDatos;
using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            PacientesNegocio datos1 = new PacientesNegocio();
            List<Pacientes> lista = datos1.ListarPacientes();
            foreach (var datos in lista)
            {
                Console.WriteLine(datos.PacienteID + " " + datos.Nombre + " " + datos.Apellido + " " + datos.FechaNacimiento);
            }



            //PacientesDatos datos1 = new PacientesDatos();
            //List<Pacientes> pacientes = datos1.Listar();

            //MedicosDatos datos2 = new MedicosDatos();
            //List<Medicos> medicos = datos2.Listar();

            //CitasDatos datos3 = new CitasDatos();
            //List<Citas> citas = datos3.Listar();
            
            //Console.WriteLine("Pacientes\n");
            //foreach (var datos in pacientes)
            //{
            //    Console.WriteLine(datos.PacienteID+" "+datos.Nombre+" "+datos.Apellido+" "+datos.FechaNacimiento);
            //}
            //Console.WriteLine("Medicos\n");
            //foreach (var datos in medicos)
            //{
            //    Console.WriteLine(datos.MedicoID + " " + datos.Nombre + " " + datos.Apellido + " " + datos.Especialidad);
            //}
            //Console.WriteLine("Citas\n");
            //foreach (var datos in citas)
            //{
            //    Console.WriteLine(datos.CitaID + " " + datos.PacienteID + " " + datos.MedicoID);
            //}
            Console.ReadKey();
        }
    }
}
