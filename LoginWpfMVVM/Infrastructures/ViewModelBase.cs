using LoginWpfMVVM.Data.QueryLoginWpfMVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LoginWpfMVVM.Infrastructures
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public QueryLoginWpfMVVM QueryLogin => QueryLoginWpfMVVM.Instance;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void HandleException(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

    }
}
