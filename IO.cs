using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text; 

namespace ThisNonsenseMustStop
{   

    //singleton class for all input/output operations
    //saves objects in json format
    class IO
    {
        private static IO instance;
        List<IO_Listener> Observers =  new List<IO_Listener>();
           
        //hide instantiation
        private IO() { } 
       
        public static IO getInstance(){ 

            if (instance == null)
            {
                instance = new IO(); 
            } 
            return instance; 
        }


        public void addObserver(IO_Listener listener)
        {
            this.Observers.Add(listener);
        }

        //save any type of object
        public void saveObject(object obj, String location)
        {
            try
            {
                IFormatter serializer = new BinaryFormatter(); 
                Stream stream = new FileStream(location, FileMode.Create, FileAccess.Write, FileShare.None); 
                serializer.Serialize(stream, obj);

                stream.Close();   
                foreach (IO_Listener i in Observers)
                {
                    i.objectsChanged(obj);
                }
            }
            catch (IOException es)
            {

            }
        }


        public object retrieveObject(String location){

            object obje = null;
             try
            {
                BinaryFormatter serializer = new BinaryFormatter();
                FileStream stream = File.Open(location, FileMode.Open);

                obje = serializer.Deserialize(stream);

                stream.Close();  
            }
            catch (IOException es)
            {

            }

            return obje;

        }

        // write string to file
        public void save(String path, String content)
        {
            File.WriteAllText(path, content);
        }

         

        //append stuff to already written file
        public void append(String file, String new_content)
        {
            String time = DateTime.Now.ToString() ; 
            File.AppendAllText(file, time + "\n" + new_content); 
        }

         
        public void moveDir(string from_path, String to_path, String dir_name)
        { 
            if (!new DirectoryInfo(to_path).Exists)
            {
                Directory.CreateDirectory(to_path);
            }

            //move file to destination
            String to = to_path + "\\" + dir_name;
            String from = from_path + "\\" + dir_name;

            try
            {
                Directory.Move(from, to);
            }
            catch (Exception es)
            {

            }
        }
          

         
    }
}
