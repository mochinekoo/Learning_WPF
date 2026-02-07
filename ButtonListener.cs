using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Learning_WPF
{
    class ButtonListener {
        private readonly MainViewModel mainViewModel_;

        public ICommand ButtonClickCommand { get; private set;  }

        public ButtonListener(MainViewModel mainViewModel) {
            mainViewModel_ = mainViewModel;
            ButtonClickCommand = new BaseCommand(OnButtonClick);
        }

        private void OnButtonClick() {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "画像ファイル (*.png)|*.png";
            if (openFileDialog.ShowDialog() == true) {
                mainViewModel_.Browser = openFileDialog.FileName;

                var subWindow = new Window1();
                subWindow.Show();
            }
        }
    }
}
