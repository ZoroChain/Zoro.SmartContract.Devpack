namespace Neo.SmartContract.Framework.Services.Neo
{
    public static class Blockchain
    {
        [Syscall("Zoro.Blockchain.GetHeight")]
        public static extern uint GetHeight();

        [Syscall("Zoro.Blockchain.GetHeader")]
        public static extern Header GetHeader(uint height);

        [Syscall("Zoro.Blockchain.GetHeader")]
        public static extern Header GetHeader(byte[] hash);

        [Syscall("Zoro.Blockchain.GetBlock")]
        public static extern Block GetBlock(uint height);

        [Syscall("Zoro.Blockchain.GetBlock")]
        public static extern Block GetBlock(byte[] hash);

        [Syscall("Zoro.Blockchain.GetTransaction")]
        public static extern Transaction GetTransaction(byte[] hash);

        [Syscall("Zoro.Blockchain.GetValidators")]
        public static extern byte[][] GetValidators();

        [Syscall("Zoro.Blockchain.GetContract")]
        public static extern Contract GetContract(byte[] script_hash);
    }
}
