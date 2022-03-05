# Imagesound
This is apart of the challenge for the software engineering placement 2022.
There are 6 files in this repository not including this one.
Each file is explained below:

-The file named 'Method_with_0_references.cs' is a c# file which contains a method called "GetMusicTracks()" which returns a list of tracks for a given genre. Also, the method validates for zero duration tracks and prevents them from being returned.

-The file named 'WorkingSQLquery.cs' is a c# program written in visual studio that connects to a microsoft azure database which contains all the details of the database. This program is fully functional and executes an SQL query which returns data from more than one table that are linked by a relationship using the primary and foreign key as well as the inner join function. The query selects the artist_id, track title, track genre and duration of the track and validates for only tracks that are from the last year(2022) and orders the output in ascending order based on the artist and title of the track.

-The file named 'getmusictracks.cs' is a c# file that was used to test if the query worked in the 'Method_with_0_references' file.

-The file named 'getmusictrackstest.cs' is a c# file that was a program that was used to test the getmusictracks function by outputting all information from the tracks table ensure that the previous query that was ran (from the getmusictracks.cs) worked.

-The file named 'index.html' is the home page of the website i created for the music library. This page has a working header, footer, image that is enlarged when the mouse is hovered over it, navigation bar, a table with a list of music tracks.

-The file named 'index.html' is the home page of the website i created for the music library. This page has a working header, footer, text, hyperlink that links to a website, a contact form that is static and a google maps embeded map of sheffield that has zoom and panning capabilities.

############NOTE############
I did attempt to retrieve information from the database and query it to a table in html but had no luck. I did however, manage to get it to work with a local host database with MySQL and PHPMyadmin. This was done by using php to establish a connection then using php to query the database and input it into the table.
