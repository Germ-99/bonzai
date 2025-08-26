using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class IPGeolocation
{

    public static async Task<string> GetLocationAsync(string ipAddress)
    {
        string url = $"http://ip-api.com/json/{ipAddress}";

        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                using (JsonDocument doc = JsonDocument.Parse(responseBody))
                {
                    JsonElement root = doc.RootElement;

                    string city = root.GetProperty("city").GetString();
                    string region = root.GetProperty("regionName").GetString();
                    string cityState = $"{city}, {region}";

                    return cityState;
                }

                System.Diagnostics.Debug.WriteLine("API USED");
            }
        }
        catch (HttpRequestException e)
        {
            return $"Error retrieving location: {e.Message}";
        }
    }
}
