namespace Neo.SmartContract.Framework.Services.Neo
{
    public class Iterator<TKey, TValue>
    {
        [Syscall("Zoro.Iterator.Next")]
        public extern bool Next();

        public extern TKey Key
        {
            [Syscall("Zoro.Iterator.Key")]
            get;
        }

        public extern TValue Value
        {
            [Syscall("Zoro.Iterator.Value")]
            get;
        }
    }
}
