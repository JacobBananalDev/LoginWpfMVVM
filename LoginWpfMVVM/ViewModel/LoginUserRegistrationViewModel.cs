using LoginWpfMVVM.Data.Entity;
using LoginWpfMVVM.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LoginWpfMVVM.ViewModel
{
    public class LoginUserRegistrationViewModel : ViewModelBase
    {
        private static LoginUserRegistrationViewModel m_SingletonInstance = null;
        public static LoginUserRegistrationViewModel Instance
        {
            get
            {
                if (m_SingletonInstance == null)
                {
                    m_SingletonInstance= new LoginUserRegistrationViewModel();
                }
                return m_SingletonInstance;
            }
        }

        private LoginUserRegistrationViewModel()
        {

        }

        private string m_UserName = string.Empty;
        public string UserName
        {
            get => m_UserName;
            set
            {
                if (m_UserName != value)
                {
                    m_UserName = value;
                    OnPropertyChanged(nameof(UserName));
                }
            }
        }


        private string m_UserPassword = string.Empty;
        public string UserPassword
        {
            get => m_UserPassword;
            set
            {
                if (m_UserPassword != value)
                {
                    m_UserPassword = value;
                    OnPropertyChanged(nameof(UserPassword));
                }
            }
        }


        private string m_FirstName = string.Empty;
        public string FirstName
        {
            get => m_FirstName;
            set
            {
                if (m_FirstName != value)
                {
                    m_FirstName = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }


        private string m_LastName = string.Empty;
        public string LastName
        {
            get => m_LastName;
            set
            {
                if (m_LastName != value)
                {
                    m_LastName = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }

        private string m_Email = string.Empty;
        public string Email
        {
            get => m_Email;
            set
            {
                if (m_Email != value)
                {
                    m_Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }


        private RelayCommand m_AddUserCommand = null;
        public RelayCommand AddUserCommand
        {
            get
            {
                if (m_AddUserCommand == null)
                {
                    m_AddUserCommand = new RelayCommand(ExecuteAddUserCommand, CanExecuteAddUserCommand);
                }
                return m_AddUserCommand;
            }
        }

        private void ExecuteAddUserCommand(object obj)
        {
            LoginUser user = new LoginUser()
            {
                Username = UserName,
                Password = UserPassword,
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
            };

            if (QueryLogin.AddNewUser(user) == true)
            {
                MessageBox.Show($"{UserName} added Successfully");

                ClearValues();
            }
            else
            {
                MessageBox.Show($"Adding New User Failed");
            }
        }

        private void ClearValues()
        {
            UserName = string.Empty;
            UserPassword = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
        }

        private bool CanExecuteAddUserCommand(object arg)
        {
            return string.IsNullOrEmpty(UserName) == false &&
                   string.IsNullOrEmpty(UserPassword) == false &&
                   string.IsNullOrEmpty(FirstName) == false &&
                   string.IsNullOrEmpty(LastName) == false &&
                   string.IsNullOrEmpty(Email) == false;
        }
    }
}
