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
        public static bool DebugFlag = false;
        public static bool DebugSendFlag = false;
        public static bool DebugSendFreqFlag = false;
        public static bool DebugSend2piFlag = false;
        public static bool DebugSendLoopGainFlag = false;
        public static bool DebugSendUartCFGFlag = false;
        public static bool DebugSendModuleFlag = false;
        public static bool DebugModuleFlag = false;
        public static bool DebugUartCFGFlag = false;
        public static bool DebugFreqFlag = false;
        public static bool Debug2piFlag = false;
        public static bool DebugLoopGainFlag = false;
        public static bool DebugResetFlag = false;
        public static bool NextStepEnable = false;

        public static bool DebugSendSFtemParaFlag = false;
        public static bool DebugSendBiastemParaFlag = false;
        public static bool DebugSFtemParaFlag = false;
        public static bool DebugBiastemParaFlag = false;
        public static bool DebugSendtemParaONFlag = false;
        public static bool DebugSendtemParaOFFFlag = false;
        public static bool DebugtemParaONFlag = false;
        public static bool DebugtemParaOFFFlag = false;
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
        public static int ModuledataNum = 0;
        public static int ModuledataPara = 0;
        public static double SF_K1, SF_K2 = 0;
        public static double Bias_Kt, Bias_K3, Bias_K2, Bias_K1 = 0;
        public static int TemComSwitch = 0;
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
            Buad115 = 1,
            Buad614 = 0
        };
        public enum Upd
        {
            Upd_woshou = 0,
            Upd_400Hz = 1,
            Upd_1000Hz = 2,
            Upd_2000Hz = 3
        };
        public static int[] UartInfo = new int[6];
        public static string[] TriggerString = {"握手","盲发" };
        public static string[] ProtocolString = { "预留信息","北航协议", "润博协议","180908用户协议", };
        public static string[] BaudString = { "460800", "115200" ,"614400"};
        public static string[] UpdString = { "握手", "400Hz","1000Hz","2000Hz" };
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
    class TemParacls
    {
        public double[] d_SF_para = new double[2];
        public double[] d_Bias_para = new double[4];
        public Int32[] i_SF_para = new Int32[2];
        public Int32[] i_Bias_para = new Int32[4];
    }
}
