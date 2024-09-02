using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_access.Models
{
    public class CtVeiuloEmp
    {
        public int idVeiulo { get; set; }       
        public string Vigilante {  get; set; }
        public string itinerario { get; set; }
        public DateTime data { get; set; }
        public string horasaida { get; set; }
        public string horaentrada { get; set; }
        public string horfinal { get; set; }
        public string kmSaida { get; set; }
        public string kmchentrada { get; set; }
        public string kmrodados { get; set; }
        public string motorista { get; set; }
        public string Matricula {  get; set; }
        public string Observacoes { get; set; }
        public DateTime Date_entrada { get; set; }
        //public string Abastecimento {  get; set; }
    }
}
