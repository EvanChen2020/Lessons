using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_SaveInstance
{
    class StudentService
    {
        public static void ObjectSerial(string File,Student objStudent)
        {
            FileStream fs = new FileStream(File, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, objStudent);
            fs.Close();
        }

        public static Student ObjectDeserial(string File)
        {
            FileStream fs = new FileStream(File, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Student objStudent = (Student)formatter.Deserialize(fs);
            fs.Close();
            return objStudent;
        }

    }
}
