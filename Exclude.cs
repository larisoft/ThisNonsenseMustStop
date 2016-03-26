using System;
using System.Collections.Generic;
using System.Text;

namespace ThisNonsenseMustStop
{
    //class to group all the PIDS that should not be closed.
    //i will extend this later if the app is successful so users can 
    //add apps they would like to keep online.
    [Serializable]
    class Exclude
    {
        private static Exclude instance;

        private Exclude()
        {
        }

        //this is for instantiating this object from a saved location
        public static void setInstance(Exclude retrieved)
        {
            instance = retrieved;
        }

        public static Exclude getInstance()
        {
            if (instance == null) instance = new Exclude();

            return instance;
        }


        HashSet<uint> excludedPids = new HashSet<uint>();
        HashSet<String> excludedNames = new HashSet<String>();


        public Boolean isExcluded(uint pid)
        {
            return excludedPids.Contains(pid);
        }

        public Boolean isExcluded(String Name)
        {
            return excludedNames.Contains(Name);
        }

        //add an excluded pid
        public void addPid(uint pid)
        {
            excludedPids.Add(pid);
        }

        //add an excluded name
        public void addName(String Name)
        {
            excludedNames.Add(Name);
        }

        //remove name
        public void removeName(String Name)
        {
            excludedNames.Remove(Name); 
        }


        public void removePid(uint pid)
        {
            excludedPids.Remove(pid);
        }

        public List<String> getNames()
        {
            List<String> result = new List<String>();

            foreach(String s in excludedNames){
                result.Add(s);
            }

            return result;
        }
    }
}
