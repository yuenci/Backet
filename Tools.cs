using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Backet
{
    public class Tools
    {
        static public string GetRunningPath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            //Console.WriteLine(currentDirectory);
            return currentDirectory;
        }

        static public void  DetectDataFile()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            
            string dataFolderPath = Path.Combine(currentDirectory, "data");
 

            if (!Directory.Exists(dataFolderPath))
            {
                Directory.CreateDirectory(dataFolderPath);
                Console.WriteLine("Data Folder created");
            }
            else
            {
                Console.WriteLine("Data Folder exist");
            }
        }

        public static async Task<string> GetRepoInfo(string apiUrl, string apiToken)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("C#", "1.0"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", apiToken);

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody;
                }
                else
                {
                    throw new Exception("Failed to retrieve repository information");
                }
            }
        }

        public static async void  TestGetRepoInfo()
        {
            string apiUrl = URLtoAPIURL("https://github.com/yuenci/Java-Car-Rental-System");
            ;
            try
            {
                string repoInfo = await GetRepoInfo(apiUrl, Token.token);
                WriteRepoJson("Java-Car-Rental-System", repoInfo);
                Console.WriteLine(repoInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string URLtoAPIURL(string repoUrl)
        {
            Uri uri = new Uri(repoUrl);
            string apiUrl = $"https://api.github.com/repos/{uri.Segments[1]}{uri.Segments[2].TrimEnd('/')}";
            return apiUrl;
        }


        public static void WriteRepoJson(string repoName, string textContent)
        {
            string dataFolderPath = Path.Combine(GetRunningPath(), "data");
            
            string filePath = Path.Combine(dataFolderPath, $"{repoName}.json");
            File.WriteAllText(filePath, textContent);
        }
    }
}
