using DocumentFormat.OpenXml.Presentation;
using System.Globalization;
using System.Net.Cache;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace C_Sharp_Turorial
{
    public class Person
    {
        public Person() { }

        public string Name { get; set; }
        public string Occupation { get; set; }

        public long salary { get; set; }

        public override string ToString()
        {
            return  "Name: "        + Name       + "\n" +
                    "Occupation: "  + Occupation + "\n" +
                    "Salary: "      + salary;
        }

    }

    public class Post
    {
        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        public override string ToString()
        {
            return "UserId: " + this.UserId + "\n" +
                    "Id: "    + this.Id     + "\n" +
                    "Title: " + this.Title  + "\n" +
                    "Body: "  + this.Body   + "\n";
        }
    }


    public class Program
    {
        public static async Task Main(string[] args)
        {

            //string words = "Lokesh is a very good boy";
            //Console.WriteLine(Strings.String.ReverseWords(words));
            //
            DateTime dateTime = new DateTime(2024, 11, 10, 14, 30, 45);

            //Console.WriteLine(dateTime.ToString("d"));

            //Console.WriteLine(dateTime.ToString("dd"));

            //Console.WriteLine(dateTime.ToString("ddd"));

            //Console.WriteLine(dateTime.ToString("dddd"));

            //Console.WriteLine(dateTime.ToString("ddddd"));


            //Console.WriteLine(dateTime.ToString("M"));

            //Console.WriteLine(dateTime.ToString("MM"));

            //Console.WriteLine(dateTime.ToString("MMM"));

            //Console.WriteLine(dateTime.ToString("MMMM"));

            //Console.WriteLine(dateTime.ToString("MMMMM"));


            //Console.WriteLine(dateTime.ToString("yyyy-MM-dd"));

            ////Console.WriteLine(dateTime.ToString("yyyy--dd"));

            //Console.WriteLine(dateTime.ToString("hh"));
            //Console.WriteLine(dateTime.ToString("HH"));

            //Console.WriteLine(dateTime.ToString("hh:mm:ss"));
            //Console.WriteLine(dateTime.ToString("hh:mm:ss tt"));
            //Console.WriteLine(dateTime.ToString("hh:mm:ss zzz"));

            //Console.WriteLine(dateTime.ToString("yyyy/MM/dd hh:mm:ss tt"));


            //Console.WriteLine(dateTime.ToString());
            //Console.WriteLine("UK: " + dateTime.ToString(new CultureInfo("en-UK")));
            //Console.WriteLine("US: " + dateTime.ToString(new CultureInfo("en-US")));
            //Console.WriteLine("IND: "+ dateTime.ToString(new CultureInfo("ind")));

            //string osVersion = Environment.CurrentManagedThreadId.ToString();
            //Console.WriteLine(osVersion.ToString());


            // ----------------- JSON SERIALIZER -----------------------------


            Person ram = new Person();
            ram.Name = "Ram";
            ram.salary = 18000;
            ram.Occupation = "Photographer";

            Console.WriteLine("Before Serialization: \n");
            Console.WriteLine(ram);

            Console.WriteLine("After Serialization to Json:  \n");
            var ramJson = JsonSerializer.Serialize(ram);
            Console.WriteLine(ramJson);

            Console.WriteLine("After Deserialization to Person: \n");
            var ramBack = JsonSerializer.Deserialize<Person>(ramJson);
            Console.WriteLine(ramBack.Name);

            using(HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
                    if (response.IsSuccessStatusCode)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            Console.WriteLine("Response: \n");
                            var content = await response.Content.ReadAsStreamAsync();

                            List<Post> posts = await JsonSerializer.DeserializeAsync<List<Post>>(content);

                            foreach(Post post in posts)
                            {
                                Console.WriteLine(post);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(response.StatusCode);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
