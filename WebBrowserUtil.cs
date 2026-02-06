using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Learning_WPF
{
    class WebBrowserUtil {
        public static readonly DependencyProperty dependencyProperty =
            DependencyProperty.RegisterAttached(
                "BindableSource",
                typeof(string),
                typeof(WebBrowserUtil),
                new UIPropertyMetadata(null, OnBindableSourceChanged)
            );

        public static string GetBindableSource(DependencyObject obj) {
            return (string)obj.GetValue(dependencyProperty);
        }

        public static void SetBindableSource(DependencyObject obj, string value) {
            obj.SetValue(dependencyProperty, value);
        }

        public static void OnBindableSourceChanged(DependencyObject? obj, DependencyPropertyChangedEventArgs e) {
            WebBrowser? browser = obj as WebBrowser;
            if (browser != null) {
                string uri = (string) e.NewValue;
                browser.Source = !String.IsNullOrEmpty(uri) ? new Uri(uri) : null;
            }
        }
    }
}
