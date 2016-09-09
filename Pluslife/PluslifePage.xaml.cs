using Xamarin.Forms;
using System;

namespace Pluslife
{
	public partial class PluslifePage : ContentPage
	{
		public PluslifePage()
		{
			InitializeComponent();

		}


		async void Handle_Clicked(object sender, System.EventArgs e)
		{

			var issueprofile = new issuedetail();
			issueprofile.issue = etissue.Text;
			issueprofile.type = ettype.Text;
			issueprofile.place = etplace.Text;
			issueprofile.dateissue =  DateTime.Parse(etdate.Text);
			issueprofile.timeissue = TimeSpan.Parse(ettime.Text);
			await Navigation.PushAsync(new PluslifePage2(issueprofile));
		
		}

		//public void myPickerSelectedIndexChanged(object sender, EventArgs e)
		//{
		//	var selectedValue = ettype.Items[ettype.SelectedIndex];
		//}


	}
}

