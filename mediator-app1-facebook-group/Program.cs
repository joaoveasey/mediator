using mediator_app1_facebook_group;

WhatsAppGroupMediator wppMediator = 
    new ConcreteWhatsAppGroupMediator();

User joao = new ConcreteUser(wppMediator, "João");
User ze = new ConcreteUser(wppMediator, "Zé");
User maria = new ConcreteUser(wppMediator, "Maria");
User yuri = new ConcreteUser(wppMediator, "Yuri");

wppMediator.RegisterUser(joao);
wppMediator.RegisterUser(ze);
wppMediator.RegisterUser(maria);
wppMediator.RegisterUser(yuri);

joao.Send("Oi, pessoal!");

joao.Send("Usando o padrão Mediator!");

yuri.Send("Oi!");

maria.Send("Oi, pessoal!");

Console.ReadKey();
