namespace CT_access.Models
{
    public class Caminhao
    {
        public int id {  get; set; }
        public string nome { get; set; }
        public string empresa {  get; set; }
        public string setor { get; set; }
        public string placa { get; set; }
        public string cnh {  get; set; }
        public string motorista { get; set; }
        public string autorizado { get; set; }
        public DateTime data { get; set; }= DateTime.Now.Date;
        public string h_entrada { get; set; }
        public string h_saida { get;set; }
    }
  
}
