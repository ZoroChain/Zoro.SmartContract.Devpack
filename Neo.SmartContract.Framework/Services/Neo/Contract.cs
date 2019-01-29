namespace Neo.SmartContract.Framework.Services.Neo
{
    public class Contract
    {
        public extern byte[] Script
        {
            [Syscall("Zoro.Contract.GetScript")]
            get;
        }
       
        public extern bool IsPayable
        {
            [Syscall("Zoro.Contract.IsPayable")]
            get;
        }

        public extern StorageContext StorageContext
        {
            [Syscall("Zoro.Contract.GetStorageContext")]
            get;
        }

        [Syscall("Zoro.Contract.Create")]
        public static extern Contract Create(byte[] script, byte[] parameter_list, byte return_type, bool need_storage, string name, string version, string author, string email, string description);

        [Syscall("Zoro.Contract.Migrate")]
        public static extern Contract Migrate(byte[] script, byte[] parameter_list, byte return_type, bool need_storage, string name, string version, string author, string email, string description);

        [Syscall("Zoro.Contract.Destroy")]
        public static extern void Destroy();
    }
}
