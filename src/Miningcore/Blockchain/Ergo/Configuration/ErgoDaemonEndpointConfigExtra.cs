namespace Miningcore.Blockchain.Ergo.Configuration;

public class ErgoDaemonEndpointConfigExtra
{
    /// <summary>
    /// The Ergo Node's API key in clear-text - not the hash
    /// </summary>
    public string ApiKey { get; set; }

    public string SrHost { get; set; }

    public int SrPort { get; set; }
}
