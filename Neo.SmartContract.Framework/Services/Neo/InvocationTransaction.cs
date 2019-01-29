namespace Neo.SmartContract.Framework.Services.Neo
{
    public class InvocationTransaction : Transaction
    {
        public extern byte[] Script
        {
            [Syscall("Zoro.InvocationTransaction.GetScript")]
            get;
        }
    }
}
