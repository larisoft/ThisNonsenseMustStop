using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms; 
namespace ThisNonsenseMustStop
{
    //This is our engine;
    //we monitor the system every specified interval for applications trying to get online
    //once we identify them, we check if they are the application the user is currently using.
    //if they are not, we destroy them.
    //Easy right? I know.


    public class Monitor:CollectorObserver
    {
        //switch
        Boolean run = true;


        //Objects that watch this class for information
        List<OperationObserver> observers = new List<OperationObserver>();

        //a custom data structure for making sure our PIDS are unique and fall within those released in one console output after every 5 seconds; 
        PidCollector collector = new PidCollector();

         
        public Monitor()
        {   
            //once instantiated, start monitoring and reporting to observers
            collector.addObserver(this); 
        }

 
        //PID of current focused window
        uint CurrentPid = 0;

        //interval at which we scan for data-hungry programs
        int interval = 5000;
         

        Settings settings;
        //this method gets currently online apps. IT NEVER STOPS RUNNING.
        public void getOnlineApps()
        {
            //we use this to send a message to the commandline listing all network activities

            settings = Settings.getInstance();

            Process p = new Process();
            p.StartInfo.FileName = "netstat.exe";

            //save the results to a file
            p.StartInfo.Arguments = " -o 5  "; 
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.EnableRaisingEvents = true;
            p.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
            {   
                //report only when network is available
                if (Network.isConnected() && Settings.getInstance().AppRunning)
                {
                    ReportPid(e.Data);
                }
            };
            p.Start();
            p.BeginOutputReadLine();
            p.WaitForExit();
             
        }

        public void ReportPid(String data)
        {  
                if(data.Trim().Length < 1) return; 

                //get pid of this line
                uint pid = getAppId(data); 

                //add it to list of pids found in this console release
                collector.addPid(pid); 
         
        }


        //kill unallowed process
        public void killProcess(uint Pid, String Name)
        {
            if (!Exclude.getInstance().isExcluded(Pid) && !Exclude.getInstance().isExcluded(Name))
            {
                Process p2 = new Process();
                p2.StartInfo.FileName = "taskkill.exe";
                p2.StartInfo.Arguments = "/pid " + Pid + " /f /t"; 
                p2.StartInfo.UseShellExecute = false;
                p2.StartInfo.RedirectStandardOutput = true;
                p2.StartInfo.CreateNoWindow = true;
                p2.Start();
                notifyKilled(Pid, Name);

            }
            else
            {
                notifySkipped(Pid, Name);
            }
        }


        //get currently focused application
        public void getCurrentApplication()
        { 
            IntPtr hWnd = GetForegroundWindow(); 
            GetWindowThreadProcessId(hWnd, out CurrentPid); 
        }


        //This parses a single line of command output to find the pid of each data sucking process
        public uint getAppId(String Line)
        {
            if (Line.Length < 1) return 0;

            //convert to lowercase 
            Line = Line.ToLower();

            
            int left = 0;
            int right = Line.Length;

            if (!char.IsDigit(Line[right-1]))
            {
                return 0;
            }
            
            left = right-1;

            //while we move leftward and we see only digits, these must be part of the PID
            while (left > 0 && char.IsDigit(Line[left]))
            { 
                left--;
            }

            String result = "0"; 
            if (left > 0 && (right-left) <= Line.Length)
            {
                result = Line.Substring(left, right-left);
            }
            else
            {
                return 0;
            }

            return Convert.ToUInt32(result);
             
        }

       

        //get the name of an application by looking up the PID
        private String getAppByPid(uint procId)
        {   
            String name = null;
            int id = Convert.ToInt32(procId); 
            try
            {
                var proc = Process.GetProcessById(id);
               
                try
                {
                    name = ((String)proc.MainModule.ToString());
                }
                catch (Exception es)
                {
                    log("error getting name ");
                }

            }
            catch (Exception es)
            {
                log("error getting process");
            }
            return name; 

        }
        

       
         //accept a new observer
        //note that this design pattern (Observer Pattern) is used to neatly transport information between loosely coupled objects 
        public void addObserver(OperationObserver observer)
        {
            observers.Add(observer);
        }


        private void notifyKilled(uint pid, String Name)
        { 
            foreach (OperationObserver observer in observers)
            {
                observer.processKilled(Name, pid);
            }
        }


        private String extract_name(String name_raw)
        {
            if (name_raw == null || name_raw.Length < 1) return null;

            String name = name_raw.ToLower();

            int right = name.LastIndexOf(")"); 
            int left = right - 1; 
            while (name[--left] != '(') ;

            return name.Substring(left+1, right - left-1).Replace(".exe", "");
        }


        private void notifySkipped(uint pid, String Name)
        {

            foreach (OperationObserver observer in observers)
            {
                observer.processSkipped(Name, pid);
            }
        }



        //we have a complete list of PIDS in the last 5 seconds 
        public void batch_complete(List<uint> pids)
        { 

            getCurrentApplication();
            foreach (uint pid in pids)
            {
                 
                //get pid of current application

                //if current application is not this application, kill it
                if (pid != 0 && pid != CurrentPid && !Exclude.getInstance().isExcluded(pid))
                {
                    killProcess(pid, extract_name(getAppByPid(pid)));
                   // notifyKilled(pid, extract_name(getAppByPid(pid)));
                }
            }

        }


        //testing method
        private void log(String Message)
        {
            Console.WriteLine("ThisNonsenseMustSTop.Monitor: " + Message);
        }

        //code i dont like seeing 

        //get windows base dll for detecting foremost window (application running now)
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        //get windows base dll for detecting windows processes
        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

}
}