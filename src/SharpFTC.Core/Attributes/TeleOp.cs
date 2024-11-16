namespace SharpFTC.Core.Attributes;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
#pragma warning disable CS9113 // Parameter is unread.
public sealed class TeleOpAttribute(
	string name = TeleOpAttribute.DefaultOpModeName,
	string group = TeleOpAttribute.DefaultOpModeGroup
) : Attribute
#pragma warning restore CS9113 // Parameter is unread.
{
	const string DefaultOpModeName = "Default SharpFTC TeleOp OpMode";
	const string DefaultOpModeGroup = "Default SharpFTC TeleOp Group";

	public readonly string Name = name;
	public readonly string Group = group;
}