//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Citas
    {
        public int CitaID { get; set; }
        public Nullable<int> PacienteID { get; set; }
        public Nullable<int> MedicoID { get; set; }
        public Nullable<System.DateTime> FechaHoraCita { get; set; }
        public Nullable<bool> EstadoCita { get; set; }
    
        public virtual Medicos Medicos { get; set; }
        public virtual Pacientes Pacientes { get; set; }
    }
}
