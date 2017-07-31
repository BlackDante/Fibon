﻿using System;
using System.Threading.Tasks;

namespace Fibon.Messages
{
	public interface IEventHandler<in T> where T : IEvent
	{
		Task HandleAsync(T @event);
	}
}