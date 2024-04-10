using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ClassLibrary1
{
    public class Passerelle
    {
        static HttpClient client = new HttpClient();
        public static async Task<List<ForceDeVente>> getAllDirecteurRegionnal()
        {
            List<ForceDeVente> lesDirecteurs = new List<ForceDeVente>();
            string url = "https://s5-5127.nuage-peda.fr/VitaTek/api.php";
            //var options = new JsonSerializerOptions { IncludeFields = true };
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                        throw new Exception();

                    string repAPIenJson = await response.Content.ReadAsStringAsync();
                    lesDirecteurs = JsonSerializer.Deserialize<List<ForceDeVente>>(repAPIenJson);
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine("problème");
                    Console.Write(e.Message);
                }

                return lesDirecteurs;
            }
        }
        public static async Task<List<ForceDeVente2>> getAllForceDevente()
        {
            List<ForceDeVente2> lesDirecteurs = new List<ForceDeVente2>();
            string url = "https://s5-5127.nuage-peda.fr/VitaTek/api.php";
            //var options = new JsonSerializerOptions { IncludeFields = true };
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    //if (!response.IsSuccessStatusCode)
                       // throw new Exception();

                    string repAPIenJson = await response.Content.ReadAsStringAsync();
                    lesDirecteurs = JsonSerializer.Deserialize<List<ForceDeVente2>>(repAPIenJson);


                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("problème");
                    Console.Write(e.Message);
                }

                return lesDirecteurs;
            }
        }

        public static async Task<List<DirecteurRegional>> getToutLesDirecteurRegionaux()
        {
            List<DirecteurRegional> dr = new List<DirecteurRegional>();
            string url = "https://s5-5127.nuage-peda.fr/VitaTek/api.php?role=Directeur";
            //var options = new JsonSerializerOptions { IncludeFields = true };
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                        throw new Exception();

                    string repAPIenJson = await response.Content.ReadAsStringAsync();
                    dr = JsonSerializer.Deserialize<List<DirecteurRegional>>(repAPIenJson);


                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("problème");
                    Console.Write(e.Message);
                }

                return dr;
            }
        }
        public static async Task<string> getNbPoints(int id)
        {

            string url = "https://s5-5127.nuage-peda.fr/VitaTek/api.php?action=getPoints&empid=" + id;

            
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                        throw new Exception();

                    string repAPIenJson = await response.Content.ReadAsStringAsync();
                   
                    return repAPIenJson;


                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("problème");
                    Console.Write(e.Message);
                }

                return "";
            }
        }
        public static async Task ajouteForceDeVente(ForceDeVente2 laFv)
        {
           
            string url = "https://s5-5127.nuage-peda.fr/VitaTek/api.php";
            string repAPIenJson;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new
           MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("nom", laFv.getNom()));
                postData.Add(new KeyValuePair<string, string>("prenom", laFv.getPrenom()));
                postData.Add(new KeyValuePair<string, string>("numero", laFv.getNumero().ToString()));
                postData.Add(new KeyValuePair<string, string>("dateEmbauche", laFv.getDateEmbauche().ToString()));
                postData.Add(new KeyValuePair<string, string>("situationfamilliale", laFv.getSituationFamiliale()));
                postData.Add(new KeyValuePair<string, string>("nbEnfantsAcharge", laFv.getNbEnfants().ToString()));
                //postData.Add(new KeyValuePair<string, string>("role",));
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, client.BaseAddress);
                request.Content = new FormUrlEncodedContent(postData);
                HttpResponseMessage response = await client.PostAsync(url, new
               FormUrlEncodedContent(postData));
                response.EnsureSuccessStatusCode();
                if (!response.IsSuccessStatusCode)
                    throw new Exception();

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("problème");
                Console.Write(e.Message);
            }

        }
        public static async Task deleteForceDeVente(int id)
        {
            string url = "https://s5-5127.nuage-peda.fr/VitaTek/api.php";
            string repAPIenJson;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("id", id.ToString()));
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, url);
                request.Content = new FormUrlEncodedContent(postData);
                HttpResponseMessage response = await client.SendAsync(request);
            }
            catch (HttpRequestException e) { Console.WriteLine(e); }
        }

    }
}