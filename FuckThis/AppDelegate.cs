using AppKit;
using Foundation;

namespace FuckThis
{
    [Register("AppDelegate")]
    public partial class AppDelegate : NSApplicationDelegate
    {
        public int UntitledWindowCount { get; set; } = 1;

        [Export("newDocument:")]
        void NewDocument(NSObject sender)
        {
            // Get new window
            var storyboard = NSStoryboard.FromName("Main", null);
            var controller = storyboard.InstantiateControllerWithIdentifier("MainWindow") as NSWindowController;

            // Display
            controller.ShowWindow(this);

            // Set the title
            controller.Window.Title = (++UntitledWindowCount == 1) ? "untitled" : string.Format("untitled {0}", UntitledWindowCount);
        }

        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
