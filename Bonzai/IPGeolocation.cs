using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class IPGeolocation
{
    // This method retrieves the city and state from an IP address
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

                // Parse the JSON response using System.Text.Json
                using (JsonDocument doc = JsonDocument.Parse(responseBody))
                {
                    JsonElement root = doc.RootElement;

                    // Extract city and region (state) from the response
                    string city = root.GetProperty("city").GetString();
                    string region = root.GetProperty("regionName").GetString();

                    // Combine city and state into a single string
                    string cityState = $"{city}, {region}";

                    return cityState;
                }

                System.Diagnostics.Debug.WriteLine("API USED");
            }
        }
        catch (HttpRequestException e)
        {
            // Return an error message in case of a request failure
            return $"Error retrieving location: {e.Message}";
        }
    }
}
