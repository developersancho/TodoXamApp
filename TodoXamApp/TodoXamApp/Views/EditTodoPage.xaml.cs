using TodoXamApp.Models;
using TodoXamApp.ModelViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoXamApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditTodoPage : ContentPage
    {
        public EditTodoPage(Todo todo)
        {
            var editTodoViewModel = new EditTodoViewModel();
            editTodoViewModel.SelectedTodo = todo;
            BindingContext = editTodoViewModel;
            InitializeComponent();
        }
    }
}