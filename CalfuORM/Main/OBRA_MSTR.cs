//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalfuORM.Main
{
    using System;
    using System.Collections.Generic;
    
    public partial class OBRA_MSTR
    {
        public int OBRA_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string ALIAS { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal LARGO { get; set; }
        public decimal ANCHO { get; set; }
        public int TIPO_OBRA_ID { get; set; }
        public int ME_GUSTA { get; set; }
        public int NO_ME_GUSTA { get; set; }
        public int FLAG_VIGENTE { get; set; }
    }
}
