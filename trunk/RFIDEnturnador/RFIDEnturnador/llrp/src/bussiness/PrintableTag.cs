using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RFIDEnturnador.llrp.src.bussiness
{
   public  class PrintableTag:IComparable
    {

        String EPC;

        public String epc
        {
            get { return EPC; }
            set { EPC = value; }
        }

        String Hexa;

        public String hexa
        {
            get { return Hexa; }
            set { Hexa = value; }
        }

       public PrintableTag() { 
       
       
       }


       #region Miembros de IComparable

       public int CompareTo(object obj)
       {
           PrintableTag tagtoCompare = (PrintableTag)obj;
           return String.Compare(this.hexa, tagtoCompare.hexa);         
           
       }

       #endregion
    }
}
