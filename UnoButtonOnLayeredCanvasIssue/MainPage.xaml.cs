
namespace UnoButtonOnLayeredCanvasIssue
{
    using Microsoft.UI.Xaml;
    using Microsoft.UI.Xaml.Controls;
    using UnoButtonOnLayeredCanvasIssue.ViewModels;

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.DataContext = new MainViewModel();
        }

        public MainViewModel VM => this.DataContext as MainViewModel;

        private void Container_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.VM.SetContainerSize(e.NewSize.Width, e.NewSize.Height);
        }
    }
}