using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUserControlTesting
{
    public abstract class BaseModel:INotifyPropertyChanged
    {
        public void InformPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
