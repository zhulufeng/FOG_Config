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
        public static bool DebudFlag = false;

    }
   class CustomData
    {
        public static int CustomFreq = 0;
        public static string GyroType = null;
        public static string GyroNo = null;
        public static string GyroTypeNo = null;
        public static int clkFreq = 0;
        public static int Volt2pi = 0;
        public static int LoopGain = 0;

        public static string[] strGyroID = {"F50","F60","F70H","F70L","F98","F120"};

    }
    class PathString
    {
        public static string CFGDataBaseDirectory = System.AppDomain.CurrentDomain.BaseDirectory + "ConfigData";
        public static string CFGDataCurrentDirectory = null;
        public static string ClearDirectory = null;
    }
    class UartData
    {
        public enum TriggerNum
        {
            woshou = 0,
            mangfa = 1
        };
        public enum ProtocolNum
        {
            Reserve = 0,
            buaa = 1,
            rainbow = 2,
            ueser180908 = 3
        };
        public enum Buadrate
        {
            Buad460 = 0,
            Buad115 = 1
        };
        public enum Upd
        {
            Upd_woshou = 0,
            Upd_400Hz = 1,
            Upd_1000Hz = 2
        };
        public static int[] UartInfo = new int[6];
        public static string[] TriggerString = {"握手","盲发" };
        public static string[] ProtocolString = { "预留信息","北航协议", "润博协议","180908用户协议", };
        public static string[] BaudString = { "460800", "115200" };
        public static string[] UpdString = { "握手", "400Hz","1000Hz" };
    }
    class MyVersionInfo
    {
        public static int FGyroType;
        public static int[] Softime = new int[5];
        public static int[] HexTime = new int[5];
        public static int DotNum;
        public static string CoreID = null;
        public static string FuncInfo = null;
    }
}
