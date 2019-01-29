using System.Numerics;

namespace Neo.SmartContract.Framework.Services.Neo
{
    public static class Storage
    {
        public static extern StorageContext CurrentContext
        {
            [Syscall("Zoro.Storage.GetContext")]
            get;
        }

        [Syscall("Zoro.Storage.Get")]
        public static extern byte[] Get(StorageContext context, byte[] key);

        [Syscall("Zoro.Storage.Get")]
        public static extern byte[] Get(StorageContext context, string key);

        [Syscall("Zoro.Storage.Put")]
        public static extern void Put(StorageContext context, byte[] key, byte[] value);

        [Syscall("Zoro.Storage.Put")]
        public static extern void Put(StorageContext context, byte[] key, BigInteger value);

        [Syscall("Zoro.Storage.Put")]
        public static extern void Put(StorageContext context, byte[] key, string value);

        [Syscall("Zoro.Storage.Put")]
        public static extern void Put(StorageContext context, string key, byte[] value);

        [Syscall("Zoro.Storage.Put")]
        public static extern void Put(StorageContext context, string key, BigInteger value);

        [Syscall("Zoro.Storage.Put")]
        public static extern void Put(StorageContext context, string key, string value);

        [Syscall("Zoro.Storage.Delete")]
        public static extern void Delete(StorageContext context, byte[] key);

        [Syscall("Zoro.Storage.Delete")]
        public static extern void Delete(StorageContext context, string key);

        [Syscall("Zoro.Storage.Find")]
        public static extern Iterator<byte[], byte[]> Find(StorageContext context, byte[] prefix);

        [Syscall("Zoro.Storage.Find")]
        public static extern Iterator<string, byte[]> Find(StorageContext context, string prefix);
    }
}
