using System.ComponentModel;

namespace WpfBlazorHybridApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int _counterValue;

        public int CounterValue
        {
            get { return _counterValue; }
            set
            {
                _counterValue = value;
                PropertyChanged?.Invoke(
                    this, new PropertyChangedEventArgs(
                        nameof(CounterValue)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
