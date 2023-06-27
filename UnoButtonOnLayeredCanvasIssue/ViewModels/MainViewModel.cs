using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoButtonOnLayeredCanvasIssue.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int hitNo;

        public MainViewModel()
        {
            this.Monitor = "No hits";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Monitor { get; private set; }

        public double X { get; private set; }

        public double Y { get; private set; }

        public void SetContainerSize(double width, double height)
        {
            this.X = (width / 6.0);
            this.Y = (height / 6.0);
            this.OnPropertyChanged(nameof(this.X));
            this.OnPropertyChanged(nameof(this.Y));
        }

        public void DoAction()
        {
            this.Monitor = $"{++this.hitNo} hits";
            this.OnPropertyChanged(nameof(this.Monitor));
        }

        private void OnPropertyChanged(string property)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
