namespace UnoButtonOnLayeredCanvasIssue.Controls
{
    using System;
    using Microsoft.UI.Xaml;
    using Microsoft.UI.Xaml.Controls;
    using UnoButtonOnLayeredCanvasIssue.ViewModels;

    // The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

    public sealed partial class ButtonOverlay : UserControl
    {
        public ButtonOverlay()
        {
            this.InitializeComponent();
        }

        public MainViewModel VM => this.DataContext as MainViewModel;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.VM.DoAction();
        }
    }
}
