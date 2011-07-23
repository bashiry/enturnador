using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.IO;

using RFIDEnturnador.src.observables;


namespace RFIDEnturnador.src.bussiness
{
    public class MySerialPort: Observable
    {
        /**
        * Used to write stuff to the log. 
        */
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private SerialPort sPort;

        public MySerialPort(String port)
        {
            try
            {
                sPort = new SerialPort(port);
            }
            catch (Exception exc)
            {

                throw new Exception("COM FAILURE");
            }           
        }

        public String readSerialPort()
        {
            String rta = "";

            if ((sPort.IsOpen) == true)
            {
                try
                {
                    rta = sPort.ReadLine().ToString();
                  ///  log.Debug("Data serial port :"+ rta);
                    notifyObservers(rta);
                }
                catch (Exception e)
                {
                    ///log.Warn("Read Serial Port closed, " + e.Message);
                }
            }
            return rta;
        }

        public void OpenSerialPort()
        {
            try
            {
                sPort.Open();
            }
            catch (IOException exc)
            {

                throw exc;
            }
            catch (Exception exc) {

                throw exc;
            }
        }

        public void CloseSerialPort()
        {
            sPort.Close();
        }
    }
}
