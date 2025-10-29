using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Trade.Domain.Commons
{
    public abstract class BaseEvent
    {
        public Guid MessageId { get; set; }
        public DateTime PublishTime { get; set; }
    }
}
