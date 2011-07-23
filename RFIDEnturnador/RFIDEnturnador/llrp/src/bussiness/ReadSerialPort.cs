using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RFIDEnturnador.src.bussiness
{
    class ReadSerialPort : AbstractReadSerialPort
    {
        /**
        * Logger
        */
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static int IDLE = 0;

        /**
         *  Action read state: Started to read Serial Port
         */
        public static int STARTED = 1;

        /**
         * Action read state: Stoped to read Serial Port
         */
        public static int STOPED = 2;

        /**
         * Action read state: Paused 
         */
        public static int PAUSED = 3;

        /**
         * The state to read Serial Port
         */
        private int state;

        public ReadSerialPort(MySerialPort serialPort)
            : base(serialPort)
        {
            this.state = IDLE;
        }

        public override void start()
        {
            if (state != STARTED)
            {
                serialPort.OpenSerialPort();
                state = STARTED;
                ThreadStart runStart = new ThreadStart(run);
                Thread thread = new Thread(runStart);
                thread.Name = " Read SerialPort ";
                thread.Start();
                //log.Info(" Reading serial port ");
            }
        }

        public override void stop()
        {
            if (state != STOPED)
            {
                state = STOPED;
            }

            serialPort.CloseSerialPort();

           // log.Debug(" Reading serial port STOPED");
        }


        public override void pause()
        {
            if (state != PAUSED)
            {
                state = PAUSED;
            }
            //log.Debug(" Reading serial port PAUSED");
        }

        public void run()
        {
            //log.Debug(" Reading serial port STARTED");
            String rta = "";

            while (state == STARTED)
            {
                rta = serialPort.readSerialPort();
              //  log.Debug(" Reading SerialPort : " + rta);
            }

            //log.Info(" Reading SerialPort finalizated... ");
        }

        public override int getState()
        {
            return state;
        }
    }
}
