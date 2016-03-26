using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms; 

namespace ThisNonsenseMustStop
{
    public partial class Form1 : Form, OperationObserver
    {
        
        Monitor monitor;
        public Form1()
        {
            InitializeComponent();
            load();
            startMonitoring();
        }

        HashSet<String> already_reported = new HashSet<string>();

        public void startMonitoring()
        {
            BackgroundWorker bg = new BackgroundWorker();
            bg.DoWork += (object sender, DoWorkEventArgs es) =>
            {
                monitor = new Monitor();
                monitor.addObserver(this);
                monitor.getOnlineApps();
            };

            bg.RunWorkerAsync();
        }


        public void load()
        {
            this.FormClosing+= (object sender, FormClosingEventArgs es) => {
                clean_up();
            };

            this.Text = "This Nonsense Must Stop!";

            //generate settings and exclude classes which are necessary for everything here;
            //instances of this class are not saved here because they are singletons.
             FactoryBuilder build = new FactoryBuilder(); 
                build.getExclude();
                build.getSettings(); 
            

            //add desktop shortcut
             
                
               String exePath  = Assembly.GetEntryAssembly().Location;
               String title = "This Nonsense Must Stop";
               String description = "Launch this Nonsense Must Stop";
               String linkLocation = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
               new ShortCutMaker().add_desktop_shortcut(linkLocation, exePath, title,description);
               
            //prevent this app from getting closed by itself
            Exclude.getInstance().addPid(Convert.ToUInt32(Process.GetCurrentProcess().Id));


        }

        private void clean_up()
        { 
            IO.getInstance().saveObject(Settings.getInstance(), Settings.getInstance().getSettingsLocation());
            IO.getInstance().saveObject(Exclude.getInstance(), Settings.getInstance().getExcludedFilesLocation());
        }


        public void processKilled(String Name, uint pid)
        {
            if (!already_reported.Contains(Name))
            {
                already_reported.Add(Name);

                if (Name == null || Name.Trim().Length < 1) Name = "Unknown Process";
                reportBox.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        reportBox.AppendText("\n " + Name + " Closed");
                        Settings.getInstance().addName(Name);
                    }
                    catch (NullReferenceException es)
                    {

                    }
                });
            }
            
        }

        public void processSkipped( String Name, uint pid)
        {

            if (Name == null || Name.Trim().Length < 1) Name = "Unknown Process";
            reportBox.Invoke((MethodInvoker)delegate
            {
                try
                {
                    reportBox.AppendText("\n " + Name + " allowed to consume data");
                    Settings.getInstance().addName(Name);
                }
                catch (NullReferenceException es)
                {

                }
            });
        }


        private void log(String Message)
        {

            Console.WriteLine("Form 1 : " + Message);
        }

        private void control_switch_Click(object sender, EventArgs e)
        {
            if (Settings.getInstance().AppRunning)
            {
                Settings.getInstance().AppRunning = false;
                control_switch.Image = Properties.Resources.off;
            }
            else
            { 
                Settings.getInstance().AppRunning = true;
                control_switch.Image = Properties.Resources.on_switch;

            }
        }

        private void close_about_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void about_Click(object sender, EventArgs e)
        {
            Form2 form = Form2.getInstance();
            form.Show();
            form.Focus();
        }

        private void add_exception_Click(object sender, EventArgs e)
        {
            Form3 form = Form3.getInstance();
            form.Show();
            form.Focus();
        }

        private void remove_exception_Click(object sender, EventArgs e)
        {
            Form4 form = Form4.getInstance();
            form.Show();
            form.Focus();
        }
         

    }
}
