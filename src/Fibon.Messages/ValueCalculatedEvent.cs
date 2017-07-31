using System;
namespace Fibon.Messages
{
	public class ValueCalculatedEvent : IEvent
	{
		public int Number
		{
			get;
			set;
		}

		public int Result
		{
			get;
			set;
		}
	}
}
