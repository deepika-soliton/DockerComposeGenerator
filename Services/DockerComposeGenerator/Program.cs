using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using Newtonsoft.Json;
using System.Dynamic;

namespace DockerComposeGenerator;

class Program
{
    static void Main(string[] args)
    {

        try
        {
            System.Console.WriteLine("Enter the file path of docker-compose file: ");
            string? file = Console.ReadLine(); 

            var deserializer = new DeserializerBuilder()
                            .WithNamingConvention(CamelCaseNamingConvention.Instance)
                            .WithNamingConvention(UnderscoredNamingConvention.Instance)  
                            .Build();
            if(string.IsNullOrEmpty(file))
            {
                System.Console.WriteLine("Please provide a file path!");
            }
            else
            {
                var reader = new StreamReader(file);
                var deserializedYml = deserializer.Deserialize<DockerComposeModel>(reader);

                System.Console.WriteLine(deserializedYml);
                foreach(var element in deserializedYml.Services["user-mgmt"].Networks)
                {
                    System.Console.WriteLine(element);
                }

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };
                string json = JsonConvert.SerializeObject(deserializedYml, settings);
                dynamic jsonObject = JsonConvert.DeserializeObject<ExpandoObject>(json);

                // System.Console.WriteLine("Enter your file path: ");
                // file = @"" + System.Console.ReadLine();
                // File.WriteAllText(file, json);

                System.Console.WriteLine("\nSerializtaion starts!\n");
                var serializer = new SerializerBuilder()
                           //.WithNamingConvention(CamelCaseNamingConvention.Instance)
                           .Build();
                var yaml = serializer.Serialize(jsonObject);
               System.Console.WriteLine("Enter your file path: ");
                file = @"" + System.Console.ReadLine();
                File.WriteAllText(file, yaml);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}
