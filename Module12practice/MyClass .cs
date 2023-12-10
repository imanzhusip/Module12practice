using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12practice
{
    public class MyClass : IPropertyChanged
    {
        private int myProperty;
        public int MyProperty
        {
            get { return myProperty; }
            set
            {
                if (myProperty != value)
                {
                    myProperty = value;
                    OnMyPropertyChanged();
                }
            }
        }
        public event PropertyeventHandler PropertyChanged;
        protected virtual void OnMyPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyEventArgs(nameof(MyProperty)));
        }
    }
}
