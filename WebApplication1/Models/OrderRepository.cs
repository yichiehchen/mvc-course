using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class OrderRepository : EFRepository<Order>, IOrderRepository
	{

	}

	public  interface IOrderRepository : IRepository<Order>
	{

	}
}