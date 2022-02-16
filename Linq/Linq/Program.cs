using System;
using System.Linq;
using System.Collections.Generic;
using NHibernate.Linq;
using Remotion.Linq.Clauses;
using System.IO;
using System.Net;
//using Newtonsoft.Json;
using Linq.DTO;
using System.Reflection;
using System.Text.Json;

namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var webClient = new WebClient();
            //var stringJson = webClient.DownloadString(args[2]);
            //var jsonObj = JsonConvert.DeserializeObject<Domain.Root>(stringJson);
            //IEnumerable<PetDTO> jsonPet = (IEnumerable<PetDTO>)JsonConvert.DeserializeObject<PetDTO>(stringJson);
            //Domain.Users myDeserializedClass = JsonConvert.DeserializeObject<Domain.Users>(args[0]);


            var pets = PetService.GetPets();
            var people = PeopleService.GetPeople();

            var join = from post in pets
                       join meta in people on post.idPeople equals meta.id
                       where post.idPeople == meta.id
                       select new { post.pet_name, meta.first_name };
            foreach (var item in join)
            {
                Console.WriteLine($"{item.pet_name} and {item.first_name}");
            }



        }
        public class PetService
        {
            public static IEnumerable<PetDTO> GetPets()
            {
                var assembly = typeof(PetService).GetTypeInfo().Assembly;
                Stream resource = assembly.GetManifestResourceStream("Linq.petData.json");
                return JsonSerializer.DeserializeAsync<IEnumerable<PetDTO>>(resource).Result;
            }
        }

        public class PeopleService
        {
            public static IEnumerable<PeopleDTO> GetPeople()
            {
                var assembly = typeof(PeopleService).GetTypeInfo().Assembly;
                Stream resource = assembly.GetManifestResourceStream("Linq.petData.json");
                return JsonSerializer.DeserializeAsync<IEnumerable<PeopleDTO>>(resource).Result;
            }
        }
    }
}
