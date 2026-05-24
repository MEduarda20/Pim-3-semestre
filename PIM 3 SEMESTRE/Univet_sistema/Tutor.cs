using System;

namespace UNIVET.Models
{
    public class Tutor
    {
        public int CdTutor { get; set; }
        public string NmTutor { get; set; }
        public string NrTelefone { get; set; }
        public string DsEmail { get; set; }
        
        private string _nrCpf;
        public string NrCpf
        {
            get { return _nrCpf; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O CPF é obrigatório.");
                }
                string cpfLimpo = value.Replace(".", "").Replace("-", "");
                if (cpfLimpo.Length != 11)
                {
                    throw new ArgumentException("O CPF deve conter exatamente 11 dígitos numéricos.");
                }
                _nrCpf = cpfLimpo;
            }
        }
    }
}