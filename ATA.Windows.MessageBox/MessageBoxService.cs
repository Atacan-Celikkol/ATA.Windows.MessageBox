using System.Runtime.InteropServices;

namespace ATA.Windows.MessageBox;

public class MessageBox
{
    [DllImport("user32.dll")]
    static extern int MessageBoxA(nint hWnd, string lpText, string lpCaption, uint uType);

    /// <summary>
    /// Displays a message box or dialog with the specified text and optional parameters.
    /// </summary>
    /// <param name="text">The text to display in the message box.</param>
    /// <param name="caption">The caption/title of the message box (optional).</param>
    /// <param name="buttons">The buttons to display in the message box (optional).</param>
    /// <param name="icon">The icon to display in the message box (optional).</param>
    /// <param name="defaultButton">The default button of the message box (optional).</param>
    /// <param name="modal">The modal behavior of the message box (optional).</param>
    /// <returns>The result of the message box.</returns
    public static MessageBoxResult Show(string text, string? caption = null, MessageBoxButtons? buttons = null, MessageBoxIcon? icon = null, MessageBoxDefaultButton? defaultButton = null, MessageBoxModal? modal = null)
    {
        uint uType = (uint)(buttons ?? MessageBoxButtons.Ok) | (uint)(icon ?? MessageBoxIcon.None) | (uint)(defaultButton ?? MessageBoxDefaultButton.Button1) | (uint)(modal ?? MessageBoxModal.Application);
        return (MessageBoxResult)MessageBoxA(nint.Zero, text, caption ?? "\0", uType);
    }
}

public enum MessageBoxButtons : uint
{
    Ok = 0x00000000,
    OkCancel = 0x00000001,
    YesNo = 0x00000004,
    YesNoCancel = 0x00000003
}

public enum MessageBoxResult
{
    Ok = 1,
    Cancel = 2,
    Abort = 3,
    Retry = 4,
    Ignore = 5,
    Yes = 6,
    No = 7,
    TryAgain = 10,
    Continue = 11
}

public enum MessageBoxDefaultButton : uint
{
    Button1 = 0x00000000,
    Button2 = 0x00000100,
    Button3 = 0x00000200,
    Button4 = 0x00000300
}

public enum MessageBoxModal : uint
{
    Application = 0x00000000,
    System = 0x00001000,
    Task = 0x00002000
}

public enum MessageBoxIcon : uint
{
    None = 0x00000000,
    Warning = 0x00000030,
    Information = 0x00000040,
    Error = 0x00000010
}
