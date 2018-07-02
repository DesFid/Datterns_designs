using System;
using System.Collections.Generic;
namespace Observer_Game {
    public class InformB : IObserver {
        public void Update (string action, string site) {
            Console.WriteLine ("Inform: action " + action + " and " + site);
        }
    }
}