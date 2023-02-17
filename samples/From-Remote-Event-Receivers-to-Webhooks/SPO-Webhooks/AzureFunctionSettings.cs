using System.Security.Cryptography.X509Certificates;

public class AzureFunctionSettings
{
    public string TenantId { get; set; }
    public string TenantName { get; set; }
    public string ClientId { get; set; }
    public StoreName CertificateStoreName { get; set; }
    public StoreLocation CertificateStoreLocation { get; set; }
    public string CertificateThumbprint { get; set; }
}