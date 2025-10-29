using Pacagroup.Trade.Domain.Commons;
using Pacagroup.Trade.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Trade.Domain.Events
{
    public class OrderCreatedEvent : BaseEvent
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public OrderSide Side { get; set; }
        public DateTime TransactTime { get; set; }
        public int Quantity { get; set; }
        public OrderType Type { get; set; }
        public decimal Price { get; set; }
    }
}
