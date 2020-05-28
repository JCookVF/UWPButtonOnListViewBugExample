using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UWPButtonOnListViewBugExample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public ObservableCollection<string> Items => new ObservableCollection<string> { "Item A", "Item B", "Item C", "Item D" };

        public RelayCommand<string> ButtonPressCommand 
        { 
            get 
            {
                return new RelayCommand<string>((str) =>
                {
                    Debug.WriteLine($"********************{str} BUTTON PRESSED********************");
                });
            } 
        }

        private string _selectedItem;
        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
                Debug.WriteLine($"********************{_selectedItem} SELECTED********************");
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
