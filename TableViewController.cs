using Foundation;
using System;
using UIKit;

namespace HairSalon
{
	public partial class TableViewController : UITableViewController
	{
		public TableViewController(IntPtr handle) : base(handle)
		{
		}


		public override void ViewDidLoad()  


		{
			base.ViewDidLoad();
			string[] items = new string[] { "Men Senior Haircut ", "Men Haircut", "Men Clipper Cut", "Men Colour", "Men Senior Haircut and Colour", "Men Haircut and Tipcap", "Men Children haircut", "Female Senior hair", "Female W and BW", "Female Regrowth", "Female Full Colour", "Female 1/2 Head Foils", "Female Full Head Foils", "Female Perm", "Female Permanent Straight", "Female Eyebrow Waxing", "Female Manicure", "Female Shellac", "Female Pedicure"};
			TableData.Source = new TableSource(items, this);
		}
	}
}















