using System;
using System.Collections.Generic;
using System.Text;

namespace ThisNonsenseMustStop
{
    //this class is used to collect all the PIDS in one release:i.e. console output
    //there is no way to differentiate the different pids released each time we get console output
    //other than to detect which ones were collected within a space of one second.
    //thus, this object groups reported PIDS by checking if they were reported within the last one second.
    class PidCollector
    {

        private List<uint> pids = new List<uint>();

        //objects monitoring this object
        private List<CollectorObserver> observers = new List<CollectorObserver>();

        double limit_time = 1000; //one second

        double lastInsert = -1;
         

        public void addPid(uint pid)
        {
          //first time we are adding in this batch
          if(lastInsert == (-1)){
              lastInsert = DateTime.Now.Millisecond;
              pids.Add(pid);
          }
          else{
              //if one second has not elapsed since last addition
              double now =ToUnixTimestamp(DateTime.Now); 
              double distance = now - lastInsert; 
              if((distance) < limit_time) {
                  if (!pids.Contains(pid))
                  {
                      pids.Add(pid);
                  }
                  lastInsert = now;
              }
              else{ 
                  //this batch is due for processing
                  notifyBatchComplete(pids);
                  pids.Clear();
                  lastInsert = now;
                  pids.Add(pid);
              }

          }
        }


        private double ToUnixTimestamp(DateTime dateTime)
        {
            TimeSpan span = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));
            double unixTime = span.TotalMilliseconds; 
            return unixTime;
        }

        public void addObserver(CollectorObserver observer)
        {
            observers.Add(observer);
        }


        public void notifyBatchComplete(List<uint> pids){

            foreach (CollectorObserver obs in observers)
            {
                obs.batch_complete(pids);
            }

        }

        private void log(String message)
        {
            Console.WriteLine(message);
        }

        
    }
}
