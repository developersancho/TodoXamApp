using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using TodoXamApp.Models;
using TodoXamApp.Services;
using Xamarin.Forms;

namespace TodoXamApp.ModelViews
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<Todo> _todos;
        private TodoService _todoService = new TodoService();
        private bool _isRefreshing;

        public List<Todo> Todos
        {
            get => _todos;
            set
            {
                _todos = value;
                OnPropertyChanged();
            }
        }

        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            GetTodoes();
        }

        private async Task GetTodoes()
        {
            IsRefreshing = true;
            Todos = await _todoService.GetTodoes();
            IsRefreshing = false;
        }

        public ICommand RefreshCommand => new Command(async () =>
        {
            await GetTodoes();
        });

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
