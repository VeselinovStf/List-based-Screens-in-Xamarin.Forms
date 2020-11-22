using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConferenceApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set 
            {
                _title = value; 
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void Initialize(object parameter)
        {

        }
    }
}
