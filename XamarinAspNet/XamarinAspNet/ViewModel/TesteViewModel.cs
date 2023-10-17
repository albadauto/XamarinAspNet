using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinAspNet.ViewModel
{
    
    public class TesteViewModel : NotifyBase
    {
		private string _name;
		private string _message;

		public string Message
		{
			get { 
				return _message;
			}
			set { 
				_message = value;
				Notify();
			}
		}


		public string Name
		{
			get { 
				return _name;
			}
			set { 
				_name = value;
				Notify();
			}
		}

		public Command ExibeMensagem
		{
			get
			{
				return new Command(() =>
				{
					Message = "Olá " + Name;
				});
			}
		}

	}
}
