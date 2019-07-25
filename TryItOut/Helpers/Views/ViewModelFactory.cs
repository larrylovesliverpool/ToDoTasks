using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryItOut.ViewModels;

namespace TryItOut.Helpers.Views
{
    public class ViewModelFactory : IViewModelFactory
    {
        /* ************************************************************* */
        /* Create instance of view model, together with initial settings */
        /* ************************************************************* */


        public ViewModelFactory() {

        }

        public HomeViewModel CreateHomeViewModel() {

            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Message = new MessageBaseViewModel();

            return homeViewModel;
        }

        public HomeViewModel CreateHomeViewModel(string title, string message)
        {

            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Message = new MessageBaseViewModel();

            homeViewModel.Title = title;
            homeViewModel.Message.IsActive = true;
            homeViewModel.Message.Text = message;

            return homeViewModel;
        }

        public AboutViewModel CreateAboutViewModel() {

            AboutViewModel aboutViewModel = new AboutViewModel();
            aboutViewModel.Message = new MessageBaseViewModel();

            return aboutViewModel;
        }

        public RegisteredUsersViewModel CreateRegisteredUsersViewModel()
        {
            RegisteredUsersViewModel usersViewModel = new RegisteredUsersViewModel();
            usersViewModel.Message = new MessageBaseViewModel();

            return usersViewModel;
        }

    }
}