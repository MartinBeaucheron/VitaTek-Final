using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Classes;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Classes
{
    public class passerelle
    {
        static HttpClient client = new HttpClient();
        public static async Task<List<Visiteur>> getAllDirecteurRegionnal()
        {
            List<Visiteur> lesVisiteurs = new List<Visiteur>();
            string url = "https://s5-5127.nuage-peda.fr/VitaTek/api.php";

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
                    lesVisiteurs = JsonSerializer.Deserialize<List<Visiteur>>(repAPIenJson);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("problème");
                    Console.Write(e.Message);
                }

                return lesVisiteurs;
            }
        }


        //attributs

        //methodes

        //constructeurs

        //methodes accès varibles privées
    }
}