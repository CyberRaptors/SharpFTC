using System.Diagnostics.CodeAnalysis;

namespace SharpFTC.Core.Attributes;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
#pragma warning disable CS9113 // Parameter is unread.
public sealed class UseRobotControllerProjectAttribute([ConstantExpected] string projectPath) : Attribute
#pragma warning restore CS9113 // Parameter is unread.
{
	
}