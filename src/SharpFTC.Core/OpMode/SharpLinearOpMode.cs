using Android.Runtime;
using Com.Qualcomm.Robotcore.Eventloop.OpModes;
using Com.Qualcomm.Robotcore.Hardware;
using Org.Firstinspires.Ftc.Robotcore.External;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace SharpFTC.Core.OpMode
{
    public abstract class SharpLinearOpMode : LinearOpMode
    {
        protected readonly ITelemetry telemetry;
        protected readonly Gamepad gamepadOne;
        protected readonly Gamepad gamepadTwo;
        protected readonly HardwareMap hardwareMap;

        public SharpLinearOpMode()
        {
            nint opModeClassHandle = JNIEnv.FindClass("Lcom/qualcomm/robotcore/eventloop/opmodes/LinearOpMode;");

            nint telemetryHandle = JNIEnv.GetObjectField(
                Handle,
                JNIEnv.GetFieldID(
                    opModeClassHandle,
                    "telemetry",
                    "Lorg/firstinspires/ftc/robotcore/external/Telemetry;"
                    )
                );

            telemetry = GetObject<ITelemetry>(telemetryHandle, JniHandleOwnership.DoNotTransfer)!;

            nint gamepadOneHandle = JNIEnv.GetObjectField(
                Handle,
                JNIEnv.GetFieldID(
                    opModeClassHandle,
                    "gamepad1",
                    "Lcom/qualcomm/robotcore/hardware/Gamepad;"
                )
            );

            gamepadOne = GetObject<Gamepad>(gamepadOneHandle, JniHandleOwnership.DoNotTransfer)!;

            nint gamepadTwoHandle = JNIEnv.GetObjectField(
                Handle,
                JNIEnv.GetFieldID(
                    opModeClassHandle,
                    "gamepad2",
                    "Lcom/qualcomm/robotcore/hardware/Gamepad;"
                )
            );

            gamepadTwo = GetObject<Gamepad>(gamepadTwoHandle, JniHandleOwnership.DoNotTransfer)!;

            
            nint hwMapHandle = JNIEnv.GetObjectField(
                Handle,
                JNIEnv.GetFieldID(
                    opModeClassHandle,
                    "hardwareMap",
                    "Lcom/qualcomm/robotcore/hardware/HardwareMap;"
                )
            );

            hardwareMap = GetObject<HardwareMap>(hwMapHandle, JniHandleOwnership.DoNotTransfer)!;




            JNIEnv.DeleteLocalRef(opModeClassHandle);
        }

        public abstract override void RunOpMode();
    }
}
