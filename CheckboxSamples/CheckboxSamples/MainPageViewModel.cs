using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CheckboxSamples
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsChecked { get; set; }

        public ICommand IsCheckedChanged { get; set; }

        public ICommand ChangeIsChecked { get; set; }

        public MainPageViewModel()
        {
            ChangeIsChecked = new Command(() => IsChecked = !IsChecked);

            IsCheckedChanged = new Command<bool>(isChecked =>
            {

            });
        }
    }
}
