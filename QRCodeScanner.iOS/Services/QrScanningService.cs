using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;

[assembly: Dependency(typeof(QRCodeScanner.iOS.Services.QrScanningService))]
namespace QRCodeScanner.iOS.Services
{
    public class QrScanningService : QRCodeScanner.Services.IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            try
            {
                var optionsDefault = new MobileBarcodeScanningOptions();
                var optionsCustom = new MobileBarcodeScanningOptions();

                var scanner = new MobileBarcodeScanner()
                {
                    TopText = "Scan the QR Code",
                    BottomText = "Please Wait",
                };

                var scanResult = await scanner.Scan(optionsCustom);
                return scanResult.Text;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
