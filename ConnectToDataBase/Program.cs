using MySql.Data.MySqlClient;

string ConStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Connect Timeout=30";
MySqlConnection con = new MySqlConnection(ConStr);




long recCount = 0;
MySqlCommand mySqlCommand = new MySqlCommand();
mySqlCommand.Connection = con;
mySqlCommand.CommandText = "SELECT COUNT(*) FROM nextcare_form";
recCount = (Int64)mySqlCommand.ExecuteScalar();



List<ConnectToDataBase.Item> ls = new List<ConnectToDataBase.Item>();

if (recCount > 0)
{
    mySqlCommand.CommandText = "SELECT * FROM nextcare_form";
    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
    
    while (mySqlDataReader.Read())
    {
        if (!DBNull.Value.Equals(mySqlDataReader.GetValue(0)))
        {
            ConnectToDataBase.Item b = new();
            b.Item1 = (string)mySqlDataReader.GetValue(0);
            ls.Add(b);
        }

        if (!DBNull.Value.Equals(mySqlDataReader.GetValue(1)))
        {

            ConnectToDataBase.Item b = new();
            b.Item2 = (string)mySqlDataReader.GetValue(1);
            ls.Add(b);

        }

    }

    ls.ForEach(x => global::System.Console.WriteLine(x.Item1 + " " + x.Item2));




}

