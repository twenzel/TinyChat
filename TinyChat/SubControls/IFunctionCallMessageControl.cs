namespace TinyChat;

/// <summary>
/// Represents a control that can display a function call and optionally allow expanding to show the function's arguments and result.
/// </summary>
public interface IFunctionCallMessageControl : IChatMessageControl
{
	/// <summary>
	/// Gets or sets whether the user is allowed to expand function call messages by clicking on them.
	/// </summary>
	public bool AllowExpand { get; set; }
}