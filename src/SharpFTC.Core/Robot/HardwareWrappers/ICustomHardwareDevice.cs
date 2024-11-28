using Android.Runtime;
using Com.Qualcomm.Robotcore.Hardware;
using Java.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFTC.Core.Robot.HardwareWrappers
{
    public partial interface IHardwareDevice : IJavaObject, IJavaPeerable
    {
        virtual bool IsVirtualDevice => false;
        virtual bool IsCustomDevice => false;
    }

    public interface ICustomHardwareDevice : IHardwareDevice
    {
        bool IHardwareDevice.IsCustomDevice => true;
    }

}