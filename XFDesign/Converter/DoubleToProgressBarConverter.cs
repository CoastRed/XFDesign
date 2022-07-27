using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace XFDesign.Converter
{
    internal class DoubleToProgressBarConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double current = (double)values[0];
            double miniumn  = (double)values[1];
            double maxiumn  = (double)values[2];

            if (parameter?.ToString() == "ProgressBar")
            {
                if (maxiumn - miniumn > 0)
                {
                    return current / (maxiumn - miniumn) * 360;
                }
                else
                {
                    return current * 360;
                }
            }
            else if (parameter?.ToString() == "Percentage")
            {
                if (maxiumn - miniumn > 0)
                {
                    return current / (maxiumn - miniumn);
                }
                else
                {
                    return current;
                }
            }
            else//不管最大最小值，只用当前值转换为圆环进度
            {
                return current * 360;
            }

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
