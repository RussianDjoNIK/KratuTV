using System.Windows;

namespace KratuTV
{
   public partial class MainPage
   {
      // Constructor
      public MainPage()
      {
         InitializeComponent();
      }

      private void Player_OnMediaFailed(object sender, ExceptionRoutedEventArgs e)
      {
          // TODO write to log
      }
   }
}