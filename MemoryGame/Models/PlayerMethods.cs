/*using MemoryGame.Models;
using System.Data;
using Microsoft.Data.SqlClient;

namespace MemoryGame.Models{
    public class PlayerMethods{
        public PlayerMethods(){}
        public int InsertPlayer(PlayerDetails playerDetails, out string errormsg){
            
            String ConnectionString = "Server=localhost,1433; Database=MemoryGameDB; User Id=sa; Password=Luddis003; Encrypt=False; TrustServerCertificate=True;";
            String sqlstring = "INSERT INTO Players (PlayerName, PlayerUsername, PasswordHash) VALUES (@PlayerName, @PlayerUsername, @PasswordHash);";
            
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            using SqlCommand sqlCommand = new SqlCommand(sqlstring, sqlConnection);
            {
                sqlCommand.Parameters.AddWithValue("@PlayerName", playerDetails.PlayerName);
                sqlCommand.Parameters.AddWithValue("@PlayerUsername", playerDetails.PlayerUsername);
                sqlCommand.Parameters.AddWithValue("@PasswordHash", playerDetails.PasswordHash);
                

                try
                {
                    sqlConnection.Open();
                    Console.WriteLine("Connection successful.");
                    int i = 0;
                    i = sqlCommand.ExecuteNonQuery();
                    if (i == 1) { errormsg = ""; }
                    else { errormsg = "insert failed"; }
                    return i;

                }
                catch (Exception e)
                {
                    errormsg = e.Message;
                    return 0;
                }
                finally
                {
                    sqlConnection.Close();

                }
            }
        }
        public int GetPlayer(PlayerDetails playerDetails, out string errormsg){
            String ConnectionString = "Server=localhost,1433; Database=MemoryGameDB; User Id=sa; Password=Luddis003; Encrypt=False; TrustServerCertificate=True;";
            String sqlstring = "SELECT FROM Players WHERE PlayerUsername = @PlayerUsername;";
            
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            using SqlCommand sqlCommand = new SqlCommand(sqlstring, sqlConnection);
            {
                
                try
                {
                    sqlConnection.Open();
                    Console.WriteLine("Connection successful.");
                    GameDetails.Player1 = PlayerDetails.PlayerID;
                    int i = 0;
                    i = sqlCommand.ExecuteNonQuery();
                    if (i == 1) { errormsg = ""; }
                    else { errormsg = "insert failed"; }
                    return i;

                }
                catch (Exception e)
                {
                    errormsg = e.Message;
                    return 0;
                }
                finally
                {
                    sqlConnection.Close();

                }
            }
        
        }
    }
} */
