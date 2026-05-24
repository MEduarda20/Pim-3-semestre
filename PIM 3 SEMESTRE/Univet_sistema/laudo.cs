using System;

namespace UNIVET.Models
{
    public class Laudo
    {
        public int CdLaudo { get; set; }
        public int CdPaciente { get; set; }
        public int CdVeterinario { get; set; }
        public int CdExame { get; set; }
        public DateTime DtEmissao { get; set; }
        public string DsResultado { get; set; }
        public string DsStatus { get; set; }
    }
}