using System;
using System.Windows.Input;
using TodoXamApp.Models;
using TodoXamApp.Services;
using Xamarin.Forms;

namespace TodoXamApp.ModelViews
{
    public class AddTodoViewModel
    {
        private TodoService _todoService = new TodoService();

        public Todo SelectedTodo { get; set; }

        public ICommand SendTodoCommand => new Command(async () =>
        {
            SelectedTodo.UpdatedAt = DateTime.UtcNow;
            await _todoService.PostTodo(SelectedTodo);
        });

        public AddTodoViewModel()
        {
            SelectedTodo = new Todo();
        }

    }
}
