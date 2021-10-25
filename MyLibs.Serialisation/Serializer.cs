using System;
using System.IO;

namespace MyLibs.Serialisation
{
    public class Serializer
    {
        public void Serialize<T>(T data,string path )
        {
          using(StreamWriter file =new StreamWriter(path,true) )
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.serialize(file, data);



            }
        }
        public T Deserialize <T>(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                BinaryFormatter bf = new BinaryFormatter();
               return T bf.Deserialize(file, data);
            }
    }
}
