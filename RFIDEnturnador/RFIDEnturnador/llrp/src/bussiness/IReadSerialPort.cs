using System;
using System.Collections.Generic;
using System.Text;

namespace RFIDEnturnador.src.bussiness
{
    public interface IReadSerialPort
    {
        //Inits to read Serial Port
        void start();

        //Stops to read Serial Port
        void stop();

        //Pauses to read Serial Port
        void pause();

        //Return state of this thread
        int getState();
    }
}
