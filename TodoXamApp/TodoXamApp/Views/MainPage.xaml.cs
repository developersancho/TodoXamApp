using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoXamApp.Models;
using TodoXamApp.Views;
using Xamarin.Forms;

namespace TodoXamApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void BtnAddTodo_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTodoPage());
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var todo = e.Item as Todo;

            Navigation.PushAsync(new EditTodoPage(todo));
        }
    }
}
