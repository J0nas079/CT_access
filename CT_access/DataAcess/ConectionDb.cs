using System.Data.SQLite;

namespace CT_access.DataAcess
{
    public class ConectionDb
    {
        private static string Path = Directory.GetCurrentDirectory() + "Ct_Dok.sqlite";
        private static SQLiteConnection sqlitecconetcion;
        public static SQLiteConnection Dbconection()
        {
            sqlitecconetcion = new SQLiteConnection("Data Source=" + Path);
            sqlitecconetcion.Open(); 
            return sqlitecconetcion;
        }
        public static void CurrentDBDiretory()
        {
            try
            {
                if (File.Exists(Path) == false)
                {
                    SQLiteConnection.CreateFile(Path);
                }
            }
            catch
            {
                throw;
            }
        }
        public static void CreateTable()
        {           
            try
            {
                using (var cmd = Dbconection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS T_usuarios(" +
                        "id_usuario INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "nome TEXT NOT NULL," +
                        "usuario TEXT NOT NULL," +
                        "senha TEXT NOT NULL)";
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = Dbconection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS T_CtVeiculosTercei(id_veiculosTer INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "empresa TEXT," +
                        "data DATETIME," +
                        "horaEntrada VARCHAR(10)," +
                        "horaSaida VARCHAR(10)," +
                        "nome VARCHAR(40)," +
                        "placa TEXT," +
                        "fabrica VARCHAR(30)," +
                        "autorizado VARCHAR(20)," +
                        "cnh VARCHAR(20))";
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = Dbconection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS T_caminhoes(" +
                        "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "data DATIME DEFAULT CURRENT_TIMESTAMP," +
                        "empresa VARCHAR(50)," +
                        "placa VARCHAR(25)," +
                        "setor VARCHAR(50)," +
                        "h_entrada VARCHAR(10)," +
                        "h_saida VARCHAR(10)," +
                        "cnh VARCHAR(35)," +
                        "motorista VARCHAR(45) NOT NULL," +
                        "autorizado VARCHAR (60) NOT NULL)";
                    cmd.ExecuteNonQuery();
                }

                using(var cmd = Dbconection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS T_veiculoEmp(" +
                        "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "data DATIME DEFAULT CURRENT_TIMESTAMP," +
                        "itinerario TEXT," +
                        "h_saida VARCHAR(12)," +
                        "h_entrada VARCHAR(12)," +
                        "h_final VARCHAR(12)," +
                        "kmSaida VARCHAR(10)," +
                        "kmchentrada VARCHAR(10)," +
                        "kmrodados VARCHAR(10)," +
                        "motorista TEXT NOT NULL," +
                        "Observacoes VARCHAR(100)," +
                        "Vigilante VARCHAR(15))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao criar tabela" + ex);
            }
        }
        //private static void usuarioPadrao()
        //{
        //    using (var cmd = Dbconection().CreateCommand())
        //    {
        //        cmd.CommandText="CREATE"
        //    }
        //}
    }

}
