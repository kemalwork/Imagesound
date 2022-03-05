using System;  //imports the collection system which adds more functionality
using System.Data.SqlClient; //imports the collection system which adds more functionality with sql and database connection capabilities
using System.Text; //imports the collection system text which adds more functionality

namespace sqltest //creates namespace or project called 'sql test'
{
    class Program //creates class called program which is run
    {
        static void Main(string[] args) //creates method called main which passes a sequence of strings when the program is run
        {
            try
            {

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();  //creates a connection which is stored in a variable called builder
                builder.DataSource = "imagesound17221.database.windows.net"; //established datasource for the database which is the server name
                builder.UserID = "azureuser"; //establishes username for database
                builder.Password = "Berrys786!@"; //establishes password for database
                builder.InitialCatalog = "imagesound"; //esablishes database name that is imported

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString)) //creates a new connection to the stated database above stored in a variable called connection
                {
                    Console.WriteLine("\nQuery data example:");  //outputs message for user
                    Console.WriteLine("=========================================\n"); //outputted for user as a visual division between the query result and text above

                    connection.Open(); //opens the connection

                    String sql = @"SELECT Artist_id, Track_title, Track_genre, Track_time 
                                     FROM tbl_Album
                                     INNER JOIN tbl_Track
                                     ON tbl_Album.Album_id = tbl_Track.Album_id
                                     WHERE YEAR(Track_date) = '2022'
                                     ORDER BY Artist_id, Track_title ASC"; //sql statement which selects the required fields using an inner join and a set of requirements

                    using (SqlCommand command = new SqlCommand(sql, connection)) //creates a new connection to the stated database above stored in a variable called command
                    {
                        using (SqlDataReader reader = command.ExecuteReader()) //exectues the reader to read from the database
                        {
                            while (reader.Read()) //while loop for while the reader is active
                            {
                                Console.WriteLine("{0} {1} {2} {3}", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetTimeSpan(3)); //reader displays required field using get function
                            }
                        }
                    }
                }
            }
            catch (SqlException e) //catches exception
            {
                Console.WriteLine(e.ToString()); //writes the exception in the form of a string
            }
            Console.WriteLine("\nDone. Press enter."); //output message for user
            Console.ReadLine();

        }



    }
}



//working sql 