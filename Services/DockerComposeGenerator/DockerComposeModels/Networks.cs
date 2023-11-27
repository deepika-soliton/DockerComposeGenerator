namespace DockerComposeGenerator;

public class Networks
{
    public string Name {get; set;}  = string.Empty;
    public bool External {get; set;}
    public string Driver {get; set;}  = string.Empty;
    public Dictionary<string, string> Driver_Opts { get; set; } = new Dictionary<string, string>();
    public bool Attachable {get; set;}  

}

public class ServiceNetwork
{   
    public string Ipv4_Address {get; set;}  = string.Empty;
    public string Ipv6_Address {get; set;}  = string.Empty;
}