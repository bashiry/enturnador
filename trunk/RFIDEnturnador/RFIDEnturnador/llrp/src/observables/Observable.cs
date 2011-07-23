using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace RFIDEnturnador.src.observables
{
    public class Observable
    {
        protected ArrayList observers;

        public Observable()
        {
            this.observers = new ArrayList();
        }

        public void addObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        //Notifies to Observers one change in inventory 
        public void notifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.update();
            }
        }

        //Notifies to Observers one change in inventory 
        public void notifyObservers(ArrayList newItems)
        {
            foreach (IObserver observer in observers)
            {
                observer.listen(newItems);
            }
        }

        public void notifyObservers(String data)
        {
            foreach (IObserver observer in observers)
            {
                observer.listen(data);
            }
        }
    }
}
