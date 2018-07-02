using System;
using System.Collections.Generic;
namespace Observer_Game {
    public class Email : IObserver {
        public void Update (string action, string site) {
            Console.WriteLine ("Email: action " + action + " and " + site);
        }
    }
}