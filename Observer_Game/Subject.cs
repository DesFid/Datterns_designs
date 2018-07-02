using System;
using System.Collections.Generic;
namespace Observer_Game {
    public class Subject {
        public List<IObserver> observers;
        public string action;
        public string site;
        public Subject(){
            observers = new List<IObserver>();
        }
        public void registerObs(IObserver o){
            Boolean add = false;
            foreach (IObserver ob in observers)
            {
                if (ob == o){
                    add = true;
                }
            } 
            if (add is false){
            observers.Add(o);
        }
        }
        public void deleteObs(IObserver o){
            observers.Remove(o);
        }
        public void executeAction(string a, string l)
        {
            this.action = a;
            this.site = l;
            notify();
        }
        public void notify(){
            foreach (IObserver o in observers)
            {
                o.Update(this.action, this.site);
            }
        }
    }
}