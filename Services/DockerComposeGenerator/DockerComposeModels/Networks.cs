using YamlDotNet.Serialization;

namespace DockerComposeGenerator;

public class Networks
{
    public string Name {get; set;}  = string.Empty;
    public bool External {get; set;}
    public string Driver {get; set;}  = string.Empty;

    [YamlMember(Alias = "driver_opts")]
    public Dictionary<string, string> DriverOpts { get; set; } = new Dictionary<string, string>();
    public bool Attachable {get; set;}  

}

public class ServiceNetwork
{   
    [YamlMember(Alias = "ipv4_address")]
    public string Ipv4Address {get; set;}  = string.Empty;

    [YamlMember(Alias = "ipv6_address")]
    public string Ipv6Address {get; set;}  = string.Empty;
}