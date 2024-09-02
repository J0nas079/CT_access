using CT_access.Interface;
using CT_access.Models;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace CT_access.DataAcess
{
    public class VeiculosEmpDAO : IctEmpresa
    {
        public void DelDado(int id)
        { 
            throw new NotImplementedException();

        }
        public static DataTable GetDADOS()
        {
                using (var conection = ConectionDb.Dbconection())
                {
                    SQLiteDataAdapter dataAdapter = null;
                    DataTable dt = new DataTable();
                    SQLiteDataAdapter da = null;

                    SQLiteConnection con = ConectionDb.Dbconection();
                    using (var cmd = conection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM T_veiculoEmp";
                        cmd.ExecuteNonQuery();
                        da = new SQLiteDataAdapter(cmd.CommandText, con);
                        da.Fill(dt);
                        return dt;
                    }
                }
            }

        public List<CtVeiuloEmp> GetVeiculos()
        {
            try
            {
                using(var connection =ConectionDb.Dbconection())
                {
                    using SQLiteConnection con = ConectionDb.Dbconection();
                    DataTable dt = new DataTable();
                    SQLiteDataAdapter da = null;
                    var t_carros = new List<CtVeiuloEmp>();
                    string sql = @"SELECT * FROM T_veiculoEmp";
                    using(var cmd=new SQLiteCommand(sql, connection))
                    using(var reader= cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var car = new CtVeiuloEmp()
                            {
                                idVeiulo = reader.GetInt32(reader.GetOrdinal("id")),
                                data = Convert.ToDateTime(reader["data"]).ToLocalTime(),
                                itinerario = reader["itinerario"].ToString(),
                                horasaida = reader["h_saida"].ToString(),
                                horaentrada = reader["h_entrada"].ToString(),
                                horfinal = reader["h_final"].ToString(),
                                kmSaida = reader["kmSaida"].ToString(),
                                kmchentrada = reader["kmchentrada"].ToString(),
                                kmrodados = reader["kmrodados"].ToString(),
                                motorista = reader["motorista"].ToString(),
                                Observacoes = reader["Observacoes"].ToString(),
                                Vigilante = reader["Vigilante"].ToString(),
                                Matricula = reader["Matricula"].ToString(),
                                //Date_entrada = Convert.ToDateTime(reader["data_entrada"]).ToLocalTime(),
                            };
                            t_carros.Add(car);
                            da = new SQLiteDataAdapter(sql,connection);
                            da.Fill(dt);
                        }
                       
                    }
                    return t_carros;

                }
                
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<CtVeiuloEmp>();
            }
       
        }

        public void SetVeiculos(CtVeiuloEmp ctVeiuloEmp)
        {
            using SQLiteConnection connection = ConectionDb.Dbconection();
            string sql = @"INSERT INTO T_veiculoEmp(
                                                    data,
                                                    itinerario,
                                                    h_saida,
                                                    h_entrada,
                                                    h_final,
                                                    kmSaida,
                                                    kmchentrada,
                                                    kmrodados,
                                                    motorista,
                                                    Observacoes,
                                                    Vigilante,
                                                    Matricula)
                                                    VALUES(
                                                    @data,
                                                    @itinerario,
                                                    @h_saida,
                                                    @h_entrada,
                                                    @h_final,
                                                    @kmSaida,
                                                    @kmchentrada,
                                                    @kmrodados,
                                                    @motorista,
                                                    @Observacoes,
                                                    @Vigilante,
                                                    @Matricula
                                                    )";
            using (var cmd=new SQLiteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@data", ctVeiuloEmp.data);
                cmd.Parameters.AddWithValue("@itinerario",ctVeiuloEmp.itinerario);
                cmd.Parameters.AddWithValue("@h_saida", ctVeiuloEmp.horasaida);
                cmd.Parameters.AddWithValue("@h_entrada", ctVeiuloEmp.horaentrada);
                cmd.Parameters.AddWithValue("@h_final", ctVeiuloEmp.horfinal);
                cmd.Parameters.AddWithValue("@kmSaida", ctVeiuloEmp.kmSaida);
                cmd.Parameters.AddWithValue("@kmchentrada", ctVeiuloEmp.kmchentrada);
                cmd.Parameters.AddWithValue("@kmrodados", ctVeiuloEmp.kmrodados);
                cmd.Parameters.AddWithValue("@motorista", ctVeiuloEmp.motorista);
                cmd.Parameters.AddWithValue("@Observacoes", ctVeiuloEmp.Observacoes);
                cmd.Parameters.AddWithValue("@Vigilante", ctVeiuloEmp.Vigilante);
                cmd.Parameters.AddWithValue("@Matricula", ctVeiuloEmp.Matricula);
                cmd.ExecuteNonQuery();

            }
        }

        public void updateDados(CtVeiuloEmp ctVeiuloEmp)
        {
            using (var connection = ConectionDb.Dbconection())
            {
                try
                {
                    using (var cmd = connection.CreateCommand()) 
                    {
                        cmd.CommandText="UPDATE T_veiculoEmp SET h_entrada=@h_entrada,kmchentrada=@kmchentrada WHERE id=@id";
                        cmd.Parameters.AddWithValue("@id", ctVeiuloEmp.idVeiulo);
                        cmd.Parameters.AddWithValue("@h_entrada", ctVeiuloEmp.horaentrada);
                        cmd.Parameters.AddWithValue("@kmchentrada", ctVeiuloEmp.kmchentrada);
                        //cmd.ExecuteNonQuery();
                        int rowsAfetadas = cmd.ExecuteNonQuery();
                        if (rowsAfetadas > 0)
                        {
                            MessageBox.Show("Dados atualizados com sucesso!!!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma linha foi atualizada");
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao atualizar dados" + e.Message);
                }
            }
        }

        public void Getdados(int id)
        {
            throw new NotImplementedException();
        }
    }
}
