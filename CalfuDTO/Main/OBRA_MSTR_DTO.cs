using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalfuDTO.Main
{
    public class OBRA_MSTR_DTO
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
    }
}
