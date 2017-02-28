using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EquisoftDemo
{
	public class DemoViewModel : INotifyPropertyChanged
	{
		public DemoViewModel()
		{

			LoginCommand = new Command(async () => await Login(),() => !IsBusy);

			Person user = new Person("Michael");
			name = user.FirstName;
		}

		#region Properties
		private String name = "";
		public String Name
		{

			get { return name; }
			set
			{
				name = value;
				OnPropertyChanged();
			}

		}

		private String myInput = "";
		public String MyInput
		{
			get { return myInput; }
			set 
			{ 
				myInput = value;
				OnPropertyChanged();
			}
		}

		private Boolean isBusy = false;

		public event PropertyChangedEventHandler PropertyChanged;
		void OnPropertyChanged([CallerMemberName] string controlName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(controlName));
		}


		public Boolean IsBusy
		{

			get { return isBusy; }
			set
			{
				isBusy = value;
				OnPropertyChanged();
				LoginCommand.ChangeCanExecute();

			}

		}
		#endregion

		#region Command

		public Command LoginCommand { get; }
		async Task Login() //runs in background
		{

			IsBusy = true;
			await Task.Delay(5000);

			IsBusy = false;

			await Application.Current.MainPage.DisplayAlert("Error", "Login Error, Try Again!","OK");

		}

		#endregion


	}
}
