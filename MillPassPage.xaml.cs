using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Drawing.Imaging;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MillPassApplication
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MillPassPage : Page
    {

        public ProductList productList;
        
        public string Name { get; set; }
        


        public MillPassPage()
        {
            this.InitializeComponent();
        }

        static void Main(string[] args)
        {

            var barcodeReader = new BarcodeReader();

            Bitmap barcodeBitmap = Bitmap.FromFile(@"C:\Desktop\test.bmp") as Bitmap;
            Bitmap barcodeImage = barcodeBitmap;   
            var barcodeResult = barcodeReader.Decode(barcodeImage);
            Console.WriteLine($"Decoded barcode text: {barcodeResult?.Text}");
            Console.WriteLine($"Barcode format: {barcodeResult?.BarcodeFormat}");
        }


        private void productComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            Name = ProductTextBox.Text;
            productComboBox.ItemsSource = new object[] { Name };
            productComboBox.Items.Append(Name);
        }
    }

    public class ProductList
    {

        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductCategoryID { get; set; }


        public List<ProductList> products
        {
            get { return products; }
            set { products = value; }   
        }   
    }
}
