using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace P03AplikacjaPogodaClientAPI.ViewModels.Converters
{
    public class ScreenHeightToRangeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            //  double screenHeight = SystemParameters.PrimaryScreenHeight;
            //  double screenWidth = SystemParameters.PrimaryScreenWidth;

              //double windowSize = MainWindow.WindowWidth;

             double actualHeight = (double)value;
            if (actualHeight <= 720)
                return 720;
            else if (actualHeight < 1080)
                return 1080;
            else
                return 1440;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
