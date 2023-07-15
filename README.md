# ATA.Windows.MessageBox
ATA.Windows.MessageBox is a simple and lightweight C# library for displaying native Windows message boxes and dialogs.

## Features
- Easy integration of native Windows message boxes into your C# applications.
- Customize text, captions, buttons, icons, default buttons, and modal behavior.
- Lightweight and efficient, with minimal dependencies.

## Installation
You can install ATA.Windows.MessageBox via NuGet Package Manager or by using the .NET CLI:
```
dotnet add package ATA.Windows.MessageBox
```

## Usage
Display a simple message box:
```csharp
using ATA.Windows.MessageBox;

MessageBox.Show(
	text: "Hello World", 
	caption: "Greetings", 
	icon: MessageBoxIcon.Information);
```

Display a dialog and get result:
```csharp
using ATA.Windows.MessageBox;

var result = MessageBox.Show(
    text: "Did you like me?",
    caption: "Say Yes!",
    buttons: MessageBoxButtons.YesNo);

switch (result)
{
    case MessageBoxResult.Yes:
        MessageBox.Show(
            text: $"You said yes!",
            caption: "Success!",
            icon: MessageBoxIcon.Information);
        break;
    case MessageBoxResult.No:
        MessageBox.Show(
            text: $"You said no...",
            caption: "Fail!",
            icon: MessageBoxIcon.Warning);
        break;
    default:
        MessageBox.Show(
            text: $"You did something weird...",
            caption: "Confused!",
            icon: MessageBoxIcon.Error);
        break;
}
```


## License
ATA.Windows.MessageBox is released under the [MIT License](https://www.nuget.org/packages/ATA.Windows.MessageBox/1.0.1/License).
