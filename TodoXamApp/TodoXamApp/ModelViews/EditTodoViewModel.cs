using System;
using System.Windows.Input;
using TodoXamApp.Models;
using TodoXamApp.Services;
using Xamarin.Forms;

namespace TodoXamApp.ModelViews
{
    public class EditTodoViewModel
    {
        private TodoService _todoService = new TodoService();

        public Todo SelectedTodo { get; set; }

        public ICommand EditTodoCommand => new Command(async () =>
        {
            SelectedTodo.UpdatedAt = DateTime.UtcNow;

            await _todoService.PutTodo(SelectedTodo.Id, SelectedTodo);
        });

        public ICommand DeleteTodoCommand => new Command(async () =>
        {
            SelectedTodo.UpdatedAt = DateTime.UtcNow;

            await _todoService.DeleteTodo(SelectedTodo.Id);
        });

    }
}
