using System;
using System.Collections.Generic;
using System.Text;

namespace Neo.SmartContract.Framework.Services.Neo
{
    public class TransferLog : IApiInterface
    {
        public extern byte[] From
        {
            [Syscall("Zoro.NativeNEP5.TransferLog.GetFrom")]
            get;
        }
        public extern byte[] To
        {
            [Syscall("Zoro.NativeNEP5.TransferLog.GetTo")]
            get;
        }
        public extern long Value
        {
            [Syscall("Zoro.NativeNEP5.TransferLog.GetValue")]
            get;
        }
    }
}
