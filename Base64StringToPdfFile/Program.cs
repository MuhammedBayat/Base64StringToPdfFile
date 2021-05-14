using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64StringToPdfFile
{
    class Program
    {
        static void Main(string[] args)
        {

            if (!File.Exists(@"D:\test\file.pdf"))
            {
                string base64BinaryStr = @"Base 64 string";

                byte[] bytes = Convert.FromBase64String(base64BinaryStr);

                FileStream stream = new FileStream(@"D:\test\file.pdf", FileMode.CreateNew);
                BinaryWriter writer = new BinaryWriter(stream);
                writer.Write(bytes, 0, bytes.Length);
                writer.Close();
            }
        }
    }
}
