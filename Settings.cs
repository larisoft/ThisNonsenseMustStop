using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ThisNonsenseMustStop
{  
    [Serializable]
    class Settings
    {
        private String reportName = "reports.txt";

        private Boolean appstatus = true;

        public static Settings instance;

        List<String> AppNames = new List<String>();

        private Settings()
        {
            
        }

        //this is for when we instantiate settings object from a saved file using the a different input_output class
        public static void setInstance(Settings retrieved)
        {
            instance = retrieved;
        }


        public void addName(String name)
        {   
            if(!AppNames.Contains(name)) AppNames.Add(name);
        }


        public List<String> getAppNames()
        {
            return AppNames;
        }


        public String getAppFolder()
        {
            String appFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\thisnonsensemuststop";

            if (!new DirectoryInfo(appFolder).Exists)
            {
                Directory.CreateDirectory(appFolder);
            }

            return appFolder;
        }

        public String getExcludedFilesLocation()
        {            return getAppFolder() + "\\excluded.lari";
        }

        public String getSettingsLocation()
        {
            return getAppFolder() + "\\settings.lari";
        }


        public String getReportName()
        {
            FileInfo file = new FileInfo(getAppFolder() + "\\" + reportName);

            if (!file.Exists)
            {
                File.Create(getAppFolder() + "\\" + reportName);
            }

            return reportName;
        }


       

        public static Settings getInstance()
        {
            if (instance == null)
            {
                instance = new Settings();
            }

            return instance;
        }


        public Boolean AppRunning {get{return appstatus;} set{appstatus= value;}}
    }
}
