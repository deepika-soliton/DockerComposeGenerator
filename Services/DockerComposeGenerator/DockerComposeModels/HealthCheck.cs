namespace DockerComposeGenerator;

public class HealthCheck
{
    public List<string> Test { get; set; } = new List<string>();
    public string Interval { get; set; }  = string.Empty;
    public string Timeout { get; set; }  = string.Empty;
    public int Retries { get; set; }
    public string StartPeriod { get; set; }  = string.Empty;
    public string StartInterval { get; set; }  = string.Empty;
    public bool Disable {get;set;}
}