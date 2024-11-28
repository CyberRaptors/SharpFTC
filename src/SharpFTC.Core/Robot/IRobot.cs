using Com.Qualcomm.Robotcore.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFTC.Core.Robot
{
    public interface IRobot
    {
        void Init(HardwareMap hardwareMap);
    }
}
