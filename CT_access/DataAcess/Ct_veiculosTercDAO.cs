using CT_access.Interface;
using CT_access.Models;
using CT_access.Views;
using System.Data;
using System.Data.SQLite;

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
            var VeiculosTer = new List<Ct_VeiculosTer>();
            try
            {
                using (var con = ConectionDb.Dbconection())
                {
                    //con.Open();
                    string sql = "SELECT * FROM T_CtVeiculosTercei";
                    using (var cmd = new SQLiteCommand(sql, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var Veicutorer = new Ct_VeiculosTer()
                                {
                                    id = Convert.ToInt32(reader["id_veiculosTer"]),
                                    empresa = reader["empresa"].ToString(),
                                    data = Convert.ToDateTime(reader["data"]),
                                    h_entrada = reader["horaEntrada"].ToString(),
                                    h_saida = reader["horaSaida"].ToString(),
                                    nome = reader["nome"].ToString(),
                                    placa = reader["placa"].ToString(),
                                    fabrica = reader["fabrica"].ToString(),
                                    autorizado = reader["autorizado"].ToString(),
                                    cnh = reader["cnh"].ToString()
                                };
                                VeiculosTer.Add(Veicutorer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return VeiculosTer;
        }


        public List<Ct_VeiculosTer> PesquisaId(int id)
        {
            throw new NotImplementedException();
        }

        public void SetvTerceiro(Ct_VeiculosTer ctVeiculosTercei)
        {
            //string FormateDate = ctVeiculosTercei.data.ToString("dd-MM-yyyy");
            using SQLiteConnection connection = ConectionDb.Dbconection();
            string sql = "INSERT INTO T_CtVeiculosTercei (empresa,data,horaEntrada,horaSaida,nome,placa,fabrica," +
                "autorizado,cnh)VALUES(@empresa,@data,@horaEntrada,@horaSaida,@nome,@placa,@fabrica,@autorizado," +
                "@cnh)";
            using (var cmd = new SQLiteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@empresa", ctVeiculosTercei.empresa);
                cmd.Parameters.AddWithValue("@data", ctVeiculosTercei.data.ToString("dd-MM-yyyy"));
                cmd.Parameters.AddWithValue("@horaEntrada", ctVeiculosTercei.h_entrada);
                cmd.Parameters.AddWithValue("@horaSaida", ctVeiculosTercei.h_saida);
                cmd.Parameters.AddWithValue("@nome", ctVeiculosTercei.nome);
                cmd.Parameters.AddWithValue("@placa", ctVeiculosTercei.placa);
                cmd.Parameters.AddWithValue("@fabrica", ctVeiculosTercei.fabrica);
                cmd.Parameters.AddWithValue("@autorizado", ctVeiculosTercei.autorizado);
                cmd.Parameters.AddWithValue("@cnh", ctVeiculosTercei.cnh);
                cmd.ExecuteNonQuery();
            }

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
