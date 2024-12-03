using Com.Qualcomm.Robotcore.Hardware;
using SharpFTC.Core.HardwareExtensions;
using SharpFTC.Core.Robot;

namespace Org.Firstinspires.Ftc.Teamcode;
internal class SharpRobot : IMecanumRobot
{
	#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
	public IDcMotor LeftFront { get; private set; }

	public IDcMotor RightFront { get; private set; }

	public IDcMotor LeftBack { get; private set; }

	public IDcMotor RightBack { get; private set; }
	#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

	public void Init(HardwareMap hardwareMap)
	{
		LeftFront = hardwareMap.FetchHardwareDevice<IDcMotor>("leftFront");
		RightFront = hardwareMap.FetchHardwareDevice<IDcMotor>("rightFront");
		LeftBack = hardwareMap.FetchHardwareDevice<IDcMotor>("leftBack");
		RightBack = hardwareMap.FetchHardwareDevice<IDcMotor>("rightBack");
	}
}