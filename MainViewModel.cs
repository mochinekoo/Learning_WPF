using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Learning_WPF {
    internal class MainViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler? PropertyChanged;

        private int slider_;
        public int Slider {
            get {
                return slider_;
            }
            set {
                slider_ = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slider)));
            }
        }

        public MainViewModel() { }
    }
}
