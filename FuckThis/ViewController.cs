using System;

using AppKit;
using Foundation;

namespace FuckThis
{
    public partial class ViewController : NSViewController
    {
        private int numberPfTimesClicked = 0;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            ClickedLabel1.StringValue = "Click it";
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void ClickedButton(NSObject sender)
        {
            ClickedLabel1.StringValue = string.Format("Fuck Mac {0} times", ++numberPfTimesClicked, numberPfTimesClicked);
        }
    }
}
