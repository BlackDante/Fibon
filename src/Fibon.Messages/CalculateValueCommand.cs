using System;
namespace Fibon.Messages
{
	public class CalculateValueCommand : ICommand
	{
		public int Number
		{
			get;
			set;
		}
	}
}
