using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

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

                System.Console.WriteLine(deserializedYml.Version);
                foreach(var element in deserializedYml.Services["user-mgmt"].Networks)
                {
                    System.Console.WriteLine(element);
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}
