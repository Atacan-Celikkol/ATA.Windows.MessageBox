using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ATA.Windows.MessageBoxTests
{
    [TestClass()]
    public class MessageBoxServiceTests
    {
        [TestMethod()]
        public void ShowSimpleWarningTest()
        {
            try
            {
                MessageBox.Show(text: "Hello", caption: "Test", icon: MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Assert.Fail($"An exception was thrown: {ex.Message}");
            }
        }

        [TestMethod()]
        public void ShowDialogTest()
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                Assert.Fail($"An exception was thrown: {ex.Message}");
            }
        }
    }
}