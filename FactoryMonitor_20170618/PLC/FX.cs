using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FactoryMonitor.PLC
{
    /// <summary>
    /// 
    /// </summary>
    public enum FxCommandConst : byte           // 命令字
    {
        /// <summary>元件读取，X,Y,M,S,T,C,D  </summary>
        FxCmdRead = 0x30,
        /// <summary>元件写入，X,Y,M,S,T,C,D  </summary>
        FxCmdWrite = 0x31,
        /// <summary> 强迫ON，X,Y,M,S,T,C   </summary>
        FxCmdForceOn = 0x37,
        /// <summary> 强迫OFF，X,Y,M,S,T,C  </summary>
        FxCmdForceOff = 0x38,                   
    }
    /// <summary>
    /// 
    /// </summary>
    public enum FxResponseConst : byte          // 命令字
    {   /// <summary>
    /// 
    /// </summary>
        FxACK = FxControlCode._ACK,             //接受正确
        /// <summary>
        /// 
        /// </summary>
        FxNAK = FxControlCode._NAK,             //接受错误
    }

    /// <summary>
    /// 
    /// </summary>
    public class FxControlCode
    {/// <summary>
    /// 
    /// </summary>
        public const byte _NUL = 0x00;          //  NULL 
        /// <summary>
        /// 
        /// </summary>
        public const byte _STX = 0x02;          //  主机报文开始 
        /// <summary>
        /// 
        /// </summary>
        public const byte _ETX = 0x03;          //  主机报文结束
        /// <summary>
        /// 
        /// </summary>
        public const byte _EOT = 0x04;          //  End of Transmission
        /// <summary>
        /// 
        /// </summary>
        public const byte _ENQ = 0x05;          //  （从机）来自从机的请求信号 
        /// <summary>
        /// 
        /// </summary>
        public const byte _ACK = 0x06;          //  （从机）PLC正确响应 
        /// <summary>
        /// 
        /// </summary>
        public const byte _NAK = 0x15;          //  （从机）PLC错误响应 
        /// <summary>
        /// 
        /// </summary>
        public const byte _DLE = 0x10;          //  Body Link Escape
        /// <summary>
        /// 
        /// </summary>
        public const byte _LF = 0x0A;           //  
        /// <summary>
        /// 
        /// </summary>
        public const byte _CR = 0x0D;           //  

        /// <summary>
        /// 
        /// </summary>
        public const byte _CLEAR = 0x0C;        //  
    }

    /// <summary>
    /// 
    /// </summary>
    public enum FxAddressLayoutType : ushort
    {/// <summary>
    /// 
    /// </summary>
        AddressLayoutBin = 1,
        /// <summary>
        /// 
        /// </summary>
        AddressLayoutByte = 2,
        /// <summary>
        /// 
        /// </summary>
        AddressLayoutInt16 = 3,
        /// <summary>
        /// 
        /// </summary>
        AddressLayoutInt32 = 4,
    }
    /// <summary>
    /// 
    /// </summary>
    public enum FxAddressType : short
    {/// <summary>
    /// 
    /// </summary>
        X = 1,
        /// <summary>
        /// 
        /// </summary>
        Y = 2,
        /// <summary>
        /// 
        /// </summary>
        M = 3,
        /// <summary>
        /// 
        /// </summary>
        S = 4,
        /// <summary>
        /// 
        /// </summary>
        T = 5,
        /// <summary>
        /// 
        /// </summary>
        C = 6,
        /// <summary>
        /// 
        /// </summary>
        D = 7,

        /// <summary>
        /// 常数
        /// </summary>
        K = 8,
        /// <summary>
        /// 
        /// </summary>
        Undefine = 0,                               // 为定义的错误地址类型
    }


}
