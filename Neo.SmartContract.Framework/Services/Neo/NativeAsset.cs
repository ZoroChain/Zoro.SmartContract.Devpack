using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Neo.SmartContract.Framework.Services.Neo
{
    public class NativeAsset
    {
        [Syscall("Zoro.NativeNEP5.Call")]
        public static extern byte[] Call(string method, byte[] assetId);

        [Syscall("Zoro.NativeNEP5.Call")]
        public static extern byte[] Call(string method, byte[] assetId, byte[] parameters);

        [Syscall("Zoro.NativeNEP5.GetTransferLog")]
        public static extern TransferLog GetTransferLog(byte[] assetId, byte[] txid);

    }
}