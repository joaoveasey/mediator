using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator_app1_facebook_group
{
    // concrete mediator
    public class ConcreteWhatsAppGroupMediator : WhatsAppGroupMediator
    {
        private List<User> users = new List<User>();

        // registrar usuario no grupo
        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var u in users)
            {
                // mensagem não deve ser recebida pelo usuário que enviou
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
