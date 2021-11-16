#region usings 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Cliente
{
    public class Serialization
    {
        public static byte[] Serialize(object toSerialize)
        {
            MemoryStream memory = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(memory, toSerialize);
            return memory.ToArray();
        }

        public static object Deserialize(byte[] data)
        {
            MemoryStream memory = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Binder = new CurrentAssembyDeserializationBinder();

            return formatter.Deserialize(memory);
        }
    }

    public class CurrentAssembyDeserializationBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            return Type.GetType(String.Format("{0}, {1}", typeName, Assembly.GetExecutingAssembly().FullName));
        }
    }
}
