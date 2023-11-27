namespace DockerComposeGenerator;

public class DockerComposeModel
{
    public string Version {get; set;} = string.Empty;
    public  Dictionary<string, Service> Services { get; set; } = new Dictionary<string, Service>();
    public Dictionary<string, Networks> Networks { get; set; } = new Dictionary<string, Networks>();
    public Dictionary<string, Volume> Volumes {get;set;} = new Dictionary<string, Volume>();

    //public Dictionary<string, SecretsAttribute> Secrets {get;set;}
    //public Dictionary<string, ConfigAttribute> Configs {get;set;}

}