using LoginWpfMVVM.Data.Helper;
using LoginWpfMVVM.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWpfMVVM.Data.QueryLoginWpfMVVM
{
    public class QueryLoginWpfMVVM : SQLQueryBase, IQueryLoginWpfMVVM
    {
        private static QueryLoginWpfMVVM m_SingletonInstance = null;
        public static QueryLoginWpfMVVM Instance
        {
            get
            {
                if (m_SingletonInstance == null) 
                {
                    m_SingletonInstance = new QueryLoginWpfMVVM();
                }

                return m_SingletonInstance;
            }
        }

        private QueryLoginWpfMVVM()
        {

        }
    }
}
