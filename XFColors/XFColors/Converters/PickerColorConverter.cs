using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using XFColors.Models;

namespace XFColors.Converters
{
    class PickerColorConverter : IValueConverter
    {
        /// <summary>
        /// Convert a Color (the SelectedColor) to a PickerColor (for the picker)
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Two-way conversion doesn't work right...
            throw new NotImplementedException();
            //if (value == null) return null;
            //return new PickerColor((Color)value, value.ToString());
        }

        /// <summary>
        /// Convert a PickerColor (from the picker) to a Color (for the SelectedColor property)
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((PickerColor)value)?.Color;
        }
    }
}
