using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOG_Config
{
    class Parameter
    {
       
    }
    class serialParameter
    {
        public static string comName = "COM1";
        public static string baudRate = "38400";
        public static string dataBit = "8";
        public static string stopBit = "1";
        public static string parityBit = "none";
    }
    class serialData
    {
        public static List<byte> buffer = new List<byte>(4096);
        public static UInt16 index = 0;
        public static List<byte> ReceiveData =  new List<byte>();


    }
   class CustomData
    {
        public static int CustomFreq = 0;
    }
}
