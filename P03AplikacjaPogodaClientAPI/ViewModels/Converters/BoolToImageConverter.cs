using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace P03AplikacjaPogodaClientAPI.ViewModels.Converters
{
    public class BoolToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isRaining = (bool)value;
            string imageName = isRaining ? "rain.jpg" : "sun.jpg";
            string imagesPath = AppDomain.CurrentDomain.BaseDirectory + "\\images";
            return new BitmapImage(new Uri(imagesPath + "\\" + imageName, UriKind.Absolute));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
