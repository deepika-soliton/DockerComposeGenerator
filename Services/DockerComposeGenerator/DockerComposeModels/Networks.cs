using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DockerComposeGenerator;

public class Networks
{
    [JsonProperty("name")]
    public string Name {get; set;}  

    [JsonProperty("external")] 
    public bool External {get; set;}

    [JsonProperty("driver")]
    public string Driver {get; set;}  

    [YamlMember(Alias = "driver_opts")]
    [JsonProperty("driver_opts")]
    public Dictionary<string, string> DriverOpts { get; set; } 

}

public class ServiceNetwork
{   
    [YamlMember(Alias = "ipv4_address")]
    [JsonProperty("ipv4_address")]
    public string Ipv4Address {get; set;}  

    [YamlMember(Alias = "ipv6_address")]
    [JsonProperty("ipv6_address")]
    public string Ipv6Address {get; set;}  
}