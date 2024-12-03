using Android.Runtime;
using Com.Qualcomm.Robotcore.Eventloop.OpModes;
using SharpFTC.Core.HardwareExtensions;
using SharpFTC.Core.OpMode;

namespace Org.Firstinspires.Ftc.Teamcode;

[TeleOp(Name = "Test Op Mode")]
class TestOpMode : SharpLinearOpMode
{
	readonly SharpRobot bot = new();

	public override void RunOpMode()
	{
		bot.Init(hardwareMap);

		WaitForStart();
		ResetRuntime();

		while (OpModeIsActive())
		{
			bot.LeftFront.SetPower(1);

			telemetry.AddData("power", bot.LeftFront.Power);
			telemetry.Update();
		}
	}
}