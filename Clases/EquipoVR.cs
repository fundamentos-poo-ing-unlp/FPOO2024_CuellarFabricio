using System.Data.SQLite;

namespace TIv2.Clases
{
    public class EquipoVR : Equipo
    {
        // ******* ATRIBUTOS *******
        private string rutadB;
        public EquipoVR(int id, string descripcion, string rutaDb) : base(id, descripcion)
        {
            rutadB = rutaDb;
            InfoRegistros();
        }

        // ******* MÉTODOS *******
        public override void AgregarVia(Via v) => vias.Add(v);
        public override void InfoRegistros()
        {
            string[] rangosHoras = ["00:00:00", "06:00:00", "12:00:00", "18:00:00", "23:59:59"];
            int[] v_count = new int[10];
            string qry = @"SELECT COUNT(*) FROM [datos] WHERE via = @via AND (hora BETWEEN @f1 AND @f2);";
            string connectionString = $@"Data Source={rutadB}";
            SQLiteConnection connection = new(connectionString);
            connection.Open();
            SQLiteCommand command = new(connection);
            command.CommandText = qry;

            for (int j = 0; j < rangosHoras.Length - 1; j++)
            {
                for (int i = 0; i < v_count.Length; i++)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@f1", rangosHoras[j]);
                    command.Parameters.AddWithValue("@f2", rangosHoras[j + 1]);
                    command.Parameters.AddWithValue("@via", i + 1);
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        v_count[i] = reader.GetInt32(0);
                        totalVehiculosXvia[i] += v_count[i];
                    }
                    reader.Close();
                }
                list_info_struct.Add(new info(rangosHoras[j], v_count));
            }
        }
    }
}