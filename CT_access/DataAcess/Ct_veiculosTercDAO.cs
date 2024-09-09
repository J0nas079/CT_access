using CT_access.Interface;
using CT_access.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CT_access.DataAcess
{
    public class Ct_veiculosTercDAO : ICt_Vtercei
    {
        public void DeletarVter(Ct_VeiculosTer ctVeiculosTercei)
        {
            throw new NotImplementedException();
        }

        public List<Ct_VeiculosTer> GetCtVeiculosTerceis()
        {
            var VeiculosTer=new List<Ct_VeiculosTer>();
            try
            {
                using (var con = ConectionDb.Dbconection())
                {
                    DataTable dataTable = new DataTable();
                    SQLiteDataAdapter da = null;
                    string sql = @"SELECT * FROM T_CtVeiculosTercei";
                    using(var cmd=new SQLiteCommand(sql, con))
                    using (var reader = cmd.ExecuteReader())
                    { 
                        while (reader.Read())
                        {
                            var Veicutorer = new Ct_VeiculosTer()
                            {
                                id = reader.GetInt32(0),
                                empresa = reader["empresa"].ToString(),
                                data = Convert.ToDateTime(reader["data"]).ToLocalTime(),
                                h_entrada = reader["horaEntrada"].ToString(),
                                h_saida = reader["horaSaida"].ToString(),
                                nome = reader["nome"].ToString(),
                                placa = reader["placa"].ToString(),
                                fabrica = reader["fabricante"].ToString(),
                                autorizado = reader["autorizado"].ToString(),
                                cnh = reader["cnh"].ToString()
                            };
                            VeiculosTer.Add(Veicutorer);
                        }
                    }
                    return VeiculosTer;
                
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return VeiculosTer;
            }
        }

        public List<Ct_VeiculosTer> PesquisaId(int id)
        {
            throw new NotImplementedException();
        }

        public void SetvTerceiro(Ct_VeiculosTer ctVeiculosTercei)
        {
            throw new NotImplementedException();
        }

        public void UpdateDados(Ct_VeiculosTer ctVeiculosTercei)
        {
            throw new NotImplementedException();
        }

        List<CtVeiculosTercei> ICt_Vtercei.GetCtVeiculosTerceis()
        {
            throw new NotImplementedException();
        }
    }
}
