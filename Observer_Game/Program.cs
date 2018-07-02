using System;

namespace Observer_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject suject;
            Email email;
            InformB informB;
            Int32 option = 0;
            suject = new Subject();
            email = new Email();
            informB = new InformB();
            suject.executeAction("Run", "Home");
            string newObserver = "";
            do{
                    Console.WriteLine("1 Register Observer");
                    Console.WriteLine("2 Delete Observer");
                    Console.WriteLine("3 Action");
                    Console.WriteLine("4 Exit");
                    Console.Write("Write the number: ");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch(option){
                        case 1:
                        Console.WriteLine("A Email\nB Informer");
                        Console.Write("Write the option: ");
                        newObserver = Console.ReadLine();
                        switch(newObserver){
                            case "A":
                            suject.registerObs(email);
                            break;
                            case "B":
                            suject.registerObs(informB);
                            break;
                        }
                        Console.WriteLine("Observer added");
                        break;
                        case 2:
                        Console.WriteLine("A Email\nB Informer");
                        Console.Write("Write the option: ");
                        newObserver = Console.ReadLine();
                        switch(newObserver){
                            case "A":
                            suject.registerObs(email);
                            break;
                            case "B":
                            suject.registerObs(informB);
                            break;
                        }
                        Console.WriteLine("Observer removed");
                        break;
                        case 3:
                        Console.Write("Action: ");
                        string action = Console.ReadLine();
                        Console.Write("Site: ");
                        string site = Console.ReadLine();
                        suject.executeAction(action, site);
                        break;
                    }
            }while(option != 4);
        }
    }
}
