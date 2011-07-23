using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LLRP.src.util;

using System.Collections;

namespace RFIDEnturnador.llrp.src.bussiness
{

   
    public class FakeListenerLLRP : IObserverTag
    {        
        public delegate void tagListenedDH(LLRP_Middleware.src.core.taginfo.Tag tag);
        public event tagListenedDH tagArrived;
        private Hashtable tagscounted;

        public FakeListenerLLRP() {
            tagscounted = new Hashtable();        
        }


        #region Miembros de IObserverTag

        public void UpdateTag(LLRP_Middleware.src.core.taginfo.Tag tag)
        {
           /*if(!tagscounted.ContainsKey(tag.Epc))
           {
               tagscounted.Add(tag.Epc, tag);
               Console.WriteLine("the following tag has arrived {0}" + tag.Epc);
            
            */
            tagArrived(tag);

           //} 
        }

        #endregion

        internal void clearTags()
        {
            tagscounted = new Hashtable();
        }
    }
}
