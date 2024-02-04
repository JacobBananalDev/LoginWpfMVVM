using LoginWpfMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginWpfMVVM.Views
{
    /// <summary>
    /// Interaction logic for LoginUserRegistrationView.xaml
    /// </summary>
    public partial class LoginUserRegistrationView : UserControl
    {
        public LoginUserRegistrationViewModel LoginUserRegistrationVM => LoginUserRegistrationViewModel.Instance;

        public LoginUserRegistrationView()
        {
            InitializeComponent();
            DataContext = LoginUserRegistrationVM;
        }
    }
}
