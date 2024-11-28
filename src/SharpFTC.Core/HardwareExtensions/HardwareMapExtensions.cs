using Android.Runtime;
using Com.Qualcomm.Robotcore.Hardware;
using Java.Interop;
using SharpFTC.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFTC.Core.HardwareExtensions
{
    public static class HardwareMapExtensions
    {
        public static TDevice FetchHardwareDevice<TDevice>(this HardwareMap hardwareMap, string deviceName) where TDevice : IJavaObject, IJavaPeerable
        {
            // does this work... ? and why cna we convert to IDcMotor but not T : IJavaObject, IJavaPeerable
            return (TDevice) (object) hardwareMap.Get(ClassObject.Get<TDevice>(), deviceName)!;
        }
    }
}
