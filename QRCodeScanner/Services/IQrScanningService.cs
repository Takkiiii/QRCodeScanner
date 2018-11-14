using System.Threading.Tasks;

namespace QRCodeScanner.Services
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
