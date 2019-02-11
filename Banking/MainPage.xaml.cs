using Banking.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MUXC = Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Banking
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      this.InitializeComponent();
      NavView.IsPaneOpen = false;
    }

    private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
      if (args.IsSettingsSelected)
      {
        ContentFrame.Navigate(typeof(SettingsPage));
        NavView.Header = "Settings";
      }
      else
      {
        NavigationViewItem item = args.SelectedItem as NavigationViewItem;

        switch (item.Tag.ToString())
        {
          case "home":
            ContentFrame.Navigate(typeof(HomePage));
            NavView.Header = "Home";
            break;
          case "import":
            ContentFrame.Navigate(typeof(ImportPage));
            NavView.Header = "Import banking data";
            break;
          default:
            break;
        }
      }
    }
  }
}