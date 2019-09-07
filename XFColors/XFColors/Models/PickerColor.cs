using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFColors.Models
{
    class PickerColor
    {
        public PickerColor(Color color, string displayName)
        {
            Color = color;
            DisplayName = displayName;
        }

        public Color Color { get; }
        public string DisplayName { get; }
    }
}
