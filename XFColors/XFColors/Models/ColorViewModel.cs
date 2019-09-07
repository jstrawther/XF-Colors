using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XFColors.Models
{
	class ColorViewModel : BaseViewModel
	{
        public ColorViewModel()
        {
            Red = 1;
            Green = 1;
            Blue = 1;
            Alpha = 1;
            AvailableColors = new ObservableCollection<PickerColor>(new[]
            {
                new PickerColor(Color.Red, nameof(Color.Red)),
                new PickerColor(Color.Green, nameof(Color.Green)),
                new PickerColor(Color.Blue, nameof(Color.Blue))
            });
        }

		private double _red;
		public double Red
		{
			get { return _red; }
			set { SetProperty(ref _red, value, nameof(Red), UpdateSelectedColorRGB); }
		}

		private double _green;
		public double Green
		{
			get { return _green; }
            set { SetProperty(ref _green, value, nameof(Green), UpdateSelectedColorRGB); }
        }

		private double _blue;
		public double Blue
		{
			get { return _blue; }
            set { SetProperty(ref _blue, value, nameof(Blue), UpdateSelectedColorRGB); }
        }

		private double _alpha;
		public double Alpha
		{
			get { return _alpha; }
            set { SetProperty(ref _alpha, value, nameof(Alpha), UpdateSelectedColorRGB); }
        }

        private double _hue;
        public double Hue
        {
            get { return _hue; }
            set { SetProperty(ref _hue, value, nameof(Hue), UpdateSelectedColorHSL); }
        }

        private double _saturation;
        public double Saturation
        {
            get { return _saturation; }
            set { SetProperty(ref _saturation, value, nameof(Saturation), UpdateSelectedColorHSL); }
        }

        private double _luminosity;
        public double Luminosity
        {
            get { return _luminosity; }
            set { SetProperty(ref _luminosity, value, nameof(Luminosity), UpdateSelectedColorHSL); }
        }

        private Color _selectedColor;
		public Color SelectedColor
        {
            get { return _selectedColor; }
            set { SetProperty(ref _selectedColor, value, nameof(SelectedColor), OnSelectedColorChanged); }
        }

        public ObservableCollection<PickerColor> AvailableColors { get; }

        private void OnSelectedColorChanged()
        {
            _hue = SelectedColor.Hue;
            _saturation = SelectedColor.Saturation;
            _luminosity = SelectedColor.Luminosity;
            _red = SelectedColor.R;
            _green = SelectedColor.G;
            _blue = SelectedColor.B;
            OnPropertyChanged(nameof(Red));
            OnPropertyChanged(nameof(Green));
            OnPropertyChanged(nameof(Blue));
            OnPropertyChanged(nameof(Alpha));
            OnPropertyChanged(nameof(Hue));
            OnPropertyChanged(nameof(Saturation));
            OnPropertyChanged(nameof(Luminosity));
            OnPropertyChanged(nameof(SelectedColor));
        }

        private void UpdateSelectedColorRGB()
        {
            SelectedColor = Color.FromRgba(_red, _green, _blue, _alpha);
        }

        private void UpdateSelectedColorHSL()
        {
            SelectedColor = Color.FromHsla(_hue, _saturation, _luminosity, _alpha);
        }
    }
}
