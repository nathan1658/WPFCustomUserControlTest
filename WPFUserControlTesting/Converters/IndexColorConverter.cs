using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WPFUserControlTesting.Converters
{
    public class IndexColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            List<SolidColorBrush> colorList = new List<SolidColorBrush>();
            colorList.Add(new SolidColorBrush(Colors.Red));
            colorList.Add(new SolidColorBrush(Colors.Orange));
            colorList.Add(new SolidColorBrush(Colors.Yellow));
            colorList.Add(new SolidColorBrush(Colors.Green));
            colorList.Add(new SolidColorBrush(Colors.PaleTurquoise));

            return colorList[(int)value % colorList.Count];

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
