using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace RFIDEnturnador.src.observables
{
    public interface IObserver
    {
        void update();
        void listen(ArrayList newItems);
        void listen(String barCode);
    }
}
