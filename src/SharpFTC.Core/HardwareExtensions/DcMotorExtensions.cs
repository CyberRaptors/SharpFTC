using Com.Qualcomm.Robotcore.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFTC.Core.HardwareExtensions
{
    public static class DcMotorExtensions
    {
        public static void SetPower(this IDcMotorSimple motor, double power)
        {
            motor.Power = power;
        }

        public static IDcMotorSimple.MotorDirection Reverse(this IDcMotorSimple motor)
        {
            if (motor.Direction == IDcMotorSimple.MotorDirection.Forward) motor.Direction = IDcMotorSimple.MotorDirection.Reverse;
            else motor.Direction = IDcMotorSimple.MotorDirection.Forward;

            return motor.Direction!;
        }
    }
}
