using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVM.ViewModels
{
    class ShellViewModel : PropertyChangedBase
    {
        public string btnTxt = "button1";
        public string Btntxt
        {
            get { return btnTxt; }
            set
            {
                btnTxt = value;
                NotifyOfPropertyChange(() => btnTxt);
            }
        }
    }
}
