namespace Neo.SmartContract.Framework.Services.Neo
{
    public class Transaction : IScriptContainer
    {
        public extern byte[] Hash
        {
            [Syscall("Zoro.Transaction.GetHash")]
            get;
        }

        public extern byte Type
        {
            [Syscall("Zoro.Transaction.GetType")]
            get;
        }

        [Syscall("Zoro.Transaction.GetAttributes")]
        public extern TransactionAttribute[] GetAttributes();
    }
}
