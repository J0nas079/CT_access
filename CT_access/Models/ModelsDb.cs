using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CT_access.Models
{
    //Db de Veiculos externos 
    public class CtVeiculosTercei
    {
        public int idVeiculos { get; set; }
        public string movimento { get; set; }
        public string data { get; set; }
        public double horaEntrada { get; set; }
        public double horaSaida { get; set; }
        public double horaFinal { get; set; }
        public string motoristamotorista { get; set; }
        public string veiculo { get; set; }
        public int placa { get; set; }
        public int notaFiscal { get; set; }
        public string observacao { get; set; }
    } 
}