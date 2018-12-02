using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WPFUserControlTesting.Converters
{
    public class ChartBarLengthConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Count() == 3)
            {
                var item = values[0] as ChartBarRecord;
                var list = values[1] as IList<ChartBarRecord>;
                bool isReverse = ((string)values[2]).Equals("true");
                if (item == null|| list == null)
                {
                    return null;
                }


                double maxValue = list.Max(x => x.Value);
                double itemValue = item.Value;

                if(itemValue/maxValue == 1)
                {
                    if(isReverse)
                    {
                        return new GridLength(0, GridUnitType.Star);
                    }
                    else
                    {
                        return new GridLength(1, GridUnitType.Star);
                    }
                }else
                {
                    var result = itemValue / maxValue;
                    if(isReverse)
                    {
                        result = 1 - result;
                    }
                    return new GridLength(result, GridUnitType.Star);
                }                              
            }
            return new GridLength(1, GridUnitType.Star);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
