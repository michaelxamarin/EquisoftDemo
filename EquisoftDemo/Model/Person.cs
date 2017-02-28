using System;
namespace EquisoftDemo
{
	public class Person
	{
		public Person(String firstName)
		{

			this._firstName = firstName;
		}

		private String _firstName;
		public String FirstName
		{

			get { return _firstName;}
			set
			{
				_firstName = value;

			}
		}

	}
}
