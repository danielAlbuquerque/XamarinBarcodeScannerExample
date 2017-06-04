using Xamarin.Forms;
using ZXing;


namespace XamarinBarcodeScanner
{
    public partial class XamarinBarcodeScannerPage : ContentPage
    {
        public XamarinBarcodeScannerPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            
            var scanner = new ZXing.Mobile.MobileBarcodeScanner();
            var result = await scanner.Scan();

            if(result != null) {
                await DisplayAlert("Barcode found", result.Text, "OK");
            }
		}
    }
}
