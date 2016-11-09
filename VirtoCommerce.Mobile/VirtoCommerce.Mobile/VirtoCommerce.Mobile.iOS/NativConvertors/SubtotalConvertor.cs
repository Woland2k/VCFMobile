using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using MvvmCross.Platform.Converters;
using System.Globalization;
using VirtoCommerce.Mobile.Model;

namespace VirtoCommerce.Mobile.iOS.NativConvertors
{
    public class SubtotalConvertor : IMvxValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "Subtotal:" + value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}