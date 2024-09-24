using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator_app1_facebook_group
{
    public class ConcreteUser : User
    {
        public ConcreteUser (WhatsAppGroupMediator mediator, string name) 
            : base(mediator, name)
        {}

        public override void Send(string message)
        {
            Console.WriteLine($"{Name} enviando mensagem: {message}");
            mediator.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{Name} recebeu mensagem: {message}");
        }
    }
}
