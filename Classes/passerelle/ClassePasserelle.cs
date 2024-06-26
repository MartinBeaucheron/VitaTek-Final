using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Classes;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Classes
{
    public class Passerelle
    {
        static HttpClient client = new HttpClient();
        public static async Task<List<ForceDeVente>> getAllDirecteurRegionnal()
        {
            List<ForceDeVente> lesDirecteurs = new List<ForceDeVente>();
            string url = "https://s5-5127.nuage-peda.fr/VitaTek/api.php";
            var options = new JsonSerializerOptions { IncludeFields = true };
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
                    lesDirecteurs = JsonSerializer.Deserialize<List<ForceDeVente>>(repAPIenJson, options);
                    

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("probl�me");
                    Console.Write(e.Message);
                }

                return lesDirecteurs;
            }
        }


        //attributs

        //methodes

        //constructeurs

        //methodes acc�s varibles priv�es
    }
}