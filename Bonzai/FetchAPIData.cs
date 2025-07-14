using System.ComponentModel;
using System.Text.Json;
using System.Speech.Synthesis;

namespace Bonzai
{
    internal class FetchAPIData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public static SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public static string sessionID = "";
        public static string game_Status = "";
        public static string client_Name = "";
        public static string lobby_IP = "";
        public static string game_clock_display = "";
        public static double game_Clock = 0;
        public static double last_Throw = 0;
        public static double last_Goal = 0;
        public static int blue_points = 0;
        public static int orange_points = 0;
        public static List<string> bluePlayerNames = new List<string>();
        public static List<string> orangePlayerNames = new List<string>();
        public static List<string> specatatorPlayerNames = new List<string>();
        public static Dictionary<string, int> playerPings = new Dictionary<string, int>();
        public static Dictionary<string, int> previousPlayerPings = new Dictionary<string, int>();

        public static async Task<(string sessionID, string game_Status, string client_Name, string game_clock_display, double last_Throw, double last_Goal, string lobby_IP, int blue_points, int orange_points, List<string> bluePlayerNames, List<string> orangePlayerNames, List<string> spectatorPlayerNames)> FetchAPIDataAsync()
        {
            string url = "http://127.0.0.1:6721/session";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        var jsonObject = JsonSerializer.Deserialize<JsonDocument>(jsonContent);

                        string sessionID = jsonObject.RootElement.GetProperty("sessionid").GetString();
                        string game_Status = jsonObject.RootElement.GetProperty("game_status").GetString();
                        string client_name = jsonObject.RootElement.GetProperty("client_name").GetString();
                        string lobby_IP = jsonObject.RootElement.GetProperty("sessionip").GetString();
                        string game_clock_display = jsonObject.RootElement.GetProperty("game_clock_display").GetString();
                        double last_Throw = jsonObject.RootElement.GetProperty("last_throw").GetProperty("total_speed").GetDouble();
                        double last_Goal = jsonObject.RootElement.GetProperty("last_score").GetProperty("disc_speed").GetDouble();
                        int blue_points = jsonObject.RootElement.GetProperty("blue_points").GetInt32();
                        int orange_points = jsonObject.RootElement.GetProperty("orange_points").GetInt32();

                        List<string> bluePlayerNames = new List<string>();
                        List<string> orangePlayerNames = new List<string>();
                        List<string> spectatorPlayerNames = new List<string>();

                        // Only get players from teams[0]
                        var team0 = jsonObject.RootElement.GetProperty("teams")[0];

                        if (team0.TryGetProperty("players", out JsonElement bluePlayers))
                        {
                            // Loop through the players array and add their names

                            foreach (var player in bluePlayers.EnumerateArray())
                            {
                                string playerName = player.GetProperty("name").GetString();
                                int playerPing = player.GetProperty("ping").GetInt32();
                                bluePlayerNames.Add(playerName);
                                playerPings[playerName] = playerPing;
                            }
                        }

                        var team1 = jsonObject.RootElement.GetProperty("teams")[1];

                        if (team1.TryGetProperty("players", out JsonElement orangePlayers))
                        {
                            // Loop through the players array and add their names

                            foreach (var player in orangePlayers.EnumerateArray())
                            {
                                string playerName = player.GetProperty("name").GetString();
                                int playerPing = player.GetProperty("ping").GetInt32();
                                orangePlayerNames.Add(playerName);
                                playerPings[playerName] = playerPing;
                            }
                        }

                        var team2 = jsonObject.RootElement.GetProperty("teams")[2];

                        if (team2.TryGetProperty("players", out JsonElement spectators))
                        {
                            // Loop through the players array and add their names

                            foreach (var player in spectators.EnumerateArray())
                            {
                                string playerName = player.GetProperty("name").GetString();
                                int playerPing = player.GetProperty("ping").GetInt32();
                                spectatorPlayerNames.Add(playerName);
                                playerPings[playerName] = playerPing;
                            }
                        }

                        return (sessionID, game_Status, client_name, game_clock_display, last_Throw, last_Goal, lobby_IP, blue_points, orange_points, bluePlayerNames, orangePlayerNames, spectatorPlayerNames);
                    }
                    else
                    {
                        Console.WriteLine("Failed to get data.");
                        return (null, null, null, null, 0, 0, null, 0, 0, new List<string>(), new List<string>(), new List<string>());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return (null, null, null, null, 0, 0, null, 0, 0, new List<string>(), new List<string>(), new List<string>());
            }
        }


        public static async Task UpdateDataAsync()
        {
            var data = await FetchAPIDataAsync();
            sessionID = data.sessionID;
            game_Status = data.game_Status;
            client_Name = data.client_Name;
            lobby_IP = data.lobby_IP;
            game_clock_display = data.game_clock_display;
            last_Throw = data.last_Throw;
            last_Goal = data.last_Goal;
            blue_points = data.blue_points;
            orange_points = data.orange_points;

            // Store the player names in a public field if needed
            // You can use this for the player display in MainMenu
            bluePlayerNames = data.bluePlayerNames;
            orangePlayerNames = data.orangePlayerNames;
            specatatorPlayerNames = data.spectatorPlayerNames;

            Console.WriteLine("Fetch Update");
        }
    }
}
