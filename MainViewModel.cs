using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Learning_WPF {
    internal class MainViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler? PropertyChanged;

        public MainViewModel() { }

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

        private double progress_;

        public double Progress {
            get => progress_;
            set {
                progress_ = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Progress)));
            }
        }
    }
}
