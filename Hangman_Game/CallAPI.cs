using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Hangman_Game
{
    internal class CallAPI
    {
        private static CallAPI _callApi = null;

        private String _uri = "https://random-words-api.kushcreates.com/api?words=1";

        private CallAPI() { }

        public static CallAPI GetInstance()
        {
            return _callApi ??= new CallAPI();
        }

        public async Task<Word> GetWord(String theme, String language)
        {
            String finalUri = $"{_uri}&language={language}&category={theme}";
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(finalUri);
                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var words = System.Text.Json.JsonSerializer.Deserialize<List<Word>>(jsonString);
                        return words[0];
                    }catch(Exception ex)
                    {
                        throw new Exception("Failed to parse word from API response", ex);
                    }
                }
                else
                {
                    throw new Exception("Failed to fetch word from API");
                }
            }
        }
    }
}
