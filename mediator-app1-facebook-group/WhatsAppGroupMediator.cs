using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator_app1_facebook_group;

public interface WhatsAppGroupMediator
{
    public void RegisterUser(User user);
    public void SendMessage(string message, User user);
}
