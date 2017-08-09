using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Today.ViewModels
{
    public class ItemViewModel : INotifyPropertyChanged
    {
        private string _tarea;
        public string Tarea
        {
            get => _tarea;
            set 
            {
                _tarea = value; 
                OnPropertyChange(); 
            }
        }

        private DateTime _fecha;
        public DateTime Fecha
        {
            get => _fecha;
            set
            {
                _fecha = value;
                OnPropertyChange();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChange([CallerMemberName] string propertyName = null)
		{
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

   
}
