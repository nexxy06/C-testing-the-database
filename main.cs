 public void CreateSQL(string file)
 {
     using (var connecting = new SQLiteConnection($"Data Source={file};"))
     {
         connecting.Open();
         using (var cmd = new SQLiteCommand(connecting))
         {
             cmd.CommandText = @"DROP TABLE IF EXISTS Name";
             cmd.ExecuteNonQuery();
             cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Name(Id INTEGER PRIMARY KEY, txt TEXT)";
             cmd.ExecuteNonQuery();
         }
     }
 }
