using System;
using System.Threading.Tasks;

namespace Fibon.Messages
{
	public interface ICommandHandler<in T> where T : ICommand
	{
		Task HandleAsync(T command);
	}
}
