using System;
using System.Collections.Generic;
using System.Text;

namespace ThisNonsenseMustStop
{
    //this item is implemented by all objects that which to be notified of 
    //whats going on with our monitor class
    public interface OperationObserver
    {
        void processKilled(String name, uint Pid);

        void processSkipped(String name, uint Pid); 

         
    }
}
