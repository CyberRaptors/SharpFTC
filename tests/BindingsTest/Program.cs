using Com.Qualcomm.Robotcore.Hardware;
using SharpFTC.Core.HardwareExtensions;

namespace BindingsTest;

public class Program
{
    public static void PerformMotorAction(IDcMotor motor, out double newPower)
    {
        motor.Reverse();
        motor.SetPower(1); // or motor.Power = 1;

        newPower = motor.Power;
    }
}