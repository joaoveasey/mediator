using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator_app1_facebook_group
{
    // colleague
    public abstract class User
    {
        protected WhatsAppGroupMediator mediator;
        protected string? Name { get; set; }

        public User(WhatsAppGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            Name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
