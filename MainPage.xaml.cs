using System;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FilePicker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //private async void SelectImage_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    FileOpenPicker openPicker = new FileOpenPicker();
        //    openPicker.ViewMode = PickerViewMode.Thumbnail;
        //    openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
        //    openPicker.FileTypeFilter.Add(".csv");
        //    openPicker.FileTypeFilter.Add(".xml");

        //    StorageFile file = await openPicker.PickSingleFileAsync();

        //    if (file != null)
        //    {
        //        var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
        //        var image = new BitmapImage();
        //        image.SetSource(stream);
        //        ImagePreview.Children.Add(new Image() { Source = image, Width = 300, Height = 300 });
        //    }
        //}



        private async void SelectTextFile_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            openPicker.FileTypeFilter.Add(".txt");
            openPicker.FileTypeFilter.Add(".json");
            openPicker.FileTypeFilter.Add(".xml");
            openPicker.FileTypeFilter.Add(".csv");

            StorageFile file = await openPicker.PickSingleFileAsync();

            if (file != null)
            {
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read); using
                (StreamReader reader = new StreamReader(stream.AsStream()))
                {
                    FileText.Text = reader.ReadToEnd();
                }

            }
        }






    }
}