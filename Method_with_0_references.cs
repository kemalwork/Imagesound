
void GetMusicTracks() //method called get music tracks which is voided meaning no value is returned
{
    try
    {

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();  //creates a connection which is stored in a variable called builder
        builder.DataSource = "imagesound17221.database.windows.net"; //established datasource for the database which is the server name
        builder.UserID = "azureuser"; //establishes username for database
        builder.Password = "Berrys786!@"; //establishes password for database
        builder.InitialCatalog = "imagesound"; //esablishes database name that is imported


        using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
        {
            Console.WriteLine("\nQuery data example:");
            Console.WriteLine("=========================================\n");

            connection.Open();

            String sql = @"SELECT Track_title, Track_genre, Track_time
                                     FROM tbl_Track
                                     WHERE Track_genre = 'Rock' AND Track_Time > '00:00:00'"; //sql statement to select fields based on track genre and track time 
                                                                                              //prevents tracks with 0 duration from being outputted

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} {1} {2}", reader.GetString(0), reader.GetString(1), reader.GetTimeSpan(2));
                    }
                }
            }
        }
    }
    catch (SqlException e)
    {
        Console.WriteLine(e.ToString());
    }
    Console.WriteLine("\nDone. Press enter.");
    Console.ReadLine();
}
    }
}
