using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace Magic_8_Ball
{
    public class MainVM : INotifyPropertyChanged
    {
        private readonly MainModel model;

        private string helloText = "";

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyProperty([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string HelloText
        {
            get { return helloText; }
            set { helloText = value; NotifyProperty(); }
        }

        public Uri Source { get; set; }

        public ICommand ButtonCommand { get; set; }
        private void DoButtonCommand()
        {
            System.Threading.Thread.Sleep(6750);
            HelloText = model.GetMessage();
        }

        private BitmapImage _ImageSource;
        public BitmapImage ImageSource
        {
            get { return this._ImageSource; }
            set { this._ImageSource = value; this.OnPropertyChanged("ImageSource"); }
        }

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }

        public MainVM()
        {
            model = new MainModel();
            ButtonCommand = new RelayCommand(DoButtonCommand);
            string imagePath = @"..\..\8ball.png";
            this.ImageSource = new BitmapImage(new Uri(imagePath, UriKind.Relative));
        }
    }
}