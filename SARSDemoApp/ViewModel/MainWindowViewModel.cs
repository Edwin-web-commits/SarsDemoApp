using SARSDemoApp.Command;
using SARSDemoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SARSDemoApp.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public UserProfileViewModel UserProfileViewModel { get; }
        public EditUserViewModel EditUserViewModel { get; }
        public RegisterViewModel RegisterViewModel { get; }
        public LoginViewModel LoginViewModel { get; }
        public LogOutViewModel LogOutViewModel { get; }
        private ViewModelBase? _selectedViewModel;

        private Visibility _isUserLoggedIn;

        


        public MainWindowViewModel(UserProfileViewModel userProfileViewModel, EditUserViewModel editUserViewModel, RegisterViewModel registerViewModel, LoginViewModel loginViewModel,LogOutViewModel logOutViewModel)
        {
            UserProfileViewModel = userProfileViewModel;
            EditUserViewModel = editUserViewModel;
            RegisterViewModel = registerViewModel;
            LoginViewModel = loginViewModel;
            LogOutViewModel = logOutViewModel;

            IsUserLoggedIn = Visibility.Hidden;

           // SelectedViewModel = UserProfileViewModel;
            SelectedViewModel = loginViewModel;
            SelectViewModelCommand = new DelegateCommand(SelectViewModel);
            
        }

        public Visibility IsUserLoggedIn
        {
            get {return _isUserLoggedIn; }
            set 
            {
                _isUserLoggedIn = value;
                RaisePropertyChanged();
                
            }

        }



        private async void SelectViewModel(object? parameter)
        {
            SelectedViewModel = parameter as ViewModelBase;
            await LoadAsync();
        }

        public ViewModelBase? SelectedViewModel
        {
            get { return _selectedViewModel; }
            set { _selectedViewModel = value;
                RaisePropertyChanged();
            }
        }

        public DelegateCommand SelectViewModelCommand { get; }
        
        public async override Task LoadAsync()
        {
            if(SelectedViewModel is not null)
            {
                await SelectedViewModel.LoadAsync();
            }
        }




    }
}
