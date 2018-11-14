using System.Threading.Tasks;

namespace QRCodeScanner.Services
{
    interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
