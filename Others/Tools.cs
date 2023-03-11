using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.Globalization;

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
        
        static public bool IsPathExist(string filePath)
        {
            return File.Exists(filePath);
        }

        static private bool isFolderExist(string folderPath)
        {
            return Directory.Exists(folderPath);
        }

        static public dynamic GetDataFromRepoName(string repoName, string mode = "array")
        {
            string dataFolderPath = Path.Combine(GetRunningPath(), "data");
            string filePath = Path.Combine(dataFolderPath, $"{repoName}.json");

            if (!IsPathExist(filePath))
            {
                MessageBox.Show($"\"{filePath}\" doesn't exist");
            }
            if (mode == "string")
            {
                return File.ReadAllText(filePath);
            }
            else
            {
                return File.ReadAllLines(filePath);
            }
            
        }



        static public void SaveDataToRepoFile(string repoName, string[] data)
        {
            string dataFolderPath = Path.Combine(GetRunningPath(), "data");
            string filePath = Path.Combine(dataFolderPath, $"{repoName}.json");

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            File.WriteAllLines(filePath, data);
        }

        static public void DeleteRepoFile(string repoName)
        {
            string dataFolderPath = Path.Combine(GetRunningPath(), "data");
            string filePath = Path.Combine(dataFolderPath, $"{repoName}.json");
            File.Delete(filePath);
        }

        static public void SaveDataToRepoFile(string repoName, string data)
        {
            string dataFolderPath = Path.Combine(GetRunningPath(), "data");
            string filePath = Path.Combine(dataFolderPath, $"{repoName}.json");

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            File.WriteAllText(filePath, data);
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

        public static async Task<string> GetRepoInfo(string repoUrl, string apiToken)
        {
            string apiUrl = URLtoAPIURL(repoUrl);
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


        public static bool IsValidUrl(string url)
        {
            Uri uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }


        public static string getRepoNameFromURL(string repoURL)
        {
            Uri uri = new Uri(repoURL);
            string repoName = uri.Segments[2].TrimEnd('/');
            return repoName;
        }


        public static string FormatJson(string unformattedJsonString)
        {
            JToken token = JToken.Parse(unformattedJsonString);
            string formattedJsonString = token.ToString(Formatting.Indented);
            return formattedJsonString;
        }


        public static string[] GetRepoCardInfo(string repoName)
        {
            string dataFolderPath = Path.Combine(GetRunningPath(), "data");
            string filePath = Path.Combine(dataFolderPath, $"{repoName}.json");

            /*if (!Directory.Exists(filePath)) {
                MessageBox.Show($"\"{filePath}\" doesn't exist" );
            }*/

            string[] lines = File.ReadAllLines(filePath);

            string full_name = "";
            string private_status = "";
            string created_at = "";
            string updated_at = "";
            string figma_url = "";
            string local_path = "";
            string complete = "";
            for (int i =0; i< lines.Length; i++)
            {
                string currentLine = lines[i];

                if (currentLine.Contains("full_name"))
                {
                    full_name = GetUrlFromJson(currentLine);
                    continue;
                }

                if (currentLine.Contains("visibility"))
                {
                    if (currentLine.Contains("private"))
                    {
                        private_status = "true";
                    }
                    else
                    {
                        private_status = "false";
                    }
                    continue;
                }

                if (currentLine.Contains("created_at"))
                {
                    created_at = GetTimeStampFromJson(currentLine);
                    continue;
                }

                if (currentLine.Contains("updated_at"))
                {
                    updated_at = GetTimeStampFromJson(currentLine);
                    continue;
                }

                if (currentLine.Contains("figma_url"))
                {
                    figma_url = GetUrlFromJson(currentLine);
                    //Console.WriteLine(figma_url);
                    continue;
                }

                if (currentLine.Contains("local_path"))
                {
                    local_path = GetUrlFromJson(currentLine);
                    //Console.WriteLine(local_path);
                    continue;
                }

                if (currentLine.Contains("complete"))
                {
                    complete = GetBoolFromJson(currentLine);
                    break;
                }
            }

            string[] res = { full_name,private_status, created_at, updated_at, figma_url, local_path, complete };
            return res;
        }

        public static string[] GetRepoDetailsInfo(string repoName)
        {
            string dataFolderPath = Path.Combine(GetRunningPath(), "data");
            string filePath = Path.Combine(dataFolderPath, $"{repoName}.json");

            string[] lines = File.ReadAllLines(filePath);

            string description = "";
            string homepage = "";
            string stargazers_count = "";
            string language = "";
            string open_issues_count = "";
            
            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];

                if (currentLine.Contains("description"))
                {
                    if (currentLine.Contains("null")) continue;
                    description = GetUrlFromJson(currentLine);
                    continue;
                }

                if (currentLine.Contains("homepage"))
                {
                    if (currentLine.Contains("null")) continue;
                    homepage = GetUrlFromJson(currentLine);
                    continue;
                }

                if (currentLine.Contains("stargazers_count"))
                {
                    stargazers_count = GetNumberFromJson(currentLine);
                    continue;
                }

                if (currentLine.Contains("language"))
                {
                    language = GetUrlFromJson(currentLine);
                    continue;
                }

                if (currentLine.Contains("open_issues_count"))
                {
                    open_issues_count = GetNumberFromJson(currentLine);
                    break;
                }
            }

            string[] res = { description, homepage, stargazers_count, language, open_issues_count};
            return res;
        }

        private static string GetTimeStampFromJson(string input)
        {
            string pattern = @"(\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}Z)";

            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                string timestamp = match.Groups[1].Value;
                return timestamp;
            }
            return "";
        }


        private static string GetUrlFromJson(string input)
        {
            int startIndex = input.IndexOf(": \"") + 3;
            int endIndex = input.LastIndexOf('"');
            string path = input.Substring(startIndex, endIndex - startIndex);
            return path;
        }
        private static string GetNumberFromJson(string input)
        {
            int startIndex = input.IndexOf("\": ") + 3;
            int endIndex = input.LastIndexOf(',');
            string path = input.Substring(startIndex, endIndex - startIndex);
            return path;
        }

        private static string GetBoolFromJson(string input)
        {
            Console.WriteLine(input);
            if (input.Contains("false"))
            {
                return "false";
            }
            else if (input.Contains("true"))
            {
                return "true";
            }
            else if (input.Contains("null"))
            {
                return "null";
            }
            else
            {
                throw new Exception("GetBoolFromJson Wrong");
            }
        }


        public static string[] GetAllRepoNamFromLocal()
        {

            // 获取data文件夹路径
            string dataFolderPath = Path.Combine(GetRunningPath(), "data");

            // 获取data文件夹下的所有文件
            string[] fileNames = Directory.GetFiles(dataFolderPath);

            // 去除文件后缀名
            for (int i = 0; i < fileNames.Length; i++)
            {
                fileNames[i] = Path.GetFileNameWithoutExtension(fileNames[i]);
            }

            return fileNames;
        }

        public static string GetNowISO8601()
        {
            DateTime now = DateTime.UtcNow;
            string iso8601 = now.ToString("yyyy-MM-ddTHH:mm:ssZ");
            //Console.WriteLine(iso8601);
            return iso8601;
        }

        public static string ISO8601ToDDMMYY(string inputDateString)
        {
            DateTime inputDate = DateTime.Parse(inputDateString);
            CultureInfo culture = new CultureInfo("en-US");
            string outputDateString = inputDate.ToString("dd MMM, yyyy", culture);
            return outputDateString;
        }
    }
}
