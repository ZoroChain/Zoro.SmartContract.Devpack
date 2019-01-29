namespace Neo.SmartContract.Framework.Services.Neo
{
    public class TransactionAttribute : IApiInterface
    {
        public extern byte Usage
        {
            [Syscall("Zoro.Attribute.GetUsage")]
            get;
        }

        public extern byte[] Data
        {
            [Syscall("Zoro.Attribute.GetData")]
            get;
        }
    }
}
