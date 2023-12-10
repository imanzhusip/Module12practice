using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12practice
{
    public delegate void PropertyeventHandler(object sender, PropertyEventArgs e);
    public class PropertyEventArgs : EventArgs
    {
        public string PropertyName { get; }
        public PropertyEventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}
