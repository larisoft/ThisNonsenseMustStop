using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThisNonsenseMustStop
{
    class FactoryBuilder
    {
        //i dont want to tightly couple the IO class and other classes in this app by referencing IO directly in the creation of these objects
        //hence this object seperate the objects it generates from the object that generates them.


        public void getExclude()
        {
            Exclude saved = (Exclude) IO.getInstance().retrieveObject(Settings.getInstance().getExcludedFilesLocation());
            if (saved == null)
            {
                Exclude.getInstance();
            }
            else
            {
                Exclude.setInstance(saved);
                Console.WriteLine("Length found " + Exclude.getInstance().getNames().Count);
            }

        }


        public void getSettings()
        {
            Settings settings = (Settings)IO.getInstance().retrieveObject(Settings.getInstance().getSettingsLocation()); 
            if (settings == null)
            {
                Settings.getInstance();
            }
            else
            {
                Settings.setInstance(settings);
            }

        } 
    }
}
