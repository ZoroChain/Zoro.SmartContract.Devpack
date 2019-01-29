namespace Neo.SmartContract.Framework.Services.Neo
{
    public class Block : Header
    {
        [Syscall("Zoro.Block.GetTransactionCount")]
        public extern int GetTransactionCount();

        [Syscall("Zoro.Block.GetTransactions")]
        public extern Transaction[] GetTransactions();

        [Syscall("Zoro.Block.GetTransaction")]
        public extern Transaction GetTransaction(int index);
    }
}
