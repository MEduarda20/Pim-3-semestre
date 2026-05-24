using System;

namespace UNIVET.Models
{
    public class Paciente
    {
        public int CdPaciente { get; set; }
        public int CdTutor { get; set; }
        public string NmPaciente { get; set; }
        public string DsEspecie { get; set; }
        public string DsRaca { get; set; }
        public DateTime DtNascimento { get; set; }
    }
}