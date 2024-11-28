using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Qualcomm.Robotcore.Hardware.Configuration
{
    public partial class DeviceConfiguration : Java.Lang.Object, Java.IO.ISerializable, Java.Lang.IComparable
    {
        public virtual int CompareTo(Java.Lang.Object o) => CompareTo(o as DeviceConfiguration);
    }
}
