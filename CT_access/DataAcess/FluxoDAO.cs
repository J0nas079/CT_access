using CT_access.Interface;
using CT_access.Models;
using System.Data;
using System.Data.SQLite;

namespace CT_access.DataAcess
{
    public class FluxoDAO : IEntrada
    {
        public static DataTable GetCaminhao()
        {
            using (var connection = ConectionDb.Dbconection())
            {
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();
                SQLiteConnection con = ConectionDb.Dbconection();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM T_caminhoes";
                    cmd.ExecuteNonQuery();
                    da = new SQLiteDataAdapter(cmd.CommandText, con);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        //Inserindo os dados no Banco de Dados
        public void AdcionarCaminhao(Caminhao caminhao)
        {
            using SQLiteConnection connection = ConectionDb.Dbconection();
            string sql = @"INSERT INTO T_caminhoes(data,empresa,placa,setor,h_entrada,h_saida,cnh,motorista,autorizado)VALUES(
                             @data,
                             @empresa,
                             @placa,
                             @setor,
                             @h_entrada,
                             @h_saida,
                             @cnh,
                             @motorista,
                             @autorizado)";
            using (var cmd = new SQLiteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@data", caminhao.data);
                cmd.Parameters.AddWithValue("@empresa", caminhao.empresa);
                cmd.Parameters.AddWithValue("@placa", caminhao.placa);
                cmd.Parameters.AddWithValue("@setor", caminhao.setor);
                cmd.Parameters.AddWithValue("@h_entrada", caminhao.h_entrada);
                cmd.Parameters.AddWithValue("@h_saida", caminhao.h_saida);
                cmd.Parameters.AddWithValue("@cnh", caminhao.cnh);
                cmd.Parameters.AddWithValue("@motorista", caminhao.motorista);
                cmd.Parameters.AddWithValue("@autorizado", caminhao.autorizado);
                cmd.ExecuteNonQuery();
            }

        }
        //Atualizando os dados do Banco
        public void AtualizarCaminhao(Caminhao caminhao)
        {
           using SQLiteConnection connection= ConectionDb.Dbconection();
            {
                try
                {
                   string sql = "UPDATE T_caminhoes SET h_saida=@h_saida WHERE id=@id";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        //cmd.Parameters.AddWithValue("@data", caminhao.data);
                        //cmd.Parameters.AddWithValue("@empresa", caminhao.empresa);
                        //cmd.Parameters.AddWithValue("@placa", caminhao.placa);
                        //cmd.Parameters.AddWithValue("@setor", caminhao.setor);
                        //cmd.Parameters.AddWithValue("@h_entrada", caminhao.h_entrada);
                        cmd.Parameters.AddWithValue("@h_saida", caminhao.h_saida);
                        cmd.Parameters.AddWithValue("@id", caminhao.id);
                        //cmd.Parameters.AddWithValue("@cnh", caminhao.cnh);
                        //cmd.Parameters.AddWithValue("@motorista", caminhao.motorista);
                        //cmd.Parameters.AddWithValue("@autorizado", caminhao.autorizado);
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar Dados" + ex);
                }
            }
        }

        public void DeleterCaminhao(int id)
        {
            throw new NotImplementedException();
        }
        
        public List<Caminhao> DiaCamihao()
        {
            throw new NotImplementedException();
        }
        public static DataTable Search(string usuario)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using SQLiteConnection con = ConectionDb.Dbconection();
                string sql = @"SELECT * FROM T_caminhoes WHERE empresa LIKE '%"+ usuario+"%'ORDER BY data";
                da = new SQLiteDataAdapter(sql, con);
                da.Fill(dt);
                return dt;
            }catch (Exception ex)
            {
                throw;
            }
        }
        public List<Caminhao> ObterCaminhao()
        {
            try
            {
                using (var connection = ConectionDb.Dbconection())
                {
                    using SQLiteConnection con = ConectionDb.Dbconection();

                    DataTable dt = new DataTable();
                    SQLiteDataAdapter da = null;
                    var caminhoes = new List<Caminhao>();
                    string sql = @"SELECT * FROM T_caminhoes
                                    WHERE DATE(data) = DATE('now')";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var truck = new Caminhao()
                            {
                                id = reader.GetInt32(reader.GetOrdinal("id")),
                                data = Convert.ToDateTime(reader["data"]).ToLocalTime().Date,
                                empresa = reader["empresa"].ToString(),
                                placa = reader["placa"].ToString(),
                                setor = reader["setor"].ToString(),
                                h_entrada = reader["h_entrada"].ToString(),
                                h_saida = reader["h_saida"].ToString(),
                                cnh = reader["cnh"].ToString(),
                                motorista = reader["motorista"].ToString(),
                                autorizado = reader["autorizado"].ToString()
                            };
                            caminhoes.Add(truck);
                            da=new SQLiteDataAdapter(sql,con);
                            da.Fill(dt);
                        }
                        return caminhoes;
                    }
                     
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro ao fazer o select " + ex.Message);
                return new List<Caminhao>();
            }
            
        }

        public bool Validaruser(Usuario usuario)
        {
            bool validado = false;
            using SQLiteConnection con=ConectionDb.Dbconection();
            string sql = @"SELECT COUNT(1) FROM T_usuarios WHERE usuario=@usuario AND senha=@senha";
            using(var cmd=new SQLiteCommand(sql,con))
            {
                cmd.Parameters.AddWithValue("@usuario", usuario.usuario);
                cmd.Parameters.AddWithValue("@senha", usuario.senha);
                int count =Convert.ToInt32(cmd.ExecuteScalar());
                validado=(count>0);
                
            }
            return validado;
        }
       
    }
}
