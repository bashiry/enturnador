using System;
using System.Collections.Generic;
using System.Text;

namespace RFIDEnturnador.src.bussiness
{
    public abstract class AbstractReadSerialPort : IReadSerialPort
    {
        protected MySerialPort serialPort;

        public AbstractReadSerialPort(MySerialPort serialPort)
        {
            this.serialPort = serialPort;
        }

        public abstract int getState();

        /**
        * See the documentation of IReadSerialPort.start()
        */
        public abstract void start();

        /**
         * See the documentation of IReadSerialPort.stop();
         */
        public abstract void stop();

        public abstract void pause();
    }
}
