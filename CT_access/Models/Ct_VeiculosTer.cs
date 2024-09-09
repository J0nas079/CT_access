﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_access.Models
{
    public class Ct_VeiculosTer
    {
        public int id { get; set; }
        public string empresa {  get; set; }
        public DateTime data {  get; set; }= DateTime.Now.Date;
        public string h_entrada {  get; set; }
        public string h_saida { get; set; }
        public string nome { get; set; }
        public string  placa {get; set; }
        public string fabrica {get; set; }
        public string autorizado { get; set; }
        public string  cnh { get; set; }
    }
}