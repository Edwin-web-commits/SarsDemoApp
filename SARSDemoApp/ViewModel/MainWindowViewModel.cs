using SARSDemoApp.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARSDemoApp.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public UserProfileViewModel UserProfileViewModel { get; }
        public EditUserViewModel EditUserViewModel { get; }
        public RegisterViewModel RegisterViewModel { get; }
        public LoginViewModel LoginViewModel { get; }
        private ViewModelBase? _selectedViewModel;

        public MainWindowViewModel(UserProfileViewModel userProfileViewModel, EditUserViewModel editUserViewModel, RegisterViewModel registerViewModel, LoginViewModel loginViewModel)
        {
            UserProfileViewModel = userProfileViewModel;
            EditUserViewModel = editUserViewModel;
            RegisterViewModel = registerViewModel;
            LoginViewModel = loginViewModel;
            SelectedViewModel = UserProfileViewModel;
            SelectViewModelCommand = new DelegateCommand(SelectViewModel);
            
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
