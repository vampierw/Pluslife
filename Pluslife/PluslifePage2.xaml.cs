using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Pluslife
{
	public partial class PluslifePage2 : ContentPage
	{
		public PluslifePage2(issuedetail issueprofile)
		{
			InitializeComponent();

			lblissue.Text = issueprofile.issue;
			//lbltype.Text = issueprofile.type;
			lblplace.Text = issueprofile.place;
			lbldate.Text = issueprofile.dateissue.ToString();
			lbltime.Text = issueprofile.timeissue.ToString();

		}
	}
}

