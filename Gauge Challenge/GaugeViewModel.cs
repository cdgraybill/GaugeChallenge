using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauge_Challenge
{
    public class GaugeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public GaugeViewModel()
        {

        }

        int _angle;
        public int Angle
        {
            get
            {
                return _angle;
            }

            set
            {
                _angle = value;
                NotifyPropertyChanged("Angle");
            }
        }

        int _value;
        public int Value
        {
            get
            {
                return _value;
            }

            set
            {
                if (value > 0 && value < 250)
                {
                    _value = value;
                    Angle = value - 120;
                    NotifyPropertyChanged("Angle");
                }
            }
        }
    }
}
