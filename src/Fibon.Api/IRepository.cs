using System;
using System.Collections.Generic;
namespace Fibon.Api
{
	public interface IRepository
	{
		int? Get(int number);
        void Insert(int number, int result);
	}
}
