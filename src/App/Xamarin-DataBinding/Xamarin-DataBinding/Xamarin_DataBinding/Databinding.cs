using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xamarin_DataBinding
{
    class Databinding
    {
        string helloWorld;

        public string HelloWorld
        {
            get
            {
                return helloWorld;
            }
            set
            {
                if(helloWorld != value)
                {
                    helloWorld = value;
                    OnPropertyChanged("HelloWorld");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;

            if(changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
