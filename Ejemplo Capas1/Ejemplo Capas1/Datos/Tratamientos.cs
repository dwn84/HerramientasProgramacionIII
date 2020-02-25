using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Capas1
{
    class Tratamientos
    {
        private string traIdPaciente;
        private DateTime traFechaAsignado;
        private string traDetalles;
        private DateTime traFechaIni;
        private DateTime traFechaFin;
        private string traObservaciones;

        public string TraIdPaciente { get => traIdPaciente; set => traIdPaciente = value; }
        public DateTime TraFechaAsignado { get => traFechaAsignado; set => traFechaAsignado = value; }
        public string TraDetalles { get => traDetalles; set => traDetalles = value; }
        public DateTime TraFechaIni { get => traFechaIni; set => traFechaIni = value; }
        public DateTime TraFechaFin { get => traFechaFin; set => traFechaFin = value; }
        public string TraObservaciones { get => traObservaciones; set => traObservaciones = value; }
    }
}
