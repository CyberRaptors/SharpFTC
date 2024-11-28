using Com.Qualcomm.Hardware.Sparkfun;
using Com.Qualcomm.Robotcore.Hardware;
using Java.Lang;

namespace SharpFTC.Core.Utils
{
    public static class ClassObject
    {
        public static readonly Class DcMotor = Get<IDcMotor>();
        public static readonly Class DcMotorEx = Get<IDcMotorEx>();
        public static readonly Class Servo = Get<IServo>();
        public static readonly Class CRServo = Get<ICRServo>();

        public static readonly Class SparkFunOTOS = Get<SparkFunOTOS>();

        public static Class Get<T>()
        {
            return Class.FromType(typeof(T));
        }
    }
}
