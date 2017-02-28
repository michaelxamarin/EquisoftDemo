using System;
using Xamarin.Forms;

namespace EquisoftDemo
{
	public partial class EquisoftDemoPage : ContentPage
	{
		public EquisoftDemoPage()
		{
			InitializeComponent();
			BindingContext = new DemoViewModel();
			//Title = "Home Screen";
		}

		//void ButtonClicked(object o, EventArgs e)
		//{

		//	//MyLabel.Text = "Clicked";

		//	Button button = (Button)o;

		//	button.Text = "Awesome!";

		//	Navigation.PushAsync(new MyPage(), true);


		//}
	}
}
