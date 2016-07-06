using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace DemoXIBLess
{
	public class FirstViewController : UIViewController
	{
		public FirstViewController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.View.BackgroundColor = UIColor.White;

			var label = new UILabel (new RectangleF (10, 40, 300, 30));
			label.Text = "Demo Application";
			label.TextAlignment = UITextAlignment.Center;

			this.View.AddSubview (label);
		}
	}
}

