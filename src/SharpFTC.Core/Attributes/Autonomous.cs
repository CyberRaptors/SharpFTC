namespace SharpFTC.Core.Attributes;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
#pragma warning disable CS9113 // Parameter is unread.
public sealed class AutonomousAttribute(
	string name = AutonomousAttribute.DefaultOpModeName,
	string group = AutonomousAttribute.DefaultOpModeGroup
) : Attribute
#pragma warning restore CS9113 // Parameter is unread.
{
	const string DefaultOpModeName = "Default SharpFTC Autonomous OpMode";
	const string DefaultOpModeGroup = "Default SharpFTC Autonomous Group";

	public readonly string Name = name;
	public readonly string Group = group;
}